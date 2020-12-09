namespace ElevatorProject.View
{
    partial class SimulationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.FinishButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.Panel();
            this.StopStatusPic = new System.Windows.Forms.PictureBox();
            this.OverloadStatusPic = new System.Windows.Forms.PictureBox();
            this.DownStatusPic = new System.Windows.Forms.PictureBox();
            this.CheckStatusPic = new System.Windows.Forms.PictureBox();
            this.ElevatorBox = new System.Windows.Forms.TextBox();
            this.UpStatusPic = new System.Windows.Forms.PictureBox();
            this.CloseStatusPic = new System.Windows.Forms.PictureBox();
            this.TransportedBox = new System.Windows.Forms.TextBox();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.ElevatorLabel = new System.Windows.Forms.Label();
            this.TransportedLabel = new System.Windows.Forms.Label();
            this.OpenStatusPic = new System.Windows.Forms.PictureBox();
            this.WaitStatusPic = new System.Windows.Forms.PictureBox();
            this.CallStatusPic = new System.Windows.Forms.PictureBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.StatusBarLabel = new System.Windows.Forms.Label();
            this.ElevatorRoad = new System.Windows.Forms.Panel();
            this.CurrentFloorBox = new System.Windows.Forms.TextBox();
            this.ElevatorPic = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.HeaderName = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CurrentFloorPersonBox = new System.Windows.Forms.TextBox();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.CurrentFloorLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PersonStatusLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.Timer(this.components);
            this.floortime = new System.Windows.Forms.Timer(this.components);
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.rightButton = new System.Windows.Forms.PictureBox();
            this.LeftButton = new System.Windows.Forms.PictureBox();
            this.LifetimeBox = new System.Windows.Forms.TextBox();
            this.LifetimeLabel = new System.Windows.Forms.Label();
            this.StatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StopStatusPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverloadStatusPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownStatusPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckStatusPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpStatusPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseStatusPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenStatusPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitStatusPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CallStatusPic)).BeginInit();
            this.ElevatorRoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElevatorPic)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftButton)).BeginInit();
            this.SuspendLayout();
            // 
            // FinishButton
            // 
            this.FinishButton.BackColor = System.Drawing.Color.Red;
            this.FinishButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FinishButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(98)))), ((int)(((byte)(232)))));
            this.FinishButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.FinishButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.FinishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.Location = new System.Drawing.Point(611, 524);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(142, 63);
            this.FinishButton.TabIndex = 1;
            this.FinishButton.Text = "Finish simulation";
            this.FinishButton.UseVisualStyleBackColor = false;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.Yellow;
            this.CreateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.CreateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(98)))), ((int)(((byte)(232)))));
            this.CreateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.CreateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(159)))));
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(123, 524);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(145, 63);
            this.CreateButton.TabIndex = 3;
            this.CreateButton.Text = "Create new person";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.StatusBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.StatusBar.Location = new System.Drawing.Point(86, 50);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(511, 179);
            this.StatusBar.TabIndex = 11;
            // 
            // StopStatusPic
            // 
            this.StopStatusPic.Image = global::ElevatorProject.Properties.Resources.stop;
            this.StopStatusPic.Location = new System.Drawing.Point(464, 131);
            this.StopStatusPic.Name = "StopStatusPic";
            this.StopStatusPic.Size = new System.Drawing.Size(34, 34);
            this.StopStatusPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StopStatusPic.TabIndex = 51;
            this.StopStatusPic.TabStop = false;
            this.StopStatusPic.Visible = false;
            // 
            // OverloadStatusPic
            // 
            this.OverloadStatusPic.Image = global::ElevatorProject.Properties.Resources.signal;
            this.OverloadStatusPic.Location = new System.Drawing.Point(464, 131);
            this.OverloadStatusPic.Name = "OverloadStatusPic";
            this.OverloadStatusPic.Size = new System.Drawing.Size(34, 34);
            this.OverloadStatusPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OverloadStatusPic.TabIndex = 54;
            this.OverloadStatusPic.TabStop = false;
            this.OverloadStatusPic.Visible = false;
            // 
            // DownStatusPic
            // 
            this.DownStatusPic.Image = global::ElevatorProject.Properties.Resources.down;
            this.DownStatusPic.Location = new System.Drawing.Point(464, 131);
            this.DownStatusPic.Name = "DownStatusPic";
            this.DownStatusPic.Size = new System.Drawing.Size(34, 34);
            this.DownStatusPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownStatusPic.TabIndex = 52;
            this.DownStatusPic.TabStop = false;
            this.DownStatusPic.Visible = false;
            // 
            // CheckStatusPic
            // 
            this.CheckStatusPic.Image = global::ElevatorProject.Properties.Resources.check;
            this.CheckStatusPic.Location = new System.Drawing.Point(464, 131);
            this.CheckStatusPic.Name = "CheckStatusPic";
            this.CheckStatusPic.Size = new System.Drawing.Size(34, 34);
            this.CheckStatusPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CheckStatusPic.TabIndex = 52;
            this.CheckStatusPic.TabStop = false;
            this.CheckStatusPic.Visible = false;
            // 
            // ElevatorBox
            // 
            this.ElevatorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.ElevatorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElevatorBox.Location = new System.Drawing.Point(270, 131);
            this.ElevatorBox.Multiline = true;
            this.ElevatorBox.Name = "ElevatorBox";
            this.ElevatorBox.ReadOnly = true;
            this.ElevatorBox.Size = new System.Drawing.Size(188, 34);
            this.ElevatorBox.TabIndex = 49;
            this.ElevatorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpStatusPic
            // 
            this.UpStatusPic.Image = global::ElevatorProject.Properties.Resources.up;
            this.UpStatusPic.Location = new System.Drawing.Point(464, 131);
            this.UpStatusPic.Name = "UpStatusPic";
            this.UpStatusPic.Size = new System.Drawing.Size(34, 34);
            this.UpStatusPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpStatusPic.TabIndex = 53;
            this.UpStatusPic.TabStop = false;
            this.UpStatusPic.Visible = false;
            // 
            // CloseStatusPic
            // 
            this.CloseStatusPic.Image = global::ElevatorProject.Properties.Resources.close;
            this.CloseStatusPic.Location = new System.Drawing.Point(464, 131);
            this.CloseStatusPic.Name = "CloseStatusPic";
            this.CloseStatusPic.Size = new System.Drawing.Size(34, 34);
            this.CloseStatusPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseStatusPic.TabIndex = 55;
            this.CloseStatusPic.TabStop = false;
            this.CloseStatusPic.Visible = false;
            // 
            // TransportedBox
            // 
            this.TransportedBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.TransportedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportedBox.Location = new System.Drawing.Point(270, 87);
            this.TransportedBox.Multiline = true;
            this.TransportedBox.Name = "TransportedBox";
            this.TransportedBox.ReadOnly = true;
            this.TransportedBox.Size = new System.Drawing.Size(188, 34);
            this.TransportedBox.TabIndex = 47;
            this.TransportedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeBox
            // 
            this.TimeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.TimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeBox.Location = new System.Drawing.Point(270, 43);
            this.TimeBox.Multiline = true;
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.ReadOnly = true;
            this.TimeBox.Size = new System.Drawing.Size(188, 34);
            this.TimeBox.TabIndex = 45;
            this.TimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ElevatorLabel
            // 
            this.ElevatorLabel.AutoSize = true;
            this.ElevatorLabel.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElevatorLabel.Location = new System.Drawing.Point(3, 131);
            this.ElevatorLabel.Name = "ElevatorLabel";
            this.ElevatorLabel.Size = new System.Drawing.Size(127, 34);
            this.ElevatorLabel.TabIndex = 42;
            this.ElevatorLabel.Text = "Elevator";
            // 
            // TransportedLabel
            // 
            this.TransportedLabel.AutoSize = true;
            this.TransportedLabel.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransportedLabel.Location = new System.Drawing.Point(3, 87);
            this.TransportedLabel.Name = "TransportedLabel";
            this.TransportedLabel.Size = new System.Drawing.Size(177, 34);
            this.TransportedLabel.TabIndex = 41;
            this.TransportedLabel.Text = "Transported";
            // 
            // OpenStatusPic
            // 
            this.OpenStatusPic.Image = global::ElevatorProject.Properties.Resources.open;
            this.OpenStatusPic.Location = new System.Drawing.Point(464, 131);
            this.OpenStatusPic.Name = "OpenStatusPic";
            this.OpenStatusPic.Size = new System.Drawing.Size(34, 34);
            this.OpenStatusPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OpenStatusPic.TabIndex = 56;
            this.OpenStatusPic.TabStop = false;
            this.OpenStatusPic.Visible = false;
            // 
            // WaitStatusPic
            // 
            this.WaitStatusPic.Image = global::ElevatorProject.Properties.Resources.wait;
            this.WaitStatusPic.Location = new System.Drawing.Point(464, 131);
            this.WaitStatusPic.Name = "WaitStatusPic";
            this.WaitStatusPic.Size = new System.Drawing.Size(34, 34);
            this.WaitStatusPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WaitStatusPic.TabIndex = 50;
            this.WaitStatusPic.TabStop = false;
            // 
            // CallStatusPic
            // 
            this.CallStatusPic.Image = global::ElevatorProject.Properties.Resources.call;
            this.CallStatusPic.Location = new System.Drawing.Point(464, 131);
            this.CallStatusPic.Name = "CallStatusPic";
            this.CallStatusPic.Size = new System.Drawing.Size(34, 34);
            this.CallStatusPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CallStatusPic.TabIndex = 53;
            this.CallStatusPic.TabStop = false;
            this.CallStatusPic.Visible = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(3, 43);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(79, 34);
            this.TimeLabel.TabIndex = 39;
            this.TimeLabel.Text = "Time";
            // 
            // StatusBarLabel
            // 
            this.StatusBarLabel.AutoSize = true;
            this.StatusBarLabel.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBarLabel.Location = new System.Drawing.Point(91, 0);
            this.StatusBarLabel.Name = "StatusBarLabel";
            this.StatusBarLabel.Size = new System.Drawing.Size(191, 34);
            this.StatusBarLabel.TabIndex = 1;
            this.StatusBarLabel.Text = "STATUS BAR";
            // 
            // ElevatorRoad
            // 
            this.ElevatorRoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(71)))), ((int)(((byte)(247)))));
            this.ElevatorRoad.Controls.Add(this.CurrentFloorBox);
            this.ElevatorRoad.Controls.Add(this.ElevatorPic);
            this.ElevatorRoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.ElevatorRoad.Location = new System.Drawing.Point(0, 0);
            this.ElevatorRoad.Name = "ElevatorRoad";
            this.ElevatorRoad.Size = new System.Drawing.Size(80, 599);
            this.ElevatorRoad.TabIndex = 13;
            // 
            // CurrentFloorBox
            // 
            this.CurrentFloorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(71)))), ((int)(((byte)(247)))));
            this.CurrentFloorBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.CurrentFloorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentFloorBox.ForeColor = System.Drawing.Color.Red;
            this.CurrentFloorBox.Location = new System.Drawing.Point(16, 537);
            this.CurrentFloorBox.Multiline = true;
            this.CurrentFloorBox.Name = "CurrentFloorBox";
            this.CurrentFloorBox.ReadOnly = true;
            this.CurrentFloorBox.Size = new System.Drawing.Size(48, 26);
            this.CurrentFloorBox.TabIndex = 15;
            this.CurrentFloorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ElevatorPic
            // 
            this.ElevatorPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.ElevatorPic.Image = global::ElevatorProject.Properties.Resources.elevator;
            this.ElevatorPic.Location = new System.Drawing.Point(28, 569);
            this.ElevatorPic.Name = "ElevatorPic";
            this.ElevatorPic.Size = new System.Drawing.Size(24, 30);
            this.ElevatorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ElevatorPic.TabIndex = 14;
            this.ElevatorPic.TabStop = false;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.Header.Controls.Add(this.CloseButton);
            this.Header.Controls.Add(this.HeaderName);
            this.Header.Controls.Add(this.Logo);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(80, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(685, 44);
            this.Header.TabIndex = 15;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(643, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(42, 42);
            this.CloseButton.TabIndex = 34;
            this.CloseButton.Text = "x";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // HeaderName
            // 
            this.HeaderName.AutoSize = true;
            this.HeaderName.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderName.Location = new System.Drawing.Point(45, 5);
            this.HeaderName.Name = "HeaderName";
            this.HeaderName.Size = new System.Drawing.Size(103, 33);
            this.HeaderName.TabIndex = 33;
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
            this.Logo.TabIndex = 32;
            this.Logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LifetimeBox);
            this.panel1.Controls.Add(this.CurrentFloorPersonBox);
            this.panel1.Controls.Add(this.LifetimeLabel);
            this.panel1.Controls.Add(this.StatusBox);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.CurrentFloorLabel);
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.PersonStatusLabel);
            this.panel1.Location = new System.Drawing.Point(276, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 217);
            this.panel1.TabIndex = 16;
            // 
            // CurrentFloorPersonBox
            // 
            this.CurrentFloorPersonBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.CurrentFloorPersonBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentFloorPersonBox.Location = new System.Drawing.Point(270, 131);
            this.CurrentFloorPersonBox.Multiline = true;
            this.CurrentFloorPersonBox.Name = "CurrentFloorPersonBox";
            this.CurrentFloorPersonBox.ReadOnly = true;
            this.CurrentFloorPersonBox.Size = new System.Drawing.Size(188, 34);
            this.CurrentFloorPersonBox.TabIndex = 49;
            this.CurrentFloorPersonBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StatusBox
            // 
            this.StatusBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.StatusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusBox.Location = new System.Drawing.Point(270, 87);
            this.StatusBox.Multiline = true;
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.ReadOnly = true;
            this.StatusBox.Size = new System.Drawing.Size(188, 34);
            this.StatusBox.TabIndex = 47;
            this.StatusBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(270, 43);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(188, 34);
            this.NameBox.TabIndex = 45;
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentFloorLabel
            // 
            this.CurrentFloorLabel.AutoSize = true;
            this.CurrentFloorLabel.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentFloorLabel.Location = new System.Drawing.Point(3, 131);
            this.CurrentFloorLabel.Name = "CurrentFloorLabel";
            this.CurrentFloorLabel.Size = new System.Drawing.Size(183, 34);
            this.CurrentFloorLabel.TabIndex = 42;
            this.CurrentFloorLabel.Text = "Current floor";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(3, 87);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(105, 34);
            this.StatusLabel.TabIndex = 41;
            this.StatusLabel.Text = "Status";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(3, 43);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(87, 34);
            this.NameLabel.TabIndex = 39;
            this.NameLabel.Text = "Name";
            // 
            // PersonStatusLabel
            // 
            this.PersonStatusLabel.AutoSize = true;
            this.PersonStatusLabel.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonStatusLabel.Location = new System.Drawing.Point(91, 0);
            this.PersonStatusLabel.Name = "PersonStatusLabel";
            this.PersonStatusLabel.Size = new System.Drawing.Size(245, 34);
            this.PersonStatusLabel.TabIndex = 1;
            this.PersonStatusLabel.Text = "PERSON STATUS";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // start
            // 
            this.start.Enabled = true;
            this.start.Interval = 1000;
            this.start.Tick += new System.EventHandler(this.start_Tick);
            // 
            // floortime
            // 
            this.floortime.Tick += new System.EventHandler(this.floortime_Tick);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(179)))), ((int)(((byte)(199)))));
            this.ErrorLabel.Location = new System.Drawing.Point(318, 510);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(279, 31);
            this.ErrorLabel.TabIndex = 19;
            this.ErrorLabel.Text = "Elevator isn\'t empty!";
            // 
            // rightButton
            // 
            this.rightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightButton.Image = global::ElevatorProject.Properties.Resources.right;
            this.rightButton.Location = new System.Drawing.Point(703, 458);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(50, 50);
            this.rightButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightButton.TabIndex = 18;
            this.rightButton.TabStop = false;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftButton.Image = global::ElevatorProject.Properties.Resources.left;
            this.LeftButton.Location = new System.Drawing.Point(633, 458);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(50, 50);
            this.LeftButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftButton.TabIndex = 17;
            this.LeftButton.TabStop = false;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // LifetimeBox
            // 
            this.LifetimeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.LifetimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LifetimeBox.Location = new System.Drawing.Point(270, 172);
            this.LifetimeBox.Multiline = true;
            this.LifetimeBox.Name = "LifetimeBox";
            this.LifetimeBox.ReadOnly = true;
            this.LifetimeBox.Size = new System.Drawing.Size(188, 34);
            this.LifetimeBox.TabIndex = 51;
            this.LifetimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LifetimeLabel
            // 
            this.LifetimeLabel.AutoSize = true;
            this.LifetimeLabel.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LifetimeLabel.Location = new System.Drawing.Point(3, 172);
            this.LifetimeLabel.Name = "LifetimeLabel";
            this.LifetimeLabel.Size = new System.Drawing.Size(124, 34);
            this.LifetimeLabel.TabIndex = 50;
            this.LifetimeLabel.Text = "Lifetime";
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(179)))), ((int)(((byte)(199)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(765, 599);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.ElevatorRoad);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.FinishButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(752, 475);
            this.Name = "SimulationForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elevator";
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StopStatusPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverloadStatusPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownStatusPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckStatusPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpStatusPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseStatusPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenStatusPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitStatusPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CallStatusPic)).EndInit();
            this.ElevatorRoad.ResumeLayout(false);
            this.ElevatorRoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElevatorPic)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Panel StatusBar;
        private System.Windows.Forms.Label StatusBarLabel;
        private System.Windows.Forms.Panel ElevatorRoad;
        private System.Windows.Forms.PictureBox ElevatorPic;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label HeaderName;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.TextBox ElevatorBox;
        private System.Windows.Forms.TextBox TransportedBox;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Label ElevatorLabel;
        private System.Windows.Forms.Label TransportedLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CurrentFloorPersonBox;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label CurrentFloorLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PersonStatusLabel;
        private System.Windows.Forms.PictureBox LeftButton;
        private System.Windows.Forms.PictureBox rightButton;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox CurrentFloorBox;
        private System.Windows.Forms.PictureBox WaitStatusPic;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer start;
        private System.Windows.Forms.PictureBox StopStatusPic;
        private System.Windows.Forms.PictureBox DownStatusPic;
        private System.Windows.Forms.PictureBox UpStatusPic;
        private System.Windows.Forms.PictureBox OverloadStatusPic;
        private System.Windows.Forms.PictureBox CloseStatusPic;
        private System.Windows.Forms.PictureBox OpenStatusPic;
        private System.Windows.Forms.PictureBox CheckStatusPic;
        private System.Windows.Forms.PictureBox CallStatusPic;
        private System.Windows.Forms.Timer floortime;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox LifetimeBox;
        private System.Windows.Forms.Label LifetimeLabel;
    }
}

