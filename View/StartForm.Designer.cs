namespace ElevatorProject.View
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.CloseButton = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.PersonsField = new System.Windows.Forms.TextBox();
            this.PersonsLabel = new System.Windows.Forms.Label();
            this.FloorsField = new System.Windows.Forms.TextBox();
            this.FloorsLabel = new System.Windows.Forms.Label();
            this.PersonsErrorLabel = new System.Windows.Forms.Label();
            this.FloorsErrorLabel = new System.Windows.Forms.Label();
            this.Floors = new System.Windows.Forms.PictureBox();
            this.People = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Floors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.People)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
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
            this.Header.Size = new System.Drawing.Size(472, 42);
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
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(430, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(42, 42);
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
            this.StartButton.Location = new System.Drawing.Point(12, 328);
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
            this.FloorsField.Location = new System.Drawing.Point(22, 266);
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
            this.FloorsLabel.Location = new System.Drawing.Point(24, 207);
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
            this.FloorsErrorLabel.Location = new System.Drawing.Point(171, 312);
            this.FloorsErrorLabel.Name = "FloorsErrorLabel";
            this.FloorsErrorLabel.Size = new System.Drawing.Size(112, 20);
            this.FloorsErrorLabel.TabIndex = 31;
            this.FloorsErrorLabel.Text = "Incorrect data";
            // 
            // Floors
            // 
            this.Floors.Image = global::ElevatorProject.Properties.Resources.floors;
            this.Floors.Location = new System.Drawing.Point(329, 194);
            this.Floors.Name = "Floors";
            this.Floors.Size = new System.Drawing.Size(131, 138);
            this.Floors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Floors.TabIndex = 29;
            this.Floors.TabStop = false;
            // 
            // People
            // 
            this.People.Image = global::ElevatorProject.Properties.Resources.people;
            this.People.Location = new System.Drawing.Point(12, 57);
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(137, 118);
            this.People.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.People.TabIndex = 28;
            this.People.TabStop = false;
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
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(472, 400);
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
            ((System.ComponentModel.ISupportInitialize)(this.Floors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.People)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.PictureBox Floors;
        private System.Windows.Forms.PictureBox People;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox PersonsField;
        private System.Windows.Forms.Label PersonsLabel;
        private System.Windows.Forms.TextBox FloorsField;
        private System.Windows.Forms.Label FloorsLabel;
        private System.Windows.Forms.Label HeaderName;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label PersonsErrorLabel;
        private System.Windows.Forms.Label FloorsErrorLabel;
    }
}