using System;
using System.Drawing;
using System.Windows.Forms;
using ElevatorProject.Model;

namespace ElevatorProject.View
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }
        public ResultForm(string time, Result result)
        {
            InitializeComponent();
            TimeBox.Text = time;
            PersonsBox.Text = DataBase.NumPersons.ToString();
            TransportedBox.Text = result.NumTransported.ToString();
            IdleBox.Text = result.NumIdleTransport.ToString();
            WeightBox.Text = result.TotalWeight.ToString();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Hide();
           StartForm startForm = new StartForm();
            startForm.Show();
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

        private void TimeBox_Enter(object sender, EventArgs e)
        {
            TimeBox.Text = TimeBox.Text;
        }
    }
}
