using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ElevatorProject.Properties;

namespace ElevatorProject.View
{
    partial class SimulationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new Container();
            this.FinishButton = new Button();
            this.CreateButton = new Button();
            this.StatusBar = new Panel();
            this.StopStatusPic = new PictureBox();
            this.OverloadStatusPic = new PictureBox();
            this.DownStatusPic = new PictureBox();
            this.CheckStatusPic = new PictureBox();
            this.ElevatorBox = new TextBox();
            this.UpStatusPic = new PictureBox();
            this.CloseStatusPic = new PictureBox();
            this.TransportedBox = new TextBox();
            this.TimeBox = new TextBox();
            this.ElevatorLabel = new Label();
            this.TransportedLabel = new Label();
            this.OpenStatusPic = new PictureBox();
            this.WaitStatusPic = new PictureBox();
            this.CallStatusPic = new PictureBox();
            this.TimeLabel = new Label();
            this.StatusBarLabel = new Label();
            this.ElevatorRoad = new Panel();
            this.CurrentFloorBox = new TextBox();
            this.ElevatorPic = new PictureBox();
            this.Header = new Panel();
            this.CloseButton = new Label();
            this.HeaderName = new Label();
            this.Logo = new PictureBox();
            this.panel1 = new Panel();
            this.LifetimeBox = new TextBox();
            this.CurrentFloorPersonBox = new TextBox();
            this.LifetimeLabel = new Label();
            this.StatusBox = new TextBox();
            this.NameBox = new TextBox();
            this.CurrentFloorLabel = new Label();
            this.StatusLabel = new Label();
            this.NameLabel = new Label();
            this.PersonStatusLabel = new Label();
            this.timer = new Timer(this.components);
            this.ErrorLabel = new Label();
            this.rightButton = new PictureBox();
            this.LeftButton = new PictureBox();
            this.StatusBar.SuspendLayout();
            ((ISupportInitialize)(this.StopStatusPic)).BeginInit();
            ((ISupportInitialize)(this.OverloadStatusPic)).BeginInit();
            ((ISupportInitialize)(this.DownStatusPic)).BeginInit();
            ((ISupportInitialize)(this.CheckStatusPic)).BeginInit();
            ((ISupportInitialize)(this.UpStatusPic)).BeginInit();
            ((ISupportInitialize)(this.CloseStatusPic)).BeginInit();
            ((ISupportInitialize)(this.OpenStatusPic)).BeginInit();
            ((ISupportInitialize)(this.WaitStatusPic)).BeginInit();
            ((ISupportInitialize)(this.CallStatusPic)).BeginInit();
            this.ElevatorRoad.SuspendLayout();
            ((ISupportInitialize)(this.ElevatorPic)).BeginInit();
            this.Header.SuspendLayout();
            ((ISupportInitialize)(this.Logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((ISupportInitialize)(this.rightButton)).BeginInit();
            ((ISupportInitialize)(this.LeftButton)).BeginInit();
            this.SuspendLayout();
            // 
            // FinishButton
            // 
            this.FinishButton.BackColor = Color.Red;
            this.FinishButton.Cursor = Cursors.Hand;
            this.FinishButton.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(98)))), ((int)(((byte)(232)))));
            this.FinishButton.FlatAppearance.MouseDownBackColor = Color.Green;
            this.FinishButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.FinishButton.FlatStyle = FlatStyle.Flat;
            this.FinishButton.Font = new Font("Ink Free", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.Location = new Point(611, 524);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new Size(142, 63);
            this.FinishButton.TabIndex = 1;
            this.FinishButton.Text = "Finish simulation";
            this.FinishButton.UseVisualStyleBackColor = false;
            this.FinishButton.Click += new EventHandler(this.FinishButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = Color.Yellow;
            this.CreateButton.Cursor = Cursors.Hand;
            this.CreateButton.DialogResult = DialogResult.No;
            this.CreateButton.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(98)))), ((int)(((byte)(232)))));
            this.CreateButton.FlatAppearance.MouseDownBackColor = Color.Green;
            this.CreateButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(159)))));
            this.CreateButton.FlatStyle = FlatStyle.Flat;
            this.CreateButton.Font = new Font("Ink Free", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new Point(123, 524);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new Size(145, 63);
            this.CreateButton.TabIndex = 3;
            this.CreateButton.Text = "Create new person";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new EventHandler(this.CreateButton_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.BackColor = Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.StatusBar.BorderStyle = BorderStyle.Fixed3D;
            this.StatusBar.Controls.Add(this.StopStatusPic);
            this.StatusBar.Controls.Add(this.OverloadStatusPic);
            this.StatusBar.Controls.Add(this.DownStatusPic);
            this.StatusBar.Controls.Add(this.CheckStatusPic);
            this.StatusBar.Controls.Add(this.ElevatorBox);
            this.StatusBar.Controls.Add(this.UpStatusPic);
            this.StatusBar.Controls.Add(this.CloseStatusPic);
            this.StatusBar.Controls.Add(this.TransportedBox);
            this.StatusBar.Controls.Add(this.TimeBox);
            this.StatusBar.Controls.Add(this.ElevatorLabel);
            this.StatusBar.Controls.Add(this.TransportedLabel);
            this.StatusBar.Controls.Add(this.OpenStatusPic);
            this.StatusBar.Controls.Add(this.WaitStatusPic);
            this.StatusBar.Controls.Add(this.CallStatusPic);
            this.StatusBar.Controls.Add(this.TimeLabel);
            this.StatusBar.Controls.Add(this.StatusBarLabel);
            this.StatusBar.Location = new Point(86, 50);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new Size(511, 179);
            this.StatusBar.TabIndex = 11;
            // 
            // StopStatusPic
            // 
            this.StopStatusPic.Image = Resources.stop;
            this.StopStatusPic.Location = new Point(464, 131);
            this.StopStatusPic.Name = "StopStatusPic";
            this.StopStatusPic.Size = new Size(34, 34);
            this.StopStatusPic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.StopStatusPic.TabIndex = 51;
            this.StopStatusPic.TabStop = false;
            this.StopStatusPic.Visible = false;
            // 
            // OverloadStatusPic
            // 
            this.OverloadStatusPic.Image = Resources.signal;
            this.OverloadStatusPic.Location = new Point(464, 131);
            this.OverloadStatusPic.Name = "OverloadStatusPic";
            this.OverloadStatusPic.Size = new Size(34, 34);
            this.OverloadStatusPic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.OverloadStatusPic.TabIndex = 54;
            this.OverloadStatusPic.TabStop = false;
            this.OverloadStatusPic.Visible = false;
            // 
            // DownStatusPic
            // 
            this.DownStatusPic.Image = Resources.down;
            this.DownStatusPic.Location = new Point(464, 131);
            this.DownStatusPic.Name = "DownStatusPic";
            this.DownStatusPic.Size = new Size(34, 34);
            this.DownStatusPic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.DownStatusPic.TabIndex = 52;
            this.DownStatusPic.TabStop = false;
            this.DownStatusPic.Visible = false;
            // 
            // CheckStatusPic
            // 
            this.CheckStatusPic.Image = Resources.check;
            this.CheckStatusPic.Location = new Point(464, 131);
            this.CheckStatusPic.Name = "CheckStatusPic";
            this.CheckStatusPic.Size = new Size(34, 34);
            this.CheckStatusPic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.CheckStatusPic.TabIndex = 52;
            this.CheckStatusPic.TabStop = false;
            this.CheckStatusPic.Visible = false;
            // 
            // ElevatorBox
            // 
            this.ElevatorBox.BackColor = Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.ElevatorBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.ElevatorBox.Location = new Point(270, 131);
            this.ElevatorBox.Multiline = true;
            this.ElevatorBox.Name = "ElevatorBox";
            this.ElevatorBox.ReadOnly = true;
            this.ElevatorBox.Size = new Size(188, 34);
            this.ElevatorBox.TabIndex = 49;
            this.ElevatorBox.TextAlign = HorizontalAlignment.Center;
            // 
            // UpStatusPic
            // 
            this.UpStatusPic.Image = Resources.up;
            this.UpStatusPic.Location = new Point(464, 131);
            this.UpStatusPic.Name = "UpStatusPic";
            this.UpStatusPic.Size = new Size(34, 34);
            this.UpStatusPic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.UpStatusPic.TabIndex = 53;
            this.UpStatusPic.TabStop = false;
            this.UpStatusPic.Visible = false;
            // 
            // CloseStatusPic
            // 
            this.CloseStatusPic.Image = Resources.close;
            this.CloseStatusPic.Location = new Point(464, 131);
            this.CloseStatusPic.Name = "CloseStatusPic";
            this.CloseStatusPic.Size = new Size(34, 34);
            this.CloseStatusPic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.CloseStatusPic.TabIndex = 55;
            this.CloseStatusPic.TabStop = false;
            this.CloseStatusPic.Visible = false;
            // 
            // TransportedBox
            // 
            this.TransportedBox.BackColor = Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.TransportedBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.TransportedBox.Location = new Point(270, 87);
            this.TransportedBox.Multiline = true;
            this.TransportedBox.Name = "TransportedBox";
            this.TransportedBox.ReadOnly = true;
            this.TransportedBox.Size = new Size(188, 34);
            this.TransportedBox.TabIndex = 47;
            this.TransportedBox.TextAlign = HorizontalAlignment.Center;
            // 
            // TimeBox
            // 
            this.TimeBox.BackColor = Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.TimeBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.TimeBox.Location = new Point(270, 43);
            this.TimeBox.Multiline = true;
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.ReadOnly = true;
            this.TimeBox.Size = new Size(188, 34);
            this.TimeBox.TabIndex = 45;
            this.TimeBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ElevatorLabel
            // 
            this.ElevatorLabel.AutoSize = true;
            this.ElevatorLabel.Font = new Font("Ink Free", 16.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.ElevatorLabel.Location = new Point(3, 131);
            this.ElevatorLabel.Name = "ElevatorLabel";
            this.ElevatorLabel.Size = new Size(127, 34);
            this.ElevatorLabel.TabIndex = 42;
            this.ElevatorLabel.Text = "Elevator";
            // 
            // TransportedLabel
            // 
            this.TransportedLabel.AutoSize = true;
            this.TransportedLabel.Font = new Font("Ink Free", 16.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.TransportedLabel.Location = new Point(3, 87);
            this.TransportedLabel.Name = "TransportedLabel";
            this.TransportedLabel.Size = new Size(177, 34);
            this.TransportedLabel.TabIndex = 41;
            this.TransportedLabel.Text = "Transported";
            // 
            // OpenStatusPic
            // 
            this.OpenStatusPic.Image = Resources.open;
            this.OpenStatusPic.Location = new Point(464, 131);
            this.OpenStatusPic.Name = "OpenStatusPic";
            this.OpenStatusPic.Size = new Size(34, 34);
            this.OpenStatusPic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.OpenStatusPic.TabIndex = 56;
            this.OpenStatusPic.TabStop = false;
            this.OpenStatusPic.Visible = false;
            // 
            // WaitStatusPic
            // 
            this.WaitStatusPic.Image = Resources.wait;
            this.WaitStatusPic.Location = new Point(464, 131);
            this.WaitStatusPic.Name = "WaitStatusPic";
            this.WaitStatusPic.Size = new Size(34, 34);
            this.WaitStatusPic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.WaitStatusPic.TabIndex = 50;
            this.WaitStatusPic.TabStop = false;
            // 
            // CallStatusPic
            // 
            this.CallStatusPic.Image = Resources.call;
            this.CallStatusPic.Location = new Point(464, 131);
            this.CallStatusPic.Name = "CallStatusPic";
            this.CallStatusPic.Size = new Size(34, 34);
            this.CallStatusPic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.CallStatusPic.TabIndex = 53;
            this.CallStatusPic.TabStop = false;
            this.CallStatusPic.Visible = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new Font("Ink Free", 16.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new Point(3, 43);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new Size(79, 34);
            this.TimeLabel.TabIndex = 39;
            this.TimeLabel.Text = "Time";
            // 
            // StatusBarLabel
            // 
            this.StatusBarLabel.AutoSize = true;
            this.StatusBarLabel.Font = new Font("Ink Free", 16.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.StatusBarLabel.Location = new Point(91, 0);
            this.StatusBarLabel.Name = "StatusBarLabel";
            this.StatusBarLabel.Size = new Size(191, 34);
            this.StatusBarLabel.TabIndex = 1;
            this.StatusBarLabel.Text = "STATUS BAR";
            // 
            // ElevatorRoad
            // 
            this.ElevatorRoad.BackColor = Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(71)))), ((int)(((byte)(247)))));
            this.ElevatorRoad.Controls.Add(this.CurrentFloorBox);
            this.ElevatorRoad.Controls.Add(this.ElevatorPic);
            this.ElevatorRoad.Dock = DockStyle.Left;
            this.ElevatorRoad.Location = new Point(0, 0);
            this.ElevatorRoad.Name = "ElevatorRoad";
            this.ElevatorRoad.Size = new Size(80, 599);
            this.ElevatorRoad.TabIndex = 13;
            // 
            // CurrentFloorBox
            // 
            this.CurrentFloorBox.BackColor = Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(71)))), ((int)(((byte)(247)))));
            this.CurrentFloorBox.Cursor = Cursors.Default;
            this.CurrentFloorBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.CurrentFloorBox.ForeColor = Color.Red;
            this.CurrentFloorBox.Location = new Point(16, 537);
            this.CurrentFloorBox.Multiline = true;
            this.CurrentFloorBox.Name = "CurrentFloorBox";
            this.CurrentFloorBox.ReadOnly = true;
            this.CurrentFloorBox.Size = new Size(48, 26);
            this.CurrentFloorBox.TabIndex = 15;
            this.CurrentFloorBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ElevatorPic
            // 
            this.ElevatorPic.BackColor = Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.ElevatorPic.Image = Resources.elevator;
            this.ElevatorPic.Location = new Point(28, 569);
            this.ElevatorPic.Name = "ElevatorPic";
            this.ElevatorPic.Size = new Size(24, 30);
            this.ElevatorPic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.ElevatorPic.TabIndex = 14;
            this.ElevatorPic.TabStop = false;
            // 
            // Header
            // 
            this.Header.BackColor = Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.Header.Controls.Add(this.CloseButton);
            this.Header.Controls.Add(this.HeaderName);
            this.Header.Controls.Add(this.Logo);
            this.Header.Dock = DockStyle.Top;
            this.Header.Location = new Point(80, 0);
            this.Header.Name = "Header";
            this.Header.Size = new Size(685, 44);
            this.Header.TabIndex = 15;
            this.Header.MouseDown += new MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new MouseEventHandler(this.Header_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
                                                        | AnchorStyles.Left) 
                                                       | AnchorStyles.Right)));
            this.CloseButton.Cursor = Cursors.Hand;
            this.CloseButton.FlatStyle = FlatStyle.Flat;
            this.CloseButton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new Point(643, 0);
            this.CloseButton.Margin = new Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new Size(42, 42);
            this.CloseButton.TabIndex = 34;
            this.CloseButton.Text = "x";
            this.CloseButton.TextAlign = ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new EventHandler(this.CloseButton_MouseLeave);
            // 
            // HeaderName
            // 
            this.HeaderName.AutoSize = true;
            this.HeaderName.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.HeaderName.Location = new Point(45, 5);
            this.HeaderName.Name = "HeaderName";
            this.HeaderName.Size = new Size(103, 33);
            this.HeaderName.TabIndex = 33;
            this.HeaderName.Text = "Elevator";
            this.HeaderName.TextAlign = ContentAlignment.MiddleCenter;
            this.HeaderName.MouseDown += new MouseEventHandler(this.HeaderName_MouseDown);
            this.HeaderName.MouseMove += new MouseEventHandler(this.HeaderName_MouseMove);
            // 
            // Logo
            // 
            this.Logo.Image = Resources.logo;
            this.Logo.Location = new Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new Size(42, 42);
            this.Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 32;
            this.Logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.panel1.BorderStyle = BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LifetimeBox);
            this.panel1.Controls.Add(this.CurrentFloorPersonBox);
            this.panel1.Controls.Add(this.LifetimeLabel);
            this.panel1.Controls.Add(this.StatusBox);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.CurrentFloorLabel);
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.PersonStatusLabel);
            this.panel1.Location = new Point(276, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(477, 217);
            this.panel1.TabIndex = 16;
            // 
            // LifetimeBox
            // 
            this.LifetimeBox.BackColor = Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.LifetimeBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.LifetimeBox.Location = new Point(251, 172);
            this.LifetimeBox.Multiline = true;
            this.LifetimeBox.Name = "LifetimeBox";
            this.LifetimeBox.ReadOnly = true;
            this.LifetimeBox.Size = new Size(207, 34);
            this.LifetimeBox.TabIndex = 51;
            this.LifetimeBox.TextAlign = HorizontalAlignment.Center;
            // 
            // CurrentFloorPersonBox
            // 
            this.CurrentFloorPersonBox.BackColor = Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.CurrentFloorPersonBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.CurrentFloorPersonBox.Location = new Point(251, 131);
            this.CurrentFloorPersonBox.Multiline = true;
            this.CurrentFloorPersonBox.Name = "CurrentFloorPersonBox";
            this.CurrentFloorPersonBox.ReadOnly = true;
            this.CurrentFloorPersonBox.Size = new Size(207, 34);
            this.CurrentFloorPersonBox.TabIndex = 49;
            this.CurrentFloorPersonBox.TextAlign = HorizontalAlignment.Center;
            // 
            // LifetimeLabel
            // 
            this.LifetimeLabel.AutoSize = true;
            this.LifetimeLabel.Font = new Font("Ink Free", 16.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.LifetimeLabel.Location = new Point(3, 172);
            this.LifetimeLabel.Name = "LifetimeLabel";
            this.LifetimeLabel.Size = new Size(124, 34);
            this.LifetimeLabel.TabIndex = 50;
            this.LifetimeLabel.Text = "Lifetime";
            // 
            // StatusBox
            // 
            this.StatusBox.BackColor = Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.StatusBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.StatusBox.Location = new Point(251, 87);
            this.StatusBox.Multiline = true;
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.ReadOnly = true;
            this.StatusBox.Size = new Size(207, 34);
            this.StatusBox.TabIndex = 47;
            this.StatusBox.TextAlign = HorizontalAlignment.Center;
            // 
            // NameBox
            // 
            this.NameBox.BackColor = Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.NameBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new Point(251, 43);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new Size(207, 34);
            this.NameBox.TabIndex = 45;
            this.NameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // CurrentFloorLabel
            // 
            this.CurrentFloorLabel.AutoSize = true;
            this.CurrentFloorLabel.Font = new Font("Ink Free", 16.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.CurrentFloorLabel.Location = new Point(3, 131);
            this.CurrentFloorLabel.Name = "CurrentFloorLabel";
            this.CurrentFloorLabel.Size = new Size(183, 34);
            this.CurrentFloorLabel.TabIndex = 42;
            this.CurrentFloorLabel.Text = "Current floor";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new Font("Ink Free", 16.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new Point(3, 87);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new Size(105, 34);
            this.StatusLabel.TabIndex = 41;
            this.StatusLabel.Text = "Status";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new Font("Ink Free", 16.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new Point(3, 43);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new Size(87, 34);
            this.NameLabel.TabIndex = 39;
            this.NameLabel.Text = "Name";
            // 
            // PersonStatusLabel
            // 
            this.PersonStatusLabel.AutoSize = true;
            this.PersonStatusLabel.Font = new Font("Ink Free", 16.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.PersonStatusLabel.Location = new Point(91, 0);
            this.PersonStatusLabel.Name = "PersonStatusLabel";
            this.PersonStatusLabel.Size = new Size(245, 34);
            this.PersonStatusLabel.TabIndex = 1;
            this.PersonStatusLabel.Text = "PERSON STATUS";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new EventHandler(this.timer_Tick);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(179)))), ((int)(((byte)(199)))));
            this.ErrorLabel.Location = new Point(318, 510);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new Size(279, 31);
            this.ErrorLabel.TabIndex = 19;
            this.ErrorLabel.Text = "Elevator isn\'t empty!";
            // 
            // rightButton
            // 
            this.rightButton.Cursor = Cursors.Hand;
            this.rightButton.Image = Resources.right;
            this.rightButton.Location = new Point(703, 458);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new Size(50, 50);
            this.rightButton.SizeMode = PictureBoxSizeMode.StretchImage;
            this.rightButton.TabIndex = 18;
            this.rightButton.TabStop = false;
            this.rightButton.Click += new EventHandler(this.rightButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Cursor = Cursors.Hand;
            this.LeftButton.Image = Resources.left;
            this.LeftButton.Location = new Point(633, 458);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new Size(50, 50);
            this.LeftButton.SizeMode = PictureBoxSizeMode.StretchImage;
            this.LeftButton.TabIndex = 17;
            this.LeftButton.TabStop = false;
            this.LeftButton.Click += new EventHandler(this.LeftButton_Click);
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new SizeF(9F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.BackColor = Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(179)))), ((int)(((byte)(199)))));
            this.BackgroundImageLayout = ImageLayout.Center;
            this.ClientSize = new Size(765, 599);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.ElevatorRoad);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.FinishButton);
            this.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ImeMode = ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new Size(752, 475);
            this.Name = "SimulationForm";
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Elevator";
            this.Shown += new EventHandler(this.SimulationForm_Shown);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            ((ISupportInitialize)(this.StopStatusPic)).EndInit();
            ((ISupportInitialize)(this.OverloadStatusPic)).EndInit();
            ((ISupportInitialize)(this.DownStatusPic)).EndInit();
            ((ISupportInitialize)(this.CheckStatusPic)).EndInit();
            ((ISupportInitialize)(this.UpStatusPic)).EndInit();
            ((ISupportInitialize)(this.CloseStatusPic)).EndInit();
            ((ISupportInitialize)(this.OpenStatusPic)).EndInit();
            ((ISupportInitialize)(this.WaitStatusPic)).EndInit();
            ((ISupportInitialize)(this.CallStatusPic)).EndInit();
            this.ElevatorRoad.ResumeLayout(false);
            this.ElevatorRoad.PerformLayout();
            ((ISupportInitialize)(this.ElevatorPic)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((ISupportInitialize)(this.Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((ISupportInitialize)(this.rightButton)).EndInit();
            ((ISupportInitialize)(this.LeftButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button FinishButton;
        private Button CreateButton;
        private Panel StatusBar;
        private Label StatusBarLabel;
        private Panel ElevatorRoad;
        private PictureBox ElevatorPic;
        private Panel Header;
        private Label HeaderName;
        private Label CloseButton;
        private TextBox ElevatorBox;
        private TextBox TransportedBox;
        private TextBox TimeBox;
        private Label ElevatorLabel;
        private Label TransportedLabel;
        private Label TimeLabel;
        private Panel panel1;
        private TextBox CurrentFloorPersonBox;
        private TextBox StatusBox;
        private TextBox NameBox;
        private Label CurrentFloorLabel;
        private Label StatusLabel;
        private Label NameLabel;
        private Label PersonStatusLabel;
        private PictureBox LeftButton;
        private PictureBox rightButton;
        private PictureBox Logo;
        private TextBox CurrentFloorBox;
        private PictureBox WaitStatusPic;
        private Timer timer;
        private PictureBox StopStatusPic;
        private PictureBox DownStatusPic;
        private PictureBox UpStatusPic;
        private PictureBox OverloadStatusPic;
        private PictureBox CloseStatusPic;
        private PictureBox OpenStatusPic;
        private PictureBox CheckStatusPic;
        private PictureBox CallStatusPic;
        private Label ErrorLabel;
        private TextBox LifetimeBox;
        private Label LifetimeLabel;
    }
}

