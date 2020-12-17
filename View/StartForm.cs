﻿using System;
using System.Drawing;
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
            ElevatorCapacityBox.Text = "Enter the max weight of elevator";
            MinBox.Text = "Enter the min weight of person";
            MaxBox.Text = "Enter the max weight of person";
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

        Point _lastPoint;
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
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

        private void PersonsField_Enter(object sender, EventArgs e)
        {
            if (PersonsField.Text != "Enter the number of persons") return;
            PersonsField.Text = "";
            PersonsField.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PersonsField.ForeColor = Color.Black;
        }

        private void FloorsField_Enter(object sender, EventArgs e)
        {
            if (FloorsField.Text != "Enter the number of floors") return;
            FloorsField.Text = "";
            FloorsField.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FloorsField.ForeColor = Color.Black;
        }
        private void ElevatorCapacityBox_Enter(object sender, EventArgs e)
        {
            if (ElevatorCapacityBox.Text != "Enter the max weight of elevator") return;
            ElevatorCapacityBox.Text = "";
            ElevatorCapacityBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ElevatorCapacityBox.ForeColor = Color.Black;
        }
        private void MinBox_Enter(object sender, EventArgs e)
        {
            if (MinBox.Text != "Enter the min weight of person") return;
            MinBox.Text = "";
            MinBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MinBox.ForeColor = Color.Black;
        }
        private void MaxBox_Enter(object sender, EventArgs e)
        {
            if (MaxBox.Text != "Enter the max weight of person") return;
            MaxBox.Text = "";
            MaxBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MaxBox.ForeColor = Color.Black;
        }
        private void ElevatorCapacityBox_Leave(object sender, EventArgs e)
        {
            if (ElevatorCapacityBox.Text != "") return;
            ElevatorCapacityBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ElevatorCapacityBox.ForeColor = Color.Gray;
            ElevatorCapacityBox.Text = "Enter the max weight of elevator";
        }
        private void MinBox_Leave(object sender, EventArgs e)
        {
            if (MinBox.Text != "") return;
            MinBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MinBox.ForeColor = Color.Gray;
            MinBox.Text = "Enter the min weight of person";
        }
        private void MaxBox_Leave(object sender, EventArgs e)
        {
            if (MaxBox.Text != "") return;
            MaxBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MaxBox.ForeColor = Color.Gray;
            MaxBox.Text = "Enter the max weight of person";
        }
        private void PersonsField_Leave(object sender, EventArgs e)
        {
            if (PersonsField.Text != "") return;
            PersonsField.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PersonsField.ForeColor = Color.Gray;
            PersonsField.Text = "Enter the number of persons";
        }

        private void FloorsField_Leave(object sender, EventArgs e)
        {
            if (FloorsField.Text == "")
            {
                FloorsField.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
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

            if (!int.TryParse(ElevatorCapacityBox.Text, out DataBase.MaxElevatorWeight) || DataBase.MaxElevatorWeight < 1)
            {
                ElevatorCapacityErrorLabel.ForeColor = Color.Red;
                flag = false;
            }
            else if (ElevatorCapacityErrorLabel.ForeColor == Color.Red)
                ElevatorCapacityErrorLabel.ForeColor = Color.FromArgb(224, 224, 224);

            if (!int.TryParse(MaxBox.Text, out DataBase.MaxPersonWeight) || DataBase.MaxPersonWeight < 1 || DataBase.MaxPersonWeight > DataBase.MaxElevatorWeight)
            {
                MaxErrorLabel.ForeColor = Color.Red;
                flag = false;
            }
            else if (MaxLabel.ForeColor == Color.Red)
                MaxErrorLabel.ForeColor = Color.FromArgb(224, 224, 224);

            if (!int.TryParse(MinBox.Text, out DataBase.MinPersonWeight) || DataBase.MinPersonWeight < 1 || DataBase.MinPersonWeight > DataBase.MaxPersonWeight)
            {
                MinErrorLabel.ForeColor = Color.Red;
                flag = false;
            }
            else if (MinLabel.ForeColor == Color.Red)
                MinErrorLabel.ForeColor = Color.FromArgb(224, 224, 224);

            if (flag)
            {
                Hide();
                SimulationForm simulationForm = new SimulationForm();
                simulationForm.Show();
            }
        }
    }
}
