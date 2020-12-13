using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElevatorProject.Model;

namespace ElevatorProject.View
{
    public partial class SimulationForm : Form
    {
        private Elevator elevator;
        List<Person> PersonList = new List<Person>();
        public SimulationForm()
        {
            InitializeComponent();
            elevator = new Elevator();
        }

        private void CreatePersons(int Num)
        {
            for (int i = DataBase.NumPersons - Num; i < DataBase.NumPersons; i++)
            {
                Person person = new Person(i);
                PersonList.Add(person);
                person.UpdateStatus += setPersonStatus;
                person.UpdateCurrentFloor += setPersonFloor;
                person.UpdateElevatorList += elevator.updateElevatorList;
                person.Entered += elevator.AddTime;
                person.Transported += elevator.Transported;
                person.CheckFloor += elevator.getCurrentFloor;
                person.EventCloseDoor += elevator.CloseDoors;
                for (int j = 0; j < PersonList.Count - 1; j++)
                {
                    person.Alone += PersonList[j].Answer;
                    PersonList[j].Alone += person.Answer;
                }
                elevator.EventOpenDoors += person.EnterTheElevator;
               // elevator.EventOpenDoors += person.GetOffTheElevator;

                var task = new Task(() => person.CallTheElevator());
                task.Start();
            }
        }
        private void setPersonStatus(string status)
        {
            StatusBox.Invoke((MethodInvoker)(() => {
                StatusBox.Text = status;
            }));
        }
        private void setPersonFloor(string status)
        {
            StatusBox.Invoke((MethodInvoker)(() => {
                CurrentFloorPersonBox.Text = status;
            }));
        }
        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.Red;
            CloseButton.ForeColor = Color.White;
        }
        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.FromArgb(214, 255, 225);
            CloseButton.ForeColor = Color.Black;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void HeaderName_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void HeaderName_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            if (elevator.getStatus() == "Standby mode" || elevator.getStatus() == "Go emty to call")
            {
                Result result = new Result();
                elevator.SendResult(result);
                timer.Enabled = false;
                this.Hide();
                ResultForm resultForm = new ResultForm(TimeBox.Text, result);
                resultForm.Show();
            }
            else
            {
                ErrorLabel.ForeColor = Color.Red;
            }
        }
        public void setElevatorStatus(string Status)
        {
            StatusBox.Invoke((MethodInvoker)(() => {
                ElevatorBox.Text = Status;
            }));
            //switch (Status)
            //{
            //    case "Go emty to call":
            //        WaitStatusPic.Visible = false;
            //        CallStatusPic.Visible = true;
            //        break;
            //    case "Stand":
            //        CallStatusPic.Visible = false;
            //        StopStatusPic.Visible = true;
            //        break;
            //    case "Open doors":
            //        StopStatusPic.Visible = false;
            //        OpenStatusPic.Visible = true;
            //        break;
            //    case "Check mode":
            //        OpenStatusPic.Visible = false;
            //        CheckStatusPic.Visible = true;
            //        break;
            //    case "Close doors":
            //        CheckStatusPic.Visible = false;
            //        CloseStatusPic.Visible = true;
            //        break;
            //    case "Carry up":
            //        CloseStatusPic.Visible = false;
            //        UpStatusPic.Visible = true;
            //        break;
            //    case "Carry down":
            //        CloseStatusPic.Visible = false;
            //        DownStatusPic.Visible = true;
            //        break;
            //    case "Standby mode":
            //        CloseStatusPic.Visible = false;
            //        WaitStatusPic.Visible = true;
            //        break;
            //    default:
            //        break;
            //}
        }
        private void start_Tick(object sender, EventArgs e)
        {
            start.Enabled = false;
            timer.Enabled = true;
        }

        public void moveFloor()
        {
            DataBase.CurrentHeight = DataBase.HeightFloor;
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            DataBase.CurrentId++;
            ShowPeople(DataBase.CurrentId);
            /* DataBase.direction = -1;
             moveFloor();*/
        }
        private void LeftButton_Click(object sender, EventArgs e)
        {
            DataBase.CurrentId--;
            ShowPeople(DataBase.CurrentId);
            /*DataBase.direction = 1;
            moveFloor();*/
        }
        public void setNumTransported()
        {
            TransportedBox.Invoke((MethodInvoker)(() => {
                TransportedBox.Text = elevator.getTransported().ToString();
            }));
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            DataBase.NumPersons++;
            CreatePersons(1);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (DataBase.CurrentHeight > 0)
            {
                CurrentFloorBox.Location = new Point(CurrentFloorBox.Location.X, CurrentFloorBox.Location.Y + DataBase.direction * DataBase.FloorLength / DataBase.HeightFloor);
                ElevatorPic.Location = new Point(ElevatorPic.Location.X, ElevatorPic.Location.Y + DataBase.direction * DataBase.FloorLength / DataBase.HeightFloor);
                DataBase.CurrentHeight--;
            }
            else if (DataBase.CurrentHeight == 0)
            {
                CurrentFloorBox.Text = (Convert.ToInt32(CurrentFloorBox.Text) - DataBase.direction).ToString();
                DataBase.CurrentHeight--;
            }
            DataBase.time.setMs(DataBase.time.getMs() + 1);
            TimeBox.Text = ShowTime(DataBase.time);
            if (PersonList.Any())
            {
                Time time = DataBase.time - PersonList[DataBase.CurrentId].GetBirthdayTime();
                LifetimeBox.Text = ShowTime(time);
            }
        }

        private string ShowTime(Time time)
        {
            string Box;
            if (time.getMs() < 10)
                Box = time.getMs().ToString();
            else
            {
                time.setMs(0);
                time.setSec(time.getSec() + 1);
                Box = time.getMs().ToString();
            }

            //sec
            if (time.getSec() < 60)
            {
                if (time.getSec() < 10)
                {
                    Box = "0" + time.getSec().ToString() + ":" + Box;
                }
                else
                    Box = time.getSec().ToString() + ":" + Box;
            }
            else
            {
                time.setSec(0);
                time.setMin(time.getMin() + 1);
                Box = "0" + time.getSec().ToString() + ":" + Box;
            }

            //min
            if (time.getMin() < 60)
            {
                if (time.getMin() < 10)
                {
                    Box = "0" + time.getMin().ToString() + ":" + Box;
                }
                else
                    Box = time.getMin().ToString() + ":" + Box;
            }
            else
            {
                time.setMin(0);
                time.setH(time.getH() + 1);
                Box = "0" + time.getMin().ToString() + ":" + Box;
            }

            //house
            if (time.getH() < 24)
            {
                if (time.getH() < 10)
                {
                    Box = "0" + time.getH().ToString() + ":" + Box;
                }
                else
                    Box = time.getH().ToString() + ":" + Box;
            }
            else
            {
                Result result = new Result();
                elevator.SendResult(result);
                timer.Enabled = false;
                this.Hide();
                ResultForm resultForm = new ResultForm(TimeBox.Text, result);
                resultForm.Show();
            }
            return Box;
        }
        private void ShowPeople(int i)
        {
            if (i == -1)
            {
                i += PersonList.Count;
                DataBase.CurrentId = i;
            }
            if (i == PersonList.Count)
            {
                i = 0;
                DataBase.CurrentId = i;
            }
            if (PersonList.Count != 0)
            {
                NameBox.Text = "Person " + PersonList[i].GetId().ToString();
                StatusBox.Text = PersonList[i].GetStatus();
                CurrentFloorPersonBox.Text = PersonList[i].GetCurrentFloor().ToString();
                LifetimeBox.Text = "00:00:00:0";
            }
            else
            {
                NameBox.Text = "-";
                StatusBox.Text = "-";
                CurrentFloorPersonBox.Text = "-";
                LifetimeBox.Text = "-";
            }
        }

        private void SimulationForm_Shown(object sender, EventArgs e)
        {
            DataBase.CurrentHeight = -1;
            DataBase.FloorLength = DataBase.PathLength / DataBase.NumFloors;
            elevator.MoveFloor += moveFloor;
            elevator.UpdateStatus += setElevatorStatus;
            elevator.UpdateTransported += setNumTransported;
            DataBase.CurrentId = 0; DataBase.id = 0; DataBase.time.setSec(0); DataBase.time.setMs(0); DataBase.time.setMin(0); DataBase.time.setH(0);
            CreatePersons(DataBase.NumPersons);
            ShowPeople(DataBase.CurrentId);
            CurrentFloorBox.Text = elevator.getCurrentFloor().ToString();
            TimeBox.Text = "0" + DataBase.time.getH().ToString() + ":" + "0" + DataBase.time.getMin().ToString() + ":" + "0" + DataBase.time.getSec().ToString() + ":" + DataBase.time.getMs().ToString(); ;
            TransportedBox.Text = elevator.getTransported().ToString();
            ElevatorBox.Text = elevator.getStatus();
        }
    }
}