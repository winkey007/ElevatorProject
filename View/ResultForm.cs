using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            TransportedBox.Text = result.getNumTransported().ToString();
            IdleBox.Text = result.getNumIdleTransport().ToString();
            WeightBox.Text = result.getTotalWeight().ToString();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
           StartForm startForm = new StartForm();
            startForm.Show();
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
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void HeaderName_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void TimeBox_Enter(object sender, EventArgs e)
        {
            TimeBox.Text = TimeBox.Text;
        }
    }
}
