using System.ComponentModel;
using System.Windows.Forms;

namespace ElevatorProject.View
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Header = new System.Windows.Forms.Panel();
            this.HeaderName = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.PersonsField = new System.Windows.Forms.TextBox();
            this.PersonsLabel = new System.Windows.Forms.Label();
            this.FloorsField = new System.Windows.Forms.TextBox();
            this.FloorsLabel = new System.Windows.Forms.Label();
            this.PersonsErrorLabel = new System.Windows.Forms.Label();
            this.FloorsErrorLabel = new System.Windows.Forms.Label();
            this.ElevatorCapacityErrorLabel = new System.Windows.Forms.Label();
            this.ElevatorCapacityBox = new System.Windows.Forms.TextBox();
            this.ElevatorCapacityLabel = new System.Windows.Forms.Label();
            this.ElevatorCapacityPic = new System.Windows.Forms.PictureBox();
            this.Floors = new System.Windows.Forms.PictureBox();
            this.People = new System.Windows.Forms.PictureBox();
            this.MinErrorLabel = new System.Windows.Forms.Label();
            this.PersonWeightPic = new System.Windows.Forms.PictureBox();
            this.MinBox = new System.Windows.Forms.TextBox();
            this.PersonWeightLabel = new System.Windows.Forms.Label();
            this.MaxErrorLabel = new System.Windows.Forms.Label();
            this.MaxBox = new System.Windows.Forms.TextBox();
            this.MinLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElevatorCapacityPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Floors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.People)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonWeightPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.Header.Controls.Add(this.HeaderName);
            this.Header.Controls.Add(this.Logo);
            this.Header.Controls.Add(this.CloseButton);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(561, 42);
            this.Header.TabIndex = 22;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            // 
            // HeaderName
            // 
            this.HeaderName.AutoSize = true;
            this.HeaderName.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderName.Location = new System.Drawing.Point(45, 5);
            this.HeaderName.Name = "HeaderName";
            this.HeaderName.Size = new System.Drawing.Size(103, 33);
            this.HeaderName.TabIndex = 31;
            this.HeaderName.Text = "Elevator";
            this.HeaderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HeaderName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderName_MouseDown);
            this.HeaderName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderName_MouseMove);
            // 
            // Logo
            // 
            this.Logo.Image = global::ElevatorProject.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(42, 42);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 30;
            this.Logo.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(463, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(98, 42);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "x";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Green;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(98)))), ((int)(((byte)(232)))));
            this.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(212)))), ((int)(((byte)(74)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(12, 680);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(142, 63);
            this.StartButton.TabIndex = 26;
            this.StartButton.Text = "Start simulation";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PersonsField
            // 
            this.PersonsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonsField.ForeColor = System.Drawing.Color.Gray;
            this.PersonsField.Location = new System.Drawing.Point(175, 109);
            this.PersonsField.Multiline = true;
            this.PersonsField.Name = "PersonsField";
            this.PersonsField.Size = new System.Drawing.Size(281, 46);
            this.PersonsField.TabIndex = 27;
            this.PersonsField.Enter += new System.EventHandler(this.PersonsField_Enter);
            this.PersonsField.Leave += new System.EventHandler(this.PersonsField_Leave);
            // 
            // PersonsLabel
            // 
            this.PersonsLabel.AutoSize = true;
            this.PersonsLabel.Font = new System.Drawing.Font("Ink Free", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonsLabel.ForeColor = System.Drawing.Color.Black;
            this.PersonsLabel.Location = new System.Drawing.Point(174, 57);
            this.PersonsLabel.Name = "PersonsLabel";
            this.PersonsLabel.Size = new System.Drawing.Size(282, 37);
            this.PersonsLabel.TabIndex = 23;
            this.PersonsLabel.Text = "How many persons?";
            // 
            // FloorsField
            // 
            this.FloorsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FloorsField.ForeColor = System.Drawing.Color.Gray;
            this.FloorsField.Location = new System.Drawing.Point(111, 265);
            this.FloorsField.Multiline = true;
            this.FloorsField.Name = "FloorsField";
            this.FloorsField.Size = new System.Drawing.Size(271, 46);
            this.FloorsField.TabIndex = 25;
            this.FloorsField.Enter += new System.EventHandler(this.FloorsField_Enter);
            this.FloorsField.Leave += new System.EventHandler(this.FloorsField_Leave);
            // 
            // FloorsLabel
            // 
            this.FloorsLabel.AutoSize = true;
            this.FloorsLabel.Font = new System.Drawing.Font("Ink Free", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FloorsLabel.ForeColor = System.Drawing.Color.Black;
            this.FloorsLabel.Location = new System.Drawing.Point(113, 206);
            this.FloorsLabel.Name = "FloorsLabel";
            this.FloorsLabel.Size = new System.Drawing.Size(256, 37);
            this.FloorsLabel.TabIndex = 24;
            this.FloorsLabel.Text = "How many floors?";
            // 
            // PersonsErrorLabel
            // 
            this.PersonsErrorLabel.AutoSize = true;
            this.PersonsErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonsErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PersonsErrorLabel.Location = new System.Drawing.Point(325, 158);
            this.PersonsErrorLabel.Name = "PersonsErrorLabel";
            this.PersonsErrorLabel.Size = new System.Drawing.Size(112, 20);
            this.PersonsErrorLabel.TabIndex = 30;
            this.PersonsErrorLabel.Text = "Incorrect data";
            // 
            // FloorsErrorLabel
            // 
            this.FloorsErrorLabel.AutoSize = true;
            this.FloorsErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FloorsErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FloorsErrorLabel.Location = new System.Drawing.Point(260, 311);
            this.FloorsErrorLabel.Name = "FloorsErrorLabel";
            this.FloorsErrorLabel.Size = new System.Drawing.Size(112, 20);
            this.FloorsErrorLabel.TabIndex = 31;
            this.FloorsErrorLabel.Text = "Incorrect data";
            // 
            // ElevatorCapacityErrorLabel
            // 
            this.ElevatorCapacityErrorLabel.AutoSize = true;
            this.ElevatorCapacityErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElevatorCapacityErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ElevatorCapacityErrorLabel.Location = new System.Drawing.Point(335, 445);
            this.ElevatorCapacityErrorLabel.Name = "ElevatorCapacityErrorLabel";
            this.ElevatorCapacityErrorLabel.Size = new System.Drawing.Size(112, 20);
            this.ElevatorCapacityErrorLabel.TabIndex = 35;
            this.ElevatorCapacityErrorLabel.Text = "Incorrect data";
            // 
            // ElevatorCapacityBox
            // 
            this.ElevatorCapacityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElevatorCapacityBox.ForeColor = System.Drawing.Color.Gray;
            this.ElevatorCapacityBox.Location = new System.Drawing.Point(175, 396);
            this.ElevatorCapacityBox.Multiline = true;
            this.ElevatorCapacityBox.Name = "ElevatorCapacityBox";
            this.ElevatorCapacityBox.Size = new System.Drawing.Size(281, 46);
            this.ElevatorCapacityBox.TabIndex = 33;
            this.ElevatorCapacityBox.Enter += new System.EventHandler(this.ElevatorCapacityBox_Enter);
            this.ElevatorCapacityBox.Leave += new System.EventHandler(this.ElevatorCapacityBox_Leave);
            // 
            // ElevatorCapacityLabel
            // 
            this.ElevatorCapacityLabel.AutoSize = true;
            this.ElevatorCapacityLabel.Font = new System.Drawing.Font("Ink Free", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElevatorCapacityLabel.ForeColor = System.Drawing.Color.Black;
            this.ElevatorCapacityLabel.Location = new System.Drawing.Point(174, 344);
            this.ElevatorCapacityLabel.Name = "ElevatorCapacityLabel";
            this.ElevatorCapacityLabel.Size = new System.Drawing.Size(258, 37);
            this.ElevatorCapacityLabel.TabIndex = 32;
            this.ElevatorCapacityLabel.Text = "Elevator capacity";
            // 
            // ElevatorCapacityPic
            // 
            this.ElevatorCapacityPic.Image = global::ElevatorProject.Properties.Resources.carrying;
            this.ElevatorCapacityPic.Location = new System.Drawing.Point(12, 344);
            this.ElevatorCapacityPic.Name = "ElevatorCapacityPic";
            this.ElevatorCapacityPic.Size = new System.Drawing.Size(137, 118);
            this.ElevatorCapacityPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ElevatorCapacityPic.TabIndex = 34;
            this.ElevatorCapacityPic.TabStop = false;
            // 
            // Floors
            // 
            this.Floors.Image = global::ElevatorProject.Properties.Resources.floors;
            this.Floors.Location = new System.Drawing.Point(418, 193);
            this.Floors.Name = "Floors";
            this.Floors.Size = new System.Drawing.Size(131, 138);
            this.Floors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Floors.TabIndex = 29;
            this.Floors.TabStop = false;
            // 
            // People
            // 
            this.People.Image = global::ElevatorProject.Properties.Resources.people;
            this.People.Location = new System.Drawing.Point(12, 57);
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(137, 118);
            this.People.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.People.TabIndex = 28;
            this.People.TabStop = false;
            // 
            // MinErrorLabel
            // 
            this.MinErrorLabel.AutoSize = true;
            this.MinErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MinErrorLabel.Location = new System.Drawing.Point(232, 574);
            this.MinErrorLabel.Name = "MinErrorLabel";
            this.MinErrorLabel.Size = new System.Drawing.Size(112, 20);
            this.MinErrorLabel.TabIndex = 39;
            this.MinErrorLabel.Text = "Incorrect data";
            // 
            // PersonWeightPic
            // 
            this.PersonWeightPic.Image = global::ElevatorProject.Properties.Resources.man;
            this.PersonWeightPic.Location = new System.Drawing.Point(361, 481);
            this.PersonWeightPic.Name = "PersonWeightPic";
            this.PersonWeightPic.Size = new System.Drawing.Size(188, 185);
            this.PersonWeightPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PersonWeightPic.TabIndex = 38;
            this.PersonWeightPic.TabStop = false;
            // 
            // MinBox
            // 
            this.MinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinBox.ForeColor = System.Drawing.Color.Gray;
            this.MinBox.Location = new System.Drawing.Point(94, 525);
            this.MinBox.Multiline = true;
            this.MinBox.Name = "MinBox";
            this.MinBox.Size = new System.Drawing.Size(261, 46);
            this.MinBox.TabIndex = 37;
            this.MinBox.Enter += new System.EventHandler(this.MinBox_Enter);
            this.MinBox.Leave += new System.EventHandler(this.MinBox_Leave);
            // 
            // PersonWeightLabel
            // 
            this.PersonWeightLabel.AutoSize = true;
            this.PersonWeightLabel.Font = new System.Drawing.Font("Ink Free", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonWeightLabel.ForeColor = System.Drawing.Color.Black;
            this.PersonWeightLabel.Location = new System.Drawing.Point(57, 469);
            this.PersonWeightLabel.Name = "PersonWeightLabel";
            this.PersonWeightLabel.Size = new System.Drawing.Size(162, 37);
            this.PersonWeightLabel.TabIndex = 36;
            this.PersonWeightLabel.Text = "My weight";
            // 
            // MaxErrorLabel
            // 
            this.MaxErrorLabel.AutoSize = true;
            this.MaxErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MaxErrorLabel.Location = new System.Drawing.Point(232, 646);
            this.MaxErrorLabel.Name = "MaxErrorLabel";
            this.MaxErrorLabel.Size = new System.Drawing.Size(112, 20);
            this.MaxErrorLabel.TabIndex = 41;
            this.MaxErrorLabel.Text = "Incorrect data";
            // 
            // MaxBox
            // 
            this.MaxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxBox.ForeColor = System.Drawing.Color.Gray;
            this.MaxBox.Location = new System.Drawing.Point(94, 597);
            this.MaxBox.Multiline = true;
            this.MaxBox.Name = "MaxBox";
            this.MaxBox.Size = new System.Drawing.Size(261, 46);
            this.MaxBox.TabIndex = 40;
            this.MaxBox.Enter += new System.EventHandler(this.MaxBox_Enter);
            this.MaxBox.Leave += new System.EventHandler(this.MaxBox_Leave);
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Font = new System.Drawing.Font("Ink Free", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinLabel.ForeColor = System.Drawing.Color.Black;
            this.MinLabel.Location = new System.Drawing.Point(9, 534);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(65, 37);
            this.MinLabel.TabIndex = 42;
            this.MinLabel.Text = "Min";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Font = new System.Drawing.Font("Ink Free", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxLabel.ForeColor = System.Drawing.Color.Black;
            this.MaxLabel.Location = new System.Drawing.Point(9, 597);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(72, 37);
            this.MaxLabel.TabIndex = 43;
            this.MaxLabel.Text = "Max";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(561, 755);
            this.Controls.Add(this.PersonWeightPic);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.MaxErrorLabel);
            this.Controls.Add(this.MaxBox);
            this.Controls.Add(this.MinErrorLabel);
            this.Controls.Add(this.MinBox);
            this.Controls.Add(this.PersonWeightLabel);
            this.Controls.Add(this.ElevatorCapacityErrorLabel);
            this.Controls.Add(this.ElevatorCapacityPic);
            this.Controls.Add(this.ElevatorCapacityBox);
            this.Controls.Add(this.ElevatorCapacityLabel);
            this.Controls.Add(this.FloorsErrorLabel);
            this.Controls.Add(this.PersonsErrorLabel);
            this.Controls.Add(this.Floors);
            this.Controls.Add(this.People);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PersonsField);
            this.Controls.Add(this.PersonsLabel);
            this.Controls.Add(this.FloorsField);
            this.Controls.Add(this.FloorsLabel);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElevatorCapacityPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Floors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.People)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonWeightPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel Header;
        private Label CloseButton;
        private PictureBox Floors;
        private PictureBox People;
        private Button StartButton;
        private TextBox PersonsField;
        private Label PersonsLabel;
        private TextBox FloorsField;
        private Label FloorsLabel;
        private Label HeaderName;
        private PictureBox Logo;
        private Label PersonsErrorLabel;
        private Label FloorsErrorLabel;
        private Label ElevatorCapacityErrorLabel;
        private PictureBox ElevatorCapacityPic;
        private TextBox ElevatorCapacityBox;
        private Label ElevatorCapacityLabel;
        private Label MinErrorLabel;
        private PictureBox PersonWeightPic;
        private TextBox MinBox;
        private Label PersonWeightLabel;
        private Label MaxErrorLabel;
        private TextBox MaxBox;
        private Label MinLabel;
        private Label MaxLabel;
    }
}