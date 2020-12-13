using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElevatorProject.Model;

namespace ElevatorProject.View
{
    public partial class SimulationForm : Form
    {
        private Elevator _elevator;
        List<Person> _personList = new List<Person>();
        public SimulationForm()
        {
            InitializeComponent();
            _elevator = new Elevator();
        }

        private void CreatePersons(int num)
        {
            for (int i = DataBase.NumPersons - num; i < DataBase.NumPersons; i++)
            {
                Person person = new Person(i);
                _personList.Add(person);
                person.UpdateStatus += SetPersonStatus;
                person.UpdateCurrentFloor += SetPersonFloor;
                person.UpdateElevatorList += _elevator.UpdateElevatorList;
                person.Entered += _elevator.AddTime;
                person.Transported += _elevator.Transported;
                person.CheckFloor += _elevator.GetCurrentFloor;
                for (int j = 0; j < _personList.Count - 1; j++)
                {
                    person.Alone += _personList[j].Answer;
                    _personList[j].Alone += person.Answer;
                }
                _elevator.EventOpenDoors += person.EnterTheElevator;

                var task = new Task(() => person.CallTheElevator());
                task.Start();
            }
        }
        private void SetPersonStatus(string status)
        {
            StatusBox.Invoke((MethodInvoker)(() => {StatusBox.Text = status;}));
        }
        private void SetPersonFloor(string status)
        {
            StatusBox.Invoke((MethodInvoker)(() => {CurrentFloorPersonBox.Text = status;}));
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
        Point _lastPoint;
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - _lastPoint.X;
                Top += e.Y - _lastPoint.Y;
            }
        }
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            _lastPoint = new Point(e.X, e.Y);
        }
        private void HeaderName_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - _lastPoint.X;
                Top += e.Y - _lastPoint.Y;
            }
        }
        private void HeaderName_MouseDown(object sender, MouseEventArgs e)
        {
            _lastPoint = new Point(e.X, e.Y);
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            if (_elevator.GetStatus() == "Standby mode" || _elevator.GetStatus() == "Go emty to call")
            {
                Result result = new Result();
                _elevator.SendResult(result);
                timer.Enabled = false;
                Hide();
                ResultForm resultForm = new ResultForm(TimeBox.Text, result);
                resultForm.Show();
            }
            else
            {
                ErrorLabel.ForeColor = Color.Red;
            }
        }
        public void SetElevatorStatus(string status)
        {
            StatusBox.Invoke((MethodInvoker)(() => {ElevatorBox.Text = status;}));
            switch (status)
            {
                case "Go emty to call":
                    WaitStatusPic.Invoke((MethodInvoker)(() => { WaitStatusPic.Visible = false; }));
                    CallStatusPic.Invoke((MethodInvoker)(() => { CallStatusPic.Visible = true; }));
                    break;
                case "Stand":
                    StopStatusPic.Invoke((MethodInvoker)(() => { StopStatusPic.Visible = true; }));
                    UpStatusPic.Invoke((MethodInvoker)(() => { UpStatusPic.Visible = false; }));
                    DownStatusPic.Invoke((MethodInvoker)(() => { DownStatusPic.Visible = false; }));
                    CallStatusPic.Invoke((MethodInvoker)(() => { CallStatusPic.Visible = false; }));
                    break;
                case "Open doors":
                    StopStatusPic.Invoke((MethodInvoker)(() => { StopStatusPic.Visible = false; }));
                    OpenStatusPic.Invoke((MethodInvoker)(() => { OpenStatusPic.Visible = true; }));
                    break;
                case "Check mode":
                    CheckStatusPic.Invoke((MethodInvoker)(() => { CheckStatusPic.Visible = true; }));
                    OpenStatusPic.Invoke((MethodInvoker)(() => { OpenStatusPic.Visible = false; }));
                    OverloadStatusPic.Invoke((MethodInvoker)(() => { OverloadStatusPic.Visible = false; }));
                    break;
                case "Close doors":
                    CheckStatusPic.Invoke((MethodInvoker)(() => { CheckStatusPic.Visible = false; }));
                    CloseStatusPic.Invoke((MethodInvoker)(() => { CloseStatusPic.Visible = true; }));
                    break;
                case "Carry up":
                    UpStatusPic.Invoke((MethodInvoker)(() => { UpStatusPic.Visible = true; }));
                    CloseStatusPic.Invoke((MethodInvoker)(() => { CloseStatusPic.Visible = false; }));
                    break;
                case "Carry down":
                    DownStatusPic.Invoke((MethodInvoker)(() => { DownStatusPic.Visible = true; }));
                    CloseStatusPic.Invoke((MethodInvoker)(() => { CloseStatusPic.Visible = false; }));
                    break;
                case "Standby mode":
                    WaitStatusPic.Invoke((MethodInvoker)(() => { WaitStatusPic.Visible = true; }));
                    CloseStatusPic.Invoke((MethodInvoker)(() => { CloseStatusPic.Visible = false; }));
                    break;
                case "Signal Overload":
                    OverloadStatusPic.Invoke((MethodInvoker)(() => { OverloadStatusPic.Visible = true; }));
                    CheckStatusPic.Invoke((MethodInvoker)(() => { CheckStatusPic.Visible = false; }));
                    break;
            }
        }
        public void MoveFloor()
        {
            DataBase.CurrentHeight = DataBase.HeightFloor;
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            DataBase.CurrentId++;
            ShowPeople(DataBase.CurrentId);
        }
        private void LeftButton_Click(object sender, EventArgs e)
        {
            DataBase.CurrentId--;
            ShowPeople(DataBase.CurrentId);
        }
        public void SetNumTransported()
        {
            TransportedBox.Invoke((MethodInvoker)(() => {TransportedBox.Text = _elevator.GetTransported().ToString();}));
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
                CurrentFloorBox.Location = new Point(CurrentFloorBox.Location.X, CurrentFloorBox.Location.Y + DataBase.Direction * DataBase.FloorLength / DataBase.HeightFloor);
                ElevatorPic.Location = new Point(ElevatorPic.Location.X, ElevatorPic.Location.Y + DataBase.Direction * DataBase.FloorLength / DataBase.HeightFloor);
                DataBase.CurrentHeight--;
            }
            else if (DataBase.CurrentHeight == 0)
            {
                CurrentFloorBox.Text = (Convert.ToInt32(CurrentFloorBox.Text) - DataBase.Direction).ToString();
                DataBase.CurrentHeight--;
            }

            DataBase.Time.Ms = DataBase.Time.Ms + 1;
            TimeBox.Text = ShowTime(DataBase.Time);
            if (_personList.Any())
            {
                Time time = DataBase.Time - _personList[DataBase.CurrentId].BirthdayTime;
                LifetimeBox.Text = ShowTime(time);
            }
        }

        private string ShowTime(Time time)
        {
            string box;
            if (time.Ms < 10)
                box = time.Ms.ToString();
            else
            {
                time.Ms = 0;
                time.Sec++;
                box = time.Ms.ToString();
            }

            //sec
            if (time.Sec < 60)
            {
                if (time.Sec < 10)
                {
                    box = "0" + time.Sec.ToString() + ":" + box;
                }
                else
                    box = time.Sec.ToString() + ":" + box;
            }
            else
            {
                time.Sec = 0;
                time.Min++;
                box = "0" + time.Sec.ToString() + ":" + box;
            }

            //min
            if (time.Min < 60)
            {
                if (time.Min < 10)
                {
                    box = "0" + time.Min.ToString() + ":" + box;
                }
                else
                    box = time.Min.ToString() + ":" + box;
            }
            else
            {
                time.Min = 0;
                time.H++;
                box = "0" + time.Min.ToString() + ":" + box;
            }

            //house
            if (time.H < 24)
            {
                if (time.H < 10)
                {
                    box = "0" + time.H.ToString() + ":" + box;
                }
                else
                    box = time.H.ToString() + ":" + box;
            }
            else
            {
                Result result = new Result();
                _elevator.SendResult(result);
                timer.Enabled = false;
                Hide();
                ResultForm resultForm = new ResultForm(TimeBox.Text, result);
                resultForm.Show();
            }
            return box;
        }
        private void ShowPeople(int i)
        {
            if (i == -1)
            {
                i += _personList.Count;
                DataBase.CurrentId = i;
            }
            if (i == _personList.Count)
            {
                i = 0;
                DataBase.CurrentId = i;
            }
            if (_personList.Count != 0)
            {
                NameBox.Text = "Person " + _personList[i].Id;
                StatusBox.Text = _personList[i].Status;
                CurrentFloorPersonBox.Text = _personList[i].CurrentFloor.ToString();
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
            _elevator.MoveFloor += MoveFloor;
            _elevator.UpdateStatus += SetElevatorStatus;
            _elevator.UpdateTransported += SetNumTransported;
            DataBase.CurrentId = 0; DataBase.Id = 0;
            CreatePersons(DataBase.NumPersons);
            ShowPeople(DataBase.CurrentId);
            CurrentFloorBox.Text = _elevator.GetCurrentFloor().ToString();
            TimeBox.Text = "0" + DataBase.Time.H.ToString() + ":" + "0" + DataBase.Time.Min.ToString() + ":" + "0" + DataBase.Time.Sec.ToString() + ":" + DataBase.Time.Ms.ToString(); ;
            TransportedBox.Text = _elevator.GetTransported().ToString();
            ElevatorBox.Text = _elevator.GetStatus();
        }
    }
}