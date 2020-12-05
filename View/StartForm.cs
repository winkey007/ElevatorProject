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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            PersonsField.Text = "Enter the number of persons";
            FloorsField.Text = "Enter the number of floors";
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        Point lastPoint;
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
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

        private void PersonsField_Enter(object sender, EventArgs e)
        {
            if (PersonsField.Text == "Enter the number of persons")
           {
                PersonsField.Text = "";
                PersonsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                PersonsField.ForeColor = Color.Black;
            }
        }

        private void FloorsField_Enter(object sender, EventArgs e)
        {
            if (FloorsField.Text == "Enter the number of floors")
            {
                FloorsField.Text = "";
                FloorsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                FloorsField.ForeColor = Color.Black;
            }
        }

        private void PersonsField_Leave(object sender, EventArgs e)
        {
            if (PersonsField.Text == "")
            {
                PersonsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                PersonsField.ForeColor = Color.Gray;
                PersonsField.Text = "Enter the number of persons";
            }
        }

        private void FloorsField_Leave(object sender, EventArgs e)
        {
            if (FloorsField.Text == "")
            {
                FloorsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                FloorsField.ForeColor = Color.Gray;
                FloorsField.Text = "Enter the number of floors";
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (!int.TryParse(FloorsField.Text, out DataBase.NumFloors) || DataBase.NumFloors < 2)
            {
                FloorsErrorLabel.ForeColor = Color.Red;
                flag = false;
            }
            else if (FloorsErrorLabel.ForeColor == Color.Red)
                FloorsErrorLabel.ForeColor = Color.FromArgb(224, 224, 224);

            if (!int.TryParse(PersonsField.Text, out DataBase.NumPersons) || DataBase.NumPersons < 0)
            {
                PersonsErrorLabel.ForeColor = Color.Red;
                flag = false;
            }
            else if (PersonsErrorLabel.ForeColor == Color.Red)
                PersonsErrorLabel.ForeColor = Color.FromArgb(224, 224, 224);

            if (flag)
            {
                this.Hide();
                SimulationForm simulationForm = new SimulationForm();
                simulationForm.Show();
            }
        }
    }
}
