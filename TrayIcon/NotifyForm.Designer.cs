namespace TrayIcon
{
    partial class NotifyForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyForm));
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRepository = new System.Windows.Forms.Button();
            this.lblCaption = new System.Windows.Forms.Label();
            this.lblResult10 = new System.Windows.Forms.Label();
            this.lblResult9 = new System.Windows.Forms.Label();
            this.lblResult8 = new System.Windows.Forms.Label();
            this.lblResult7 = new System.Windows.Forms.Label();
            this.lblResult6 = new System.Windows.Forms.Label();
            this.lblResult5 = new System.Windows.Forms.Label();
            this.lblResult4 = new System.Windows.Forms.Label();
            this.lblResult3 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.lblConection1 = new System.Windows.Forms.Label();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.btnGo2 = new System.Windows.Forms.Button();
            this.lblConection2 = new System.Windows.Forms.Label();
            this.btnGo3 = new System.Windows.Forms.Button();
            this.lblConection3 = new System.Windows.Forms.Label();
            this.btnGo4 = new System.Windows.Forms.Button();
            this.lblConection4 = new System.Windows.Forms.Label();
            this.btnGo5 = new System.Windows.Forms.Button();
            this.lblConection5 = new System.Windows.Forms.Label();
            this.btnGo6 = new System.Windows.Forms.Button();
            this.lblConection6 = new System.Windows.Forms.Label();
            this.btnGo7 = new System.Windows.Forms.Button();
            this.lblConection7 = new System.Windows.Forms.Label();
            this.btnGo8 = new System.Windows.Forms.Button();
            this.lblConection8 = new System.Windows.Forms.Label();
            this.btnGo9 = new System.Windows.Forms.Button();
            this.lblConection9 = new System.Windows.Forms.Label();
            this.btnGo10 = new System.Windows.Forms.Button();
            this.lblConection10 = new System.Windows.Forms.Label();
            this.btnGo1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.panelCenterContainer = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panelFooter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panelCenterContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerClose
            // 
            this.timerClose.Interval = 1000;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // panelFooter
            // 
            this.panelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFooter.Controls.Add(this.lblVersion);
            this.panelFooter.Controls.Add(this.lblStatus);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 481);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(415, 30);
            this.panelFooter.TabIndex = 0;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(289, 7);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(69, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version: x.x.x";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(11, 7);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Updated";
            // 
            // panelHeader
            // 
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.btnHome);
            this.panelHeader.Controls.Add(this.btnRepository);
            this.panelHeader.Controls.Add(this.lblCaption);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(415, 34);
            this.panelHeader.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(362, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(25, 25);
            this.btnHome.TabIndex = 3;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRepository
            // 
            this.btnRepository.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepository.FlatAppearance.BorderSize = 0;
            this.btnRepository.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepository.Image = ((System.Drawing.Image)(resources.GetObject("btnRepository.Image")));
            this.btnRepository.Location = new System.Drawing.Point(331, 3);
            this.btnRepository.Name = "btnRepository";
            this.btnRepository.Size = new System.Drawing.Size(25, 25);
            this.btnRepository.TabIndex = 2;
            this.btnRepository.UseVisualStyleBackColor = true;
            this.btnRepository.Click += new System.EventHandler(this.btnRepository_Click);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(3, 9);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(80, 16);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "QueryTalk";
            // 
            // lblResult10
            // 
            this.lblResult10.AutoSize = true;
            this.lblResult10.Location = new System.Drawing.Point(329, 11);
            this.lblResult10.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.lblResult10.Name = "lblResult10";
            this.lblResult10.Size = new System.Drawing.Size(38, 13);
            this.lblResult10.TabIndex = 29;
            this.lblResult10.Tag = "10";
            this.lblResult10.Text = "Ready";
            this.lblResult10.Visible = false;
            // 
            // lblResult9
            // 
            this.lblResult9.AutoSize = true;
            this.lblResult9.Location = new System.Drawing.Point(329, 12);
            this.lblResult9.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.lblResult9.Name = "lblResult9";
            this.lblResult9.Size = new System.Drawing.Size(38, 13);
            this.lblResult9.TabIndex = 26;
            this.lblResult9.Tag = "9";
            this.lblResult9.Text = "Ready";
            this.lblResult9.Visible = false;
            // 
            // lblResult8
            // 
            this.lblResult8.AutoSize = true;
            this.lblResult8.Location = new System.Drawing.Point(329, 11);
            this.lblResult8.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.lblResult8.Name = "lblResult8";
            this.lblResult8.Size = new System.Drawing.Size(38, 13);
            this.lblResult8.TabIndex = 23;
            this.lblResult8.Tag = "8";
            this.lblResult8.Text = "Ready";
            this.lblResult8.Visible = false;
            // 
            // lblResult7
            // 
            this.lblResult7.AutoSize = true;
            this.lblResult7.Location = new System.Drawing.Point(329, 10);
            this.lblResult7.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.lblResult7.Name = "lblResult7";
            this.lblResult7.Size = new System.Drawing.Size(38, 13);
            this.lblResult7.TabIndex = 20;
            this.lblResult7.Tag = "7";
            this.lblResult7.Text = "Ready";
            this.lblResult7.Visible = false;
            // 
            // lblResult6
            // 
            this.lblResult6.AutoSize = true;
            this.lblResult6.Location = new System.Drawing.Point(329, 10);
            this.lblResult6.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.lblResult6.Name = "lblResult6";
            this.lblResult6.Size = new System.Drawing.Size(38, 13);
            this.lblResult6.TabIndex = 17;
            this.lblResult6.Tag = "6";
            this.lblResult6.Text = "Ready";
            this.lblResult6.Visible = false;
            // 
            // lblResult5
            // 
            this.lblResult5.AutoSize = true;
            this.lblResult5.Location = new System.Drawing.Point(329, 11);
            this.lblResult5.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.lblResult5.Name = "lblResult5";
            this.lblResult5.Size = new System.Drawing.Size(38, 13);
            this.lblResult5.TabIndex = 14;
            this.lblResult5.Tag = "5";
            this.lblResult5.Text = "Ready";
            this.lblResult5.Visible = false;
            // 
            // lblResult4
            // 
            this.lblResult4.AutoSize = true;
            this.lblResult4.Location = new System.Drawing.Point(329, 11);
            this.lblResult4.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.lblResult4.Name = "lblResult4";
            this.lblResult4.Size = new System.Drawing.Size(38, 13);
            this.lblResult4.TabIndex = 11;
            this.lblResult4.Tag = "4";
            this.lblResult4.Text = "Ready";
            this.lblResult4.Visible = false;
            // 
            // lblResult3
            // 
            this.lblResult3.AutoSize = true;
            this.lblResult3.Location = new System.Drawing.Point(329, 11);
            this.lblResult3.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.lblResult3.Name = "lblResult3";
            this.lblResult3.Size = new System.Drawing.Size(38, 13);
            this.lblResult3.TabIndex = 8;
            this.lblResult3.Tag = "3";
            this.lblResult3.Text = "Ready";
            this.lblResult3.Visible = false;
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Location = new System.Drawing.Point(329, 11);
            this.lblResult2.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(38, 13);
            this.lblResult2.TabIndex = 5;
            this.lblResult2.Tag = "2";
            this.lblResult2.Text = "Ready";
            this.lblResult2.Visible = false;
            // 
            // lblConection1
            // 
            this.lblConection1.AutoSize = true;
            this.lblConection1.Location = new System.Drawing.Point(4, 10);
            this.lblConection1.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.lblConection1.Name = "lblConection1";
            this.lblConection1.Size = new System.Drawing.Size(61, 13);
            this.lblConection1.TabIndex = 0;
            this.lblConection1.Tag = "1";
            this.lblConection1.Text = "Conection1";
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Location = new System.Drawing.Point(329, 10);
            this.lblResult1.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(38, 13);
            this.lblResult1.TabIndex = 2;
            this.lblResult1.Tag = "1";
            this.lblResult1.Text = "Ready";
            this.lblResult1.Visible = false;
            // 
            // btnGo2
            // 
            this.btnGo2.Location = new System.Drawing.Point(186, 6);
            this.btnGo2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnGo2.Name = "btnGo2";
            this.btnGo2.Size = new System.Drawing.Size(80, 23);
            this.btnGo2.TabIndex = 4;
            this.btnGo2.Tag = "2";
            this.btnGo2.Text = "Go";
            this.btnGo2.UseVisualStyleBackColor = true;
            this.btnGo2.Visible = false;
            this.btnGo2.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblConection2
            // 
            this.lblConection2.AutoSize = true;
            this.lblConection2.Location = new System.Drawing.Point(4, 11);
            this.lblConection2.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.lblConection2.Name = "lblConection2";
            this.lblConection2.Size = new System.Drawing.Size(61, 13);
            this.lblConection2.TabIndex = 3;
            this.lblConection2.Tag = "2";
            this.lblConection2.Text = "Conection2";
            // 
            // btnGo3
            // 
            this.btnGo3.Location = new System.Drawing.Point(186, 6);
            this.btnGo3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnGo3.Name = "btnGo3";
            this.btnGo3.Size = new System.Drawing.Size(80, 23);
            this.btnGo3.TabIndex = 7;
            this.btnGo3.Tag = "3";
            this.btnGo3.Text = "Go";
            this.btnGo3.UseVisualStyleBackColor = true;
            this.btnGo3.Visible = false;
            this.btnGo3.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblConection3
            // 
            this.lblConection3.AutoSize = true;
            this.lblConection3.Location = new System.Drawing.Point(4, 11);
            this.lblConection3.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.lblConection3.Name = "lblConection3";
            this.lblConection3.Size = new System.Drawing.Size(61, 13);
            this.lblConection3.TabIndex = 6;
            this.lblConection3.Tag = "3";
            this.lblConection3.Text = "Conection3";
            // 
            // btnGo4
            // 
            this.btnGo4.Location = new System.Drawing.Point(186, 6);
            this.btnGo4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnGo4.Name = "btnGo4";
            this.btnGo4.Size = new System.Drawing.Size(80, 23);
            this.btnGo4.TabIndex = 10;
            this.btnGo4.Tag = "4";
            this.btnGo4.Text = "Go";
            this.btnGo4.UseVisualStyleBackColor = true;
            this.btnGo4.Visible = false;
            this.btnGo4.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblConection4
            // 
            this.lblConection4.AutoSize = true;
            this.lblConection4.Location = new System.Drawing.Point(4, 11);
            this.lblConection4.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.lblConection4.Name = "lblConection4";
            this.lblConection4.Size = new System.Drawing.Size(61, 13);
            this.lblConection4.TabIndex = 9;
            this.lblConection4.Tag = "4";
            this.lblConection4.Text = "Conection4";
            // 
            // btnGo5
            // 
            this.btnGo5.Location = new System.Drawing.Point(186, 6);
            this.btnGo5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnGo5.Name = "btnGo5";
            this.btnGo5.Size = new System.Drawing.Size(80, 23);
            this.btnGo5.TabIndex = 13;
            this.btnGo5.Tag = "5";
            this.btnGo5.Text = "Go";
            this.btnGo5.UseVisualStyleBackColor = true;
            this.btnGo5.Visible = false;
            this.btnGo5.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblConection5
            // 
            this.lblConection5.AutoSize = true;
            this.lblConection5.Location = new System.Drawing.Point(4, 11);
            this.lblConection5.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.lblConection5.Name = "lblConection5";
            this.lblConection5.Size = new System.Drawing.Size(61, 13);
            this.lblConection5.TabIndex = 12;
            this.lblConection5.Tag = "5";
            this.lblConection5.Text = "Conection5";
            // 
            // btnGo6
            // 
            this.btnGo6.Location = new System.Drawing.Point(186, 5);
            this.btnGo6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnGo6.Name = "btnGo6";
            this.btnGo6.Size = new System.Drawing.Size(80, 23);
            this.btnGo6.TabIndex = 16;
            this.btnGo6.Tag = "6";
            this.btnGo6.Text = "Go";
            this.btnGo6.UseVisualStyleBackColor = true;
            this.btnGo6.Visible = false;
            this.btnGo6.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblConection6
            // 
            this.lblConection6.AutoSize = true;
            this.lblConection6.Location = new System.Drawing.Point(4, 10);
            this.lblConection6.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.lblConection6.Name = "lblConection6";
            this.lblConection6.Size = new System.Drawing.Size(61, 13);
            this.lblConection6.TabIndex = 15;
            this.lblConection6.Tag = "6";
            this.lblConection6.Text = "Conection6";
            // 
            // btnGo7
            // 
            this.btnGo7.Location = new System.Drawing.Point(186, 5);
            this.btnGo7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnGo7.Name = "btnGo7";
            this.btnGo7.Size = new System.Drawing.Size(80, 23);
            this.btnGo7.TabIndex = 19;
            this.btnGo7.Tag = "7";
            this.btnGo7.Text = "Go";
            this.btnGo7.UseVisualStyleBackColor = true;
            this.btnGo7.Visible = false;
            this.btnGo7.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblConection7
            // 
            this.lblConection7.AutoSize = true;
            this.lblConection7.Location = new System.Drawing.Point(4, 10);
            this.lblConection7.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.lblConection7.Name = "lblConection7";
            this.lblConection7.Size = new System.Drawing.Size(61, 13);
            this.lblConection7.TabIndex = 18;
            this.lblConection7.Tag = "7";
            this.lblConection7.Text = "Conection7";
            // 
            // btnGo8
            // 
            this.btnGo8.Location = new System.Drawing.Point(186, 6);
            this.btnGo8.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnGo8.Name = "btnGo8";
            this.btnGo8.Size = new System.Drawing.Size(80, 23);
            this.btnGo8.TabIndex = 22;
            this.btnGo8.Tag = "8";
            this.btnGo8.Text = "Go";
            this.btnGo8.UseVisualStyleBackColor = true;
            this.btnGo8.Visible = false;
            this.btnGo8.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblConection8
            // 
            this.lblConection8.AutoSize = true;
            this.lblConection8.Location = new System.Drawing.Point(4, 11);
            this.lblConection8.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.lblConection8.Name = "lblConection8";
            this.lblConection8.Size = new System.Drawing.Size(61, 13);
            this.lblConection8.TabIndex = 21;
            this.lblConection8.Tag = "8";
            this.lblConection8.Text = "Conection8";
            // 
            // btnGo9
            // 
            this.btnGo9.Location = new System.Drawing.Point(186, 7);
            this.btnGo9.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnGo9.Name = "btnGo9";
            this.btnGo9.Size = new System.Drawing.Size(80, 23);
            this.btnGo9.TabIndex = 25;
            this.btnGo9.Tag = "9";
            this.btnGo9.Text = "Go";
            this.btnGo9.UseVisualStyleBackColor = true;
            this.btnGo9.Visible = false;
            this.btnGo9.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblConection9
            // 
            this.lblConection9.AutoSize = true;
            this.lblConection9.Location = new System.Drawing.Point(4, 12);
            this.lblConection9.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.lblConection9.Name = "lblConection9";
            this.lblConection9.Size = new System.Drawing.Size(61, 13);
            this.lblConection9.TabIndex = 24;
            this.lblConection9.Tag = "9";
            this.lblConection9.Text = "Conection9";
            // 
            // btnGo10
            // 
            this.btnGo10.Location = new System.Drawing.Point(186, 6);
            this.btnGo10.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnGo10.Name = "btnGo10";
            this.btnGo10.Size = new System.Drawing.Size(80, 23);
            this.btnGo10.TabIndex = 28;
            this.btnGo10.Tag = "10";
            this.btnGo10.Text = "Go";
            this.btnGo10.UseVisualStyleBackColor = true;
            this.btnGo10.Visible = false;
            this.btnGo10.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblConection10
            // 
            this.lblConection10.AutoSize = true;
            this.lblConection10.Location = new System.Drawing.Point(4, 11);
            this.lblConection10.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.lblConection10.Name = "lblConection10";
            this.lblConection10.Size = new System.Drawing.Size(67, 13);
            this.lblConection10.TabIndex = 27;
            this.lblConection10.Tag = "10";
            this.lblConection10.Text = "Conection10";
            // 
            // btnGo1
            // 
            this.btnGo1.Location = new System.Drawing.Point(186, 5);
            this.btnGo1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnGo1.Name = "btnGo1";
            this.btnGo1.Size = new System.Drawing.Size(80, 23);
            this.btnGo1.TabIndex = 1;
            this.btnGo1.Tag = "1";
            this.btnGo1.Text = "Go";
            this.btnGo1.UseVisualStyleBackColor = true;
            this.btnGo1.Visible = false;
            this.btnGo1.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblConection1);
            this.panel1.Controls.Add(this.btnGo1);
            this.panel1.Controls.Add(this.lblResult1);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 34);
            this.panel1.TabIndex = 30;
            this.panel1.Tag = "1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblConection2);
            this.panel2.Controls.Add(this.btnGo2);
            this.panel2.Controls.Add(this.lblResult2);
            this.panel2.Location = new System.Drawing.Point(7, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 34);
            this.panel2.TabIndex = 31;
            this.panel2.Tag = "2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblConection3);
            this.panel3.Controls.Add(this.btnGo3);
            this.panel3.Controls.Add(this.lblResult3);
            this.panel3.Location = new System.Drawing.Point(7, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 34);
            this.panel3.TabIndex = 32;
            this.panel3.Tag = "3";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblConection4);
            this.panel4.Controls.Add(this.btnGo4);
            this.panel4.Controls.Add(this.lblResult4);
            this.panel4.Location = new System.Drawing.Point(7, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 34);
            this.panel4.TabIndex = 33;
            this.panel4.Tag = "4";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblConection5);
            this.panel5.Controls.Add(this.btnGo5);
            this.panel5.Controls.Add(this.lblResult5);
            this.panel5.Location = new System.Drawing.Point(7, 166);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 34);
            this.panel5.TabIndex = 34;
            this.panel5.Tag = "5";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblConection6);
            this.panel6.Controls.Add(this.btnGo6);
            this.panel6.Controls.Add(this.lblResult6);
            this.panel6.Location = new System.Drawing.Point(7, 206);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 34);
            this.panel6.TabIndex = 35;
            this.panel6.Tag = "6";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblConection7);
            this.panel7.Controls.Add(this.btnGo7);
            this.panel7.Controls.Add(this.lblResult7);
            this.panel7.Location = new System.Drawing.Point(7, 246);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(400, 34);
            this.panel7.TabIndex = 36;
            this.panel7.Tag = "7";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblConection8);
            this.panel8.Controls.Add(this.btnGo8);
            this.panel8.Controls.Add(this.lblResult8);
            this.panel8.Location = new System.Drawing.Point(7, 286);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(400, 34);
            this.panel8.TabIndex = 37;
            this.panel8.Tag = "8";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lblConection9);
            this.panel9.Controls.Add(this.btnGo9);
            this.panel9.Controls.Add(this.lblResult9);
            this.panel9.Location = new System.Drawing.Point(7, 326);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(400, 34);
            this.panel9.TabIndex = 38;
            this.panel9.Tag = "9";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.lblConection10);
            this.panel10.Controls.Add(this.btnGo10);
            this.panel10.Controls.Add(this.lblResult10);
            this.panel10.Location = new System.Drawing.Point(7, 366);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(400, 34);
            this.panel10.TabIndex = 39;
            this.panel10.Tag = "10";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnExit);
            this.panel11.Controls.Add(this.btnOpen);
            this.panel11.Location = new System.Drawing.Point(7, 406);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(400, 34);
            this.panel11.TabIndex = 40;
            this.panel11.Tag = "11";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(306, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Tag = "11";
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(186, 6);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Tag = "11";
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // panelCenterContainer
            // 
            this.panelCenterContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelCenterContainer.Controls.Add(this.panel1);
            this.panelCenterContainer.Controls.Add(this.panel11);
            this.panelCenterContainer.Controls.Add(this.panel2);
            this.panelCenterContainer.Controls.Add(this.panel10);
            this.panelCenterContainer.Controls.Add(this.panel3);
            this.panelCenterContainer.Controls.Add(this.panel9);
            this.panelCenterContainer.Controls.Add(this.panel4);
            this.panelCenterContainer.Controls.Add(this.panel8);
            this.panelCenterContainer.Controls.Add(this.panel5);
            this.panelCenterContainer.Controls.Add(this.panel7);
            this.panelCenterContainer.Controls.Add(this.panel6);
            this.panelCenterContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenterContainer.Location = new System.Drawing.Point(0, 34);
            this.panelCenterContainer.Name = "panelCenterContainer";
            this.panelCenterContainer.Size = new System.Drawing.Size(415, 447);
            this.panelCenterContainer.TabIndex = 41;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NotifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 511);
            this.ControlBox = false;
            this.Controls.Add(this.panelCenterContainer);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotifyForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotifyForm";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.NotifyForm_Activated);
            this.Deactivate += new System.EventHandler(this.NotifyForm_Deactivate);
            this.Shown += new System.EventHandler(this.NotifyForm_Shown);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panelCenterContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerClose;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnRepository;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnGo1;
        private System.Windows.Forms.Label lblConection1;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Label lblResult10;
        private System.Windows.Forms.Label lblResult9;
        private System.Windows.Forms.Label lblResult8;
        private System.Windows.Forms.Label lblResult7;
        private System.Windows.Forms.Label lblResult6;
        private System.Windows.Forms.Label lblResult5;
        private System.Windows.Forms.Label lblResult4;
        private System.Windows.Forms.Label lblResult3;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Button btnGo2;
        private System.Windows.Forms.Label lblConection2;
        private System.Windows.Forms.Button btnGo3;
        private System.Windows.Forms.Label lblConection3;
        private System.Windows.Forms.Button btnGo4;
        private System.Windows.Forms.Label lblConection4;
        private System.Windows.Forms.Button btnGo5;
        private System.Windows.Forms.Label lblConection5;
        private System.Windows.Forms.Button btnGo6;
        private System.Windows.Forms.Label lblConection6;
        private System.Windows.Forms.Button btnGo7;
        private System.Windows.Forms.Label lblConection7;
        private System.Windows.Forms.Button btnGo8;
        private System.Windows.Forms.Label lblConection8;
        private System.Windows.Forms.Button btnGo9;
        private System.Windows.Forms.Label lblConection9;
        private System.Windows.Forms.Button btnGo10;
        private System.Windows.Forms.Label lblConection10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panelCenterContainer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}