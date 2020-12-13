
using System.ComponentModel;
using System.Windows.Forms;

namespace ElevatorProject.View
{
    partial class ResultForm
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
            this.ReturnButton = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.Panel();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.IdleBox = new System.Windows.Forms.TextBox();
            this.TransportedBox = new System.Windows.Forms.TextBox();
            this.PersonsBox = new System.Windows.Forms.TextBox();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.IdleLabel = new System.Windows.Forms.Label();
            this.PersonsLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.TransportedLabel = new System.Windows.Forms.Label();
            this.StatusBarLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.StatusBar.SuspendLayout();
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
            this.Header.TabIndex = 30;
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
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.Green;
            this.ReturnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.ReturnButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(98)))), ((int)(((byte)(232)))));
            this.ReturnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.ReturnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(212)))), ((int)(((byte)(74)))));
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(291, 315);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(142, 63);
            this.ReturnButton.TabIndex = 34;
            this.ReturnButton.Text = "Replay simulation";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.StatusBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusBar.Controls.Add(this.WeightBox);
            this.StatusBar.Controls.Add(this.IdleBox);
            this.StatusBar.Controls.Add(this.TransportedBox);
            this.StatusBar.Controls.Add(this.PersonsBox);
            this.StatusBar.Controls.Add(this.TimeBox);
            this.StatusBar.Controls.Add(this.IdleLabel);
            this.StatusBar.Controls.Add(this.ReturnButton);
            this.StatusBar.Controls.Add(this.PersonsLabel);
            this.StatusBar.Controls.Add(this.WeightLabel);
            this.StatusBar.Controls.Add(this.TransportedLabel);
            this.StatusBar.Controls.Add(this.StatusBarLabel);
            this.StatusBar.Controls.Add(this.TimeLabel);
            this.StatusBar.Location = new System.Drawing.Point(0, 41);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(472, 403);
            this.StatusBar.TabIndex = 35;
            // 
            // WeightBox
            // 
            this.WeightBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.WeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeightBox.Location = new System.Drawing.Point(270, 232);
            this.WeightBox.Multiline = true;
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.ReadOnly = true;
            this.WeightBox.Size = new System.Drawing.Size(188, 34);
            this.WeightBox.TabIndex = 38;
            this.WeightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IdleBox
            // 
            this.IdleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.IdleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdleBox.Location = new System.Drawing.Point(270, 188);
            this.IdleBox.Multiline = true;
            this.IdleBox.Name = "IdleBox";
            this.IdleBox.ReadOnly = true;
            this.IdleBox.Size = new System.Drawing.Size(188, 34);
            this.IdleBox.TabIndex = 37;
            this.IdleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TransportedBox
            // 
            this.TransportedBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.TransportedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportedBox.Location = new System.Drawing.Point(270, 146);
            this.TransportedBox.Multiline = true;
            this.TransportedBox.Name = "TransportedBox";
            this.TransportedBox.ReadOnly = true;
            this.TransportedBox.Size = new System.Drawing.Size(188, 34);
            this.TransportedBox.TabIndex = 36;
            this.TransportedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PersonsBox
            // 
            this.PersonsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.PersonsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonsBox.Location = new System.Drawing.Point(270, 100);
            this.PersonsBox.Multiline = true;
            this.PersonsBox.Name = "PersonsBox";
            this.PersonsBox.ReadOnly = true;
            this.PersonsBox.Size = new System.Drawing.Size(188, 34);
            this.PersonsBox.TabIndex = 35;
            this.PersonsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeBox
            // 
            this.TimeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.TimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeBox.Location = new System.Drawing.Point(270, 56);
            this.TimeBox.Multiline = true;
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.ReadOnly = true;
            this.TimeBox.Size = new System.Drawing.Size(188, 34);
            this.TimeBox.TabIndex = 6;
            this.TimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeBox.Enter += new System.EventHandler(this.TimeBox_Enter);
            // 
            // IdleLabel
            // 
            this.IdleLabel.AutoSize = true;
            this.IdleLabel.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdleLabel.Location = new System.Drawing.Point(3, 188);
            this.IdleLabel.Name = "IdleLabel";
            this.IdleLabel.Size = new System.Drawing.Size(197, 34);
            this.IdleLabel.TabIndex = 5;
            this.IdleLabel.Text = "Idle Trnsport";
            // 
            // PersonsLabel
            // 
            this.PersonsLabel.AutoSize = true;
            this.PersonsLabel.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonsLabel.Location = new System.Drawing.Point(3, 100);
            this.PersonsLabel.Name = "PersonsLabel";
            this.PersonsLabel.Size = new System.Drawing.Size(153, 34);
            this.PersonsLabel.TabIndex = 4;
            this.PersonsLabel.Text = "All Persons";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(3, 232);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(186, 34);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "Total Weight";
            // 
            // TransportedLabel
            // 
            this.TransportedLabel.AutoSize = true;
            this.TransportedLabel.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransportedLabel.Location = new System.Drawing.Point(3, 144);
            this.TransportedLabel.Name = "TransportedLabel";
            this.TransportedLabel.Size = new System.Drawing.Size(177, 34);
            this.TransportedLabel.TabIndex = 2;
            this.TransportedLabel.Text = "Transported";
            // 
            // StatusBarLabel
            // 
            this.StatusBarLabel.AutoSize = true;
            this.StatusBarLabel.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBarLabel.Location = new System.Drawing.Point(101, 10);
            this.StatusBarLabel.Name = "StatusBarLabel";
            this.StatusBarLabel.Size = new System.Drawing.Size(238, 34);
            this.StatusBarLabel.TabIndex = 1;
            this.StatusBarLabel.Text = "Result Simulation";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(3, 56);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(79, 34);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "Time";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 442);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultForm";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Header;
        private Label HeaderName;
        private PictureBox Logo;
        private Label CloseButton;
        private Button ReturnButton;
        private Panel StatusBar;
        private Label WeightLabel;
        private Label TransportedLabel;
        private Label StatusBarLabel;
        private Label TimeLabel;
        private Label PersonsLabel;
        private Label IdleLabel;
        private TextBox TransportedBox;
        private TextBox PersonsBox;
        private TextBox TimeBox;
        private TextBox WeightBox;
        private TextBox IdleBox;
    }
}