﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
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
           // for (int i = 0; i < DataBase.NumFloors; i++)
            //    AddPersonList(i);
        }

        private void CreatePersons(int num)
        {
            for (var i = DataBase.NumPersons - num; i < DataBase.NumPersons; i++)
            {
                var person = new Person(i);
               // if (_personList.All(t => t.CurrentFloor != person.CurrentFloor))
               //     AddPersonList(person.CurrentFloor);
                UpdateFloorList(person.CurrentFloor,person.Id,true);
                _personList.Add(person);
                person.UpdateStatus += SetPersonStatus;
                person.UpdateCurrentFloor += SetPersonFloor;
                person.UpdateElevatorList += _elevator.UpdateElevatorList;
                person.Entered += _elevator.AddTime;
                person.Transported += _elevator.Transported;
                person.CheckFloor += _elevator.GetCurrentFloor;
                person.UpdateFloorList += UpdateFloorList;
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
        public void SetNumTransported(int weight)
        {
            NumPersonsBox.Invoke((MethodInvoker)(() => { NumPersonsBox.Text = _elevator.PersonsList.Count.ToString() + " / " + _elevator.NumTransported.ToString()
                                 .ToString() + " / " + (_personList.Count - _elevator.PersonsList.Count - _elevator.NumTransported); }));
            WeightBox.Invoke((MethodInvoker)(() => { WeightBox.Text = weight.ToString() + " / " + Elevator.MaxWeight.ToString(); }));
        }
        private void SetElevatorList(string status)
        {
            ElevatorListBox.Invoke((MethodInvoker)(() => { ElevatorListBox.Text = status; }));
        }
        private void SetPersonStatus(string status)
        {
            StatusBox.Invoke((MethodInvoker)(() => {StatusBox.Text = status;}));
        }
        private void SetPersonFloor(string status)
        {
            StatusBox.Invoke((MethodInvoker)(() => {FloorsPersonBox.Text = status + FloorsPersonBox.Text.Substring((Convert.ToInt32(status) + DataBase.Direction).ToString().Length); }));
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

        private void AddPersonList(int currentFloor)
        {
            //if (ElevatorRoad.Controls[currentFloor.ToString() + "_FloorPersonBox"] != null)
           //     return;
            PictureBox picture = new PictureBox
            {
                Image = Properties.Resources.human,
                SizeMode = PictureBoxSizeMode.Zoom,
                TabStop = false,
                Visible = false,
                Height = DataBase.FloorLength < 30 ? Convert.ToInt32(0.9 * DataBase.FloorLength) : 30
            };
            picture.Width = Convert.ToInt32(picture.Height / DataBase.Scaller);
            picture.Name = currentFloor.ToString() + "_FloorPersonPic";
            picture.Location = new Point(0, ElevatorRoad.Height - ((currentFloor - 1) * DataBase.FloorLength + picture.Height));
            picture.Cursor = Cursors.Default;
            ElevatorRoad.Controls.Add(picture);

            TextBox text = new TextBox
            {
                BackColor = Color.FromArgb(152, 171, 247),
                Font = new Font("Microsoft Sans Serif", picture.Height*14/34f, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204))),
                ForeColor = Color.Red,
                Location = new Point(picture.Width + 5, picture.Location.Y),
                Multiline = true,
                Visible = false,
                Name = currentFloor.ToString() + "_FloorPersonBox",
                ReadOnly = true,
                Size = new Size(ElevatorRoad.Width-(CurrentFloorBox.Width + picture.Width + 15), picture.Height),
                TextAlign = HorizontalAlignment.Center,
                Cursor = Cursors.IBeam
            };
            ElevatorRoad.Controls.Add(text);
        }

        private void UpdateFloorList(int currentFloor, int id, bool add)
        {
            Control box = ElevatorRoad.Controls[currentFloor.ToString() + "_FloorPersonBox"];
            if (add)
            {
                if (!box.Visible)
                {
                    Control pic = ElevatorRoad.Controls[currentFloor.ToString() + "_FloorPersonPic"];
                    box.Invoke((MethodInvoker)(() => { box.Visible = true; }));
                    pic.Invoke((MethodInvoker)(() => { pic.Visible = true; }));
                }
                box.Invoke((MethodInvoker)(() => { box.Text = id.ToString() + " " + box.Text; }));
            }
            else
            {
                if (box.Text == id.ToString() + " ")
                {
                    Control pic = ElevatorRoad.Controls[currentFloor.ToString() + "_FloorPersonPic"];
                    box.Invoke((MethodInvoker)(() => { box.Text = ""; }));
                    box.Invoke((MethodInvoker)(() => { box.Visible = false; }));
                    pic.Invoke((MethodInvoker)(() => { pic.Visible = false; }));
                }
                box.Invoke((MethodInvoker)(() => { box.Text = box.Text.Replace(id.ToString() + " ", ""); }));
            }
        }
        private void FinishButton_Click(object sender, EventArgs e)
        {
            if (_elevator.PersonsList.Count == 0)
            {
                Result result = new Result();
                _elevator.SendResult(result);
                timer.Enabled = false;
                ResultForm resultForm = new ResultForm(TimeBox.Text, result);
                resultForm.Show();
                Close();
            }
            else
            {
                ErrorLabel.ForeColor = Color.Red;
            }
        }
        public void SetElevatorStatus(string status)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer
            {
                SoundLocation = Environment.CurrentDirectory + @"\..\..\Sounds\"
            };
            StatusBox.Invoke((MethodInvoker)(() => {ElevatorBox.Text = status;}));
            switch (status)
            {
                case "Go emty to call":
                    CloseStatusPic.Invoke((MethodInvoker)(() => { CloseStatusPic.Visible = false; }));
                    WaitStatusPic.Invoke((MethodInvoker)(() => { WaitStatusPic.Visible = false; }));
                    CallStatusPic.Invoke((MethodInvoker)(() => { CallStatusPic.Visible = true; }));
                    player.SoundLocation += "call";
                    break;
                case "Stand":
                    StopStatusPic.Invoke((MethodInvoker)(() => { StopStatusPic.Visible = true; }));
                    UpStatusPic.Invoke((MethodInvoker)(() => { UpStatusPic.Visible = false; }));
                    DownStatusPic.Invoke((MethodInvoker)(() => { DownStatusPic.Visible = false; }));
                    CallStatusPic.Invoke((MethodInvoker)(() => { CallStatusPic.Visible = false; }));
                    player.SoundLocation += "stop";
                    break;
                case "Open doors":
                    StopStatusPic.Invoke((MethodInvoker)(() => { StopStatusPic.Visible = false; }));
                    OpenStatusPic.Invoke((MethodInvoker)(() => { OpenStatusPic.Visible = true; }));
                    player.SoundLocation += "open";
                    break;
                case "Check mode":
                    CheckStatusPic.Invoke((MethodInvoker)(() => { CheckStatusPic.Visible = true; }));
                    OpenStatusPic.Invoke((MethodInvoker)(() => { OpenStatusPic.Visible = false; }));
                    OverloadStatusPic.Invoke((MethodInvoker)(() => { OverloadStatusPic.Visible = false; }));
                    player.SoundLocation += "check";
                    break;
                case "Close doors":
                    CheckStatusPic.Invoke((MethodInvoker)(() => { CheckStatusPic.Visible = false; }));
                    CloseStatusPic.Invoke((MethodInvoker)(() => { CloseStatusPic.Visible = true; }));
                    player.SoundLocation += "close";
                    break;
                case "Carry up":
                    UpStatusPic.Invoke((MethodInvoker)(() => { UpStatusPic.Visible = true; }));
                    CloseStatusPic.Invoke((MethodInvoker)(() => { CloseStatusPic.Visible = false; }));
                    player.SoundLocation += "up";
                    break;
                case "Carry down":
                    DownStatusPic.Invoke((MethodInvoker)(() => { DownStatusPic.Visible = true; }));
                    CloseStatusPic.Invoke((MethodInvoker)(() => { CloseStatusPic.Visible = false; }));
                    player.SoundLocation += "down";
                    break;
                case "Standby mode":
                    WaitStatusPic.Invoke((MethodInvoker)(() => { WaitStatusPic.Visible = true; }));
                    CloseStatusPic.Invoke((MethodInvoker)(() => { CloseStatusPic.Visible = false; }));
                    player.SoundLocation += "wait";
                    break;
                case "Signal Overload":
                    OverloadStatusPic.Invoke((MethodInvoker)(() => { OverloadStatusPic.Visible = true; }));
                    CheckStatusPic.Invoke((MethodInvoker)(() => { CheckStatusPic.Visible = false; }));
                    player.SoundLocation += "overload";
                    break;
            }
            player.SoundLocation += new Random().Next(0, 3).ToString() + ".wav";
            player.Play();
        }
        public void MoveFloor()
        {
            DataBase.CurrentHeight = DataBase.HeightFloor;
            DataBase.CurrentLength = DataBase.FloorLength;
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
        private void CreateButton_Click(object sender, EventArgs e)
        {
            DataBase.NumPersons++;
            CreatePersons(1);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (DataBase.CurrentHeight > 0)
            {
                CurrentFloorBox.Location = new Point(CurrentFloorBox.Location.X, CurrentFloorBox.Location.Y + DataBase.Direction * DataBase.CurrentLength / DataBase.CurrentHeight);
                ElevatorPic.Location = new Point(ElevatorPic.Location.X, ElevatorPic.Location.Y + DataBase.Direction * DataBase.CurrentLength / DataBase.CurrentHeight);
                DataBase.CurrentLength -= DataBase.CurrentLength / DataBase.CurrentHeight;
                DataBase.CurrentHeight--;
            }
            else if (DataBase.CurrentHeight == 0)
            {
                CurrentFloorBox.Text = (Convert.ToInt32(CurrentFloorBox.Text) - DataBase.Direction).ToString();
                DataBase.CurrentHeight--;
            }

            DataBase.Time.Ms = DataBase.Time.Ms + 1;
            TimeBox.Text = ShowTime(DataBase.Time);
            if (!_personList.Any()) return;
            var time =  _personList[DataBase.CurrentId].DeathTime > new Time() ? _personList[DataBase.CurrentId].DeathTime : (DataBase.Time - _personList[DataBase.CurrentId].BirthdayTime);
            LifetimeBox.Text = ShowTime(time);
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

            if (_personList.Count == 0) return;
            NameBox.Text = "Person " + _personList[i].Id;
            StatusBox.Text = _personList[i].Status;
            FloorsPersonBox.Text = _personList[i].CurrentFloor.ToString()+" / " + _personList[i].BirthdayFloor.ToString() + " / " + _personList[i].DestinationFloor.ToString();
            LifetimeBox.Text = "00:00:00:0";
        }

        private void AddPersonImage(int CurrentFloor, int Id)
        {

        }
        private void SimulationForm_Shown(object sender, EventArgs e)
        {
            DataBase.CurrentHeight = -1;
            DataBase.FloorLength = DataBase.PathLength / (DataBase.NumFloors-1);
            _elevator.MoveFloor += MoveFloor;
            _elevator.UpdateStatus += SetElevatorStatus;
            _elevator.UpdateTransported += SetNumTransported;
            _elevator.EventUpdateElevatorList += SetElevatorList;
            _elevator.UpdateFloorList += UpdateFloorList;
            _elevator.AddFloorList += AddPersonList;
            DataBase.CurrentId = 0; DataBase.Id = 0;
            for (int i = 0; i <= DataBase.NumFloors; i++)
                   AddPersonList(i);
            CreatePersons(DataBase.NumPersons);
            ShowPeople(DataBase.CurrentId);
            CurrentFloorBox.Text = _elevator.CurrentFloor.ToString();
            TimeBox.Text = "0" + DataBase.Time.H.ToString() + ":" + "0" + DataBase.Time.Min.ToString() + ":" + "0" + DataBase.Time.Sec.ToString() + ":" + DataBase.Time.Ms.ToString();
            NumPersonsBox.Text = _elevator.PersonsList.Count.ToString() + " / " + _elevator.NumTransported.ToString()
                                 .ToString() + " / " + (_personList.Count - _elevator.PersonsList.Count - _elevator.NumTransported);
            ElevatorBox.Text = _elevator.Status;
            WeightBox.Text = "0 / " + Elevator.MaxWeight;
            Person.random = new Random();
        }

    }
}