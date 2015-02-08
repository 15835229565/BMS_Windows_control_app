namespace PCANBasicExample
{
    partial class Form_BMS_Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BMS_Config));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_connectCAN = new System.Windows.Forms.Button();
            this.lbxInfo = new System.Windows.Forms.ListBox();
            this.tmrDisplay = new System.Windows.Forms.Timer(this.components);
            this.lstMessages = new System.Windows.Forms.ListView();
            this.clhType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhRcvTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmrRead = new System.Windows.Forms.Timer(this.components);
            this.btnReleseCAN = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.boxNumberOfPacks = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ListBoxBmsIdsReset = new System.Windows.Forms.Button();
            this.ListBoxBmsIds = new System.Windows.Forms.ListBox();
            this.groupDataFromBms = new System.Windows.Forms.GroupBox();
            this.boxStatus1b4 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.boxMaxPwm1 = new System.Windows.Forms.TextBox();
            this.boxMaxPwm6 = new System.Windows.Forms.TextBox();
            this.boxMaxPwm5 = new System.Windows.Forms.TextBox();
            this.boxMaxPwm4 = new System.Windows.Forms.TextBox();
            this.boxMaxPwm3 = new System.Windows.Forms.TextBox();
            this.boxMaxPwm2 = new System.Windows.Forms.TextBox();
            this.boxMinV1 = new System.Windows.Forms.TextBox();
            this.boxMinV6 = new System.Windows.Forms.TextBox();
            this.boxMinV5 = new System.Windows.Forms.TextBox();
            this.boxMinV4 = new System.Windows.Forms.TextBox();
            this.boxMinV3 = new System.Windows.Forms.TextBox();
            this.boxMinV2 = new System.Windows.Forms.TextBox();
            this.boxMaxV1 = new System.Windows.Forms.TextBox();
            this.boxMaxV6 = new System.Windows.Forms.TextBox();
            this.boxMaxV5 = new System.Windows.Forms.TextBox();
            this.boxMaxV4 = new System.Windows.Forms.TextBox();
            this.boxMaxV3 = new System.Windows.Forms.TextBox();
            this.boxMaxV2 = new System.Windows.Forms.TextBox();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.boxStatus1b2 = new System.Windows.Forms.TextBox();
            this.boxStatus1b3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxStatus0b0 = new System.Windows.Forms.TextBox();
            this.boxStatus0b1 = new System.Windows.Forms.TextBox();
            this.boxStatus0b3 = new System.Windows.Forms.TextBox();
            this.boxStatus0b2 = new System.Windows.Forms.TextBox();
            this.boxStatus0b4 = new System.Windows.Forms.TextBox();
            this.boxStatus0b5 = new System.Windows.Forms.TextBox();
            this.boxStatus0b6 = new System.Windows.Forms.TextBox();
            this.boxStatus1b1 = new System.Windows.Forms.TextBox();
            this.boxTemp4 = new System.Windows.Forms.TextBox();
            this.boxTemp3 = new System.Windows.Forms.TextBox();
            this.boxTemp2 = new System.Windows.Forms.TextBox();
            this.boxStatus1b0 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.boxTemp1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BoxPWM6 = new System.Windows.Forms.TextBox();
            this.BoxPWM5 = new System.Windows.Forms.TextBox();
            this.BoxPWM4 = new System.Windows.Forms.TextBox();
            this.BoxPWM3 = new System.Windows.Forms.TextBox();
            this.BoxPWM2 = new System.Windows.Forms.TextBox();
            this.BoxPWM1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.appCANbaudrate = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.boxNewMasterId = new System.Windows.Forms.TextBox();
            this.boxBaudRate = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.MasterID = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupDataFromBms.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 81);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_connectCAN
            // 
            this.Btn_connectCAN.Location = new System.Drawing.Point(593, 21);
            this.Btn_connectCAN.Name = "Btn_connectCAN";
            this.Btn_connectCAN.Size = new System.Drawing.Size(119, 30);
            this.Btn_connectCAN.TabIndex = 8;
            this.Btn_connectCAN.Text = "Connect CAN";
            this.Btn_connectCAN.UseVisualStyleBackColor = true;
            this.Btn_connectCAN.Click += new System.EventHandler(this.Btn_connectCAN_Click);
            // 
            // lbxInfo
            // 
            this.lbxInfo.FormattingEnabled = true;
            this.lbxInfo.Location = new System.Drawing.Point(3, 669);
            this.lbxInfo.Name = "lbxInfo";
            this.lbxInfo.ScrollAlwaysVisible = true;
            this.lbxInfo.Size = new System.Drawing.Size(718, 69);
            this.lbxInfo.TabIndex = 57;
            // 
            // tmrDisplay
            // 
            this.tmrDisplay.Tick += new System.EventHandler(this.tmrDisplay_Tick);
            // 
            // lstMessages
            // 
            this.lstMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhType,
            this.clhID,
            this.clhLength,
            this.clhData,
            this.clhCount,
            this.clhRcvTime});
            this.lstMessages.FullRowSelect = true;
            this.lstMessages.Location = new System.Drawing.Point(3, 480);
            this.lstMessages.MultiSelect = false;
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(718, 179);
            this.lstMessages.TabIndex = 58;
            this.lstMessages.UseCompatibleStateImageBehavior = false;
            this.lstMessages.View = System.Windows.Forms.View.Details;
            // 
            // clhType
            // 
            this.clhType.Text = "Type";
            this.clhType.Width = 69;
            // 
            // clhID
            // 
            this.clhID.Text = "ID";
            this.clhID.Width = 90;
            // 
            // clhLength
            // 
            this.clhLength.Text = "Length";
            this.clhLength.Width = 50;
            // 
            // clhData
            // 
            this.clhData.Text = "Data";
            this.clhData.Width = 160;
            // 
            // clhCount
            // 
            this.clhCount.Text = "Count";
            this.clhCount.Width = 49;
            // 
            // clhRcvTime
            // 
            this.clhRcvTime.Text = "Rcv Time";
            this.clhRcvTime.Width = 97;
            // 
            // tmrRead
            // 
            this.tmrRead.Tick += new System.EventHandler(this.tmrRead_Tick);
            // 
            // btnReleseCAN
            // 
            this.btnReleseCAN.Enabled = false;
            this.btnReleseCAN.Location = new System.Drawing.Point(596, 57);
            this.btnReleseCAN.Name = "btnReleseCAN";
            this.btnReleseCAN.Size = new System.Drawing.Size(119, 33);
            this.btnReleseCAN.TabIndex = 60;
            this.btnReleseCAN.Text = "Relese CAN";
            this.btnReleseCAN.UseVisualStyleBackColor = true;
            this.btnReleseCAN.Click += new System.EventHandler(this.btnReleseCAN_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 384);
            this.tabControl1.TabIndex = 61;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.textBox9);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.boxNumberOfPacks);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(711, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(278, 200);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(87, 13);
            this.label33.TabIndex = 126;
            this.label33.Text = "Charging request";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(307, 177);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(161, 13);
            this.label32.TabIndex = 125;
            this.label32.Text = "Overall Battery pack status";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(16, 35);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(130, 13);
            this.label31.TabIndex = 124;
            this.label31.Text = "List of detected units (IDs)";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(315, 101);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(126, 13);
            this.label30.TabIndex = 123;
            this.label30.Text = "Number of detected units";
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(371, 193);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(127, 20);
            this.textBox9.TabIndex = 121;
            this.textBox9.Text = "7";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(307, 252);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 13);
            this.label21.TabIndex = 120;
            this.label21.Text = "All cells full";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(371, 219);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(127, 20);
            this.textBox8.TabIndex = 119;
            this.textBox8.Text = "7";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(272, 226);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 13);
            this.label20.TabIndex = 118;
            this.label20.Text = "Discharge request";
            // 
            // boxNumberOfPacks
            // 
            this.boxNumberOfPacks.Enabled = false;
            this.boxNumberOfPacks.Location = new System.Drawing.Point(447, 98);
            this.boxNumberOfPacks.Name = "boxNumberOfPacks";
            this.boxNumberOfPacks.Size = new System.Drawing.Size(51, 20);
            this.boxNumberOfPacks.TabIndex = 117;
            this.boxNumberOfPacks.Text = "7";
            this.boxNumberOfPacks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(307, 82);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(142, 13);
            this.label19.TabIndex = 116;
            this.label19.Text = "Detected Battery Packs";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.ListBoxBmsIdsReset);
            this.tabPage2.Controls.Add(this.ListBoxBmsIds);
            this.tabPage2.Controls.Add(this.groupDataFromBms);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(711, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ListBoxBmsIdsReset
            // 
            this.ListBoxBmsIdsReset.Location = new System.Drawing.Point(9, 327);
            this.ListBoxBmsIdsReset.Name = "ListBoxBmsIdsReset";
            this.ListBoxBmsIdsReset.Size = new System.Drawing.Size(89, 23);
            this.ListBoxBmsIdsReset.TabIndex = 68;
            this.ListBoxBmsIdsReset.Text = "Reset";
            this.ListBoxBmsIdsReset.UseVisualStyleBackColor = true;
            this.ListBoxBmsIdsReset.Click += new System.EventHandler(this.ListBoxBmsIdsReset_Click);
            // 
            // ListBoxBmsIds
            // 
            this.ListBoxBmsIds.FormattingEnabled = true;
            this.ListBoxBmsIds.Location = new System.Drawing.Point(9, 45);
            this.ListBoxBmsIds.Name = "ListBoxBmsIds";
            this.ListBoxBmsIds.Size = new System.Drawing.Size(89, 277);
            this.ListBoxBmsIds.TabIndex = 67;
            // 
            // groupDataFromBms
            // 
            this.groupDataFromBms.Controls.Add(this.boxStatus1b4);
            this.groupDataFromBms.Controls.Add(this.label28);
            this.groupDataFromBms.Controls.Add(this.label27);
            this.groupDataFromBms.Controls.Add(this.label26);
            this.groupDataFromBms.Controls.Add(this.label25);
            this.groupDataFromBms.Controls.Add(this.label24);
            this.groupDataFromBms.Controls.Add(this.boxMaxPwm1);
            this.groupDataFromBms.Controls.Add(this.boxMaxPwm6);
            this.groupDataFromBms.Controls.Add(this.boxMaxPwm5);
            this.groupDataFromBms.Controls.Add(this.boxMaxPwm4);
            this.groupDataFromBms.Controls.Add(this.boxMaxPwm3);
            this.groupDataFromBms.Controls.Add(this.boxMaxPwm2);
            this.groupDataFromBms.Controls.Add(this.boxMinV1);
            this.groupDataFromBms.Controls.Add(this.boxMinV6);
            this.groupDataFromBms.Controls.Add(this.boxMinV5);
            this.groupDataFromBms.Controls.Add(this.boxMinV4);
            this.groupDataFromBms.Controls.Add(this.boxMinV3);
            this.groupDataFromBms.Controls.Add(this.boxMinV2);
            this.groupDataFromBms.Controls.Add(this.boxMaxV1);
            this.groupDataFromBms.Controls.Add(this.boxMaxV6);
            this.groupDataFromBms.Controls.Add(this.boxMaxV5);
            this.groupDataFromBms.Controls.Add(this.boxMaxV4);
            this.groupDataFromBms.Controls.Add(this.boxMaxV3);
            this.groupDataFromBms.Controls.Add(this.boxMaxV2);
            this.groupDataFromBms.Controls.Add(this.textBox0);
            this.groupDataFromBms.Controls.Add(this.label18);
            this.groupDataFromBms.Controls.Add(this.boxStatus1b2);
            this.groupDataFromBms.Controls.Add(this.boxStatus1b3);
            this.groupDataFromBms.Controls.Add(this.label17);
            this.groupDataFromBms.Controls.Add(this.label16);
            this.groupDataFromBms.Controls.Add(this.label15);
            this.groupDataFromBms.Controls.Add(this.label1);
            this.groupDataFromBms.Controls.Add(this.boxStatus0b0);
            this.groupDataFromBms.Controls.Add(this.boxStatus0b1);
            this.groupDataFromBms.Controls.Add(this.boxStatus0b3);
            this.groupDataFromBms.Controls.Add(this.boxStatus0b2);
            this.groupDataFromBms.Controls.Add(this.boxStatus0b4);
            this.groupDataFromBms.Controls.Add(this.boxStatus0b5);
            this.groupDataFromBms.Controls.Add(this.boxStatus0b6);
            this.groupDataFromBms.Controls.Add(this.boxStatus1b1);
            this.groupDataFromBms.Controls.Add(this.boxTemp4);
            this.groupDataFromBms.Controls.Add(this.boxTemp3);
            this.groupDataFromBms.Controls.Add(this.boxTemp2);
            this.groupDataFromBms.Controls.Add(this.boxStatus1b0);
            this.groupDataFromBms.Controls.Add(this.label7);
            this.groupDataFromBms.Controls.Add(this.label8);
            this.groupDataFromBms.Controls.Add(this.label10);
            this.groupDataFromBms.Controls.Add(this.label11);
            this.groupDataFromBms.Controls.Add(this.label13);
            this.groupDataFromBms.Controls.Add(this.boxTemp1);
            this.groupDataFromBms.Controls.Add(this.textBox5);
            this.groupDataFromBms.Controls.Add(this.textBox4);
            this.groupDataFromBms.Controls.Add(this.textBox3);
            this.groupDataFromBms.Controls.Add(this.textBox2);
            this.groupDataFromBms.Controls.Add(this.textBox1);
            this.groupDataFromBms.Controls.Add(this.BoxPWM6);
            this.groupDataFromBms.Controls.Add(this.BoxPWM5);
            this.groupDataFromBms.Controls.Add(this.BoxPWM4);
            this.groupDataFromBms.Controls.Add(this.BoxPWM3);
            this.groupDataFromBms.Controls.Add(this.BoxPWM2);
            this.groupDataFromBms.Controls.Add(this.BoxPWM1);
            this.groupDataFromBms.Controls.Add(this.label6);
            this.groupDataFromBms.Controls.Add(this.label5);
            this.groupDataFromBms.Controls.Add(this.label4);
            this.groupDataFromBms.Controls.Add(this.label3);
            this.groupDataFromBms.Controls.Add(this.label2);
            this.groupDataFromBms.Location = new System.Drawing.Point(104, 32);
            this.groupDataFromBms.Name = "groupDataFromBms";
            this.groupDataFromBms.Size = new System.Drawing.Size(601, 318);
            this.groupDataFromBms.TabIndex = 6;
            this.groupDataFromBms.TabStop = false;
            this.groupDataFromBms.Text = "Data from battery pack";
            this.groupDataFromBms.Visible = false;
            // 
            // boxStatus1b4
            // 
            this.boxStatus1b4.BackColor = System.Drawing.Color.LimeGreen;
            this.boxStatus1b4.Enabled = false;
            this.boxStatus1b4.Location = new System.Drawing.Point(298, 292);
            this.boxStatus1b4.Name = "boxStatus1b4";
            this.boxStatus1b4.Size = new System.Drawing.Size(116, 20);
            this.boxStatus1b4.TabIndex = 138;
            this.boxStatus1b4.Text = "OVERVOLTAGE";
            this.boxStatus1b4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(334, 35);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(80, 13);
            this.label28.TabIndex = 137;
            this.label28.Text = "MAX Balancing";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(265, 35);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(63, 13);
            this.label27.TabIndex = 136;
            this.label27.Text = "Min Voltage";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(193, 35);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 13);
            this.label26.TabIndex = 135;
            this.label26.Text = "Max Voltage";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(126, 32);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 13);
            this.label25.TabIndex = 134;
            this.label25.Text = "Balancing";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(64, 35);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 13);
            this.label24.TabIndex = 133;
            this.label24.Text = "Voltage";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // boxMaxPwm1
            // 
            this.boxMaxPwm1.Enabled = false;
            this.boxMaxPwm1.Location = new System.Drawing.Point(345, 51);
            this.boxMaxPwm1.Name = "boxMaxPwm1";
            this.boxMaxPwm1.Size = new System.Drawing.Size(51, 20);
            this.boxMaxPwm1.TabIndex = 132;
            this.boxMaxPwm1.Text = "3,66";
            this.boxMaxPwm1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxMaxPwm6
            // 
            this.boxMaxPwm6.Enabled = false;
            this.boxMaxPwm6.Location = new System.Drawing.Point(345, 181);
            this.boxMaxPwm6.Name = "boxMaxPwm6";
            this.boxMaxPwm6.Size = new System.Drawing.Size(51, 20);
            this.boxMaxPwm6.TabIndex = 131;
            this.boxMaxPwm6.Text = "3,66";
            this.boxMaxPwm6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxMaxPwm5
            // 
            this.boxMaxPwm5.Enabled = false;
            this.boxMaxPwm5.Location = new System.Drawing.Point(345, 155);
            this.boxMaxPwm5.Name = "boxMaxPwm5";
            this.boxMaxPwm5.Size = new System.Drawing.Size(51, 20);
            this.boxMaxPwm5.TabIndex = 130;
            this.boxMaxPwm5.Text = "3,66";
            this.boxMaxPwm5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxMaxPwm4
            // 
            this.boxMaxPwm4.Enabled = false;
            this.boxMaxPwm4.Location = new System.Drawing.Point(345, 129);
            this.boxMaxPwm4.Name = "boxMaxPwm4";
            this.boxMaxPwm4.Size = new System.Drawing.Size(51, 20);
            this.boxMaxPwm4.TabIndex = 129;
            this.boxMaxPwm4.Text = "3,66";
            this.boxMaxPwm4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxMaxPwm3
            // 
            this.boxMaxPwm3.Enabled = false;
            this.boxMaxPwm3.Location = new System.Drawing.Point(345, 103);
            this.boxMaxPwm3.Name = "boxMaxPwm3";
            this.boxMaxPwm3.Size = new System.Drawing.Size(51, 20);
            this.boxMaxPwm3.TabIndex = 128;
            this.boxMaxPwm3.Text = "3,66";
            this.boxMaxPwm3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxMaxPwm2
            // 
            this.boxMaxPwm2.Enabled = false;
            this.boxMaxPwm2.Location = new System.Drawing.Point(345, 77);
            this.boxMaxPwm2.Name = "boxMaxPwm2";
            this.boxMaxPwm2.Size = new System.Drawing.Size(51, 20);
            this.boxMaxPwm2.TabIndex = 127;
            this.boxMaxPwm2.Text = "3,66";
            this.boxMaxPwm2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxMinV1
            // 
            this.boxMinV1.Enabled = false;
            this.boxMinV1.Location = new System.Drawing.Point(273, 51);
            this.boxMinV1.Name = "boxMinV1";
            this.boxMinV1.Size = new System.Drawing.Size(51, 20);
            this.boxMinV1.TabIndex = 126;
            this.boxMinV1.Text = "3,66";
            this.boxMinV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxMinV6
            // 
            this.boxMinV6.Enabled = false;
            this.boxMinV6.Location = new System.Drawing.Point(273, 181);
            this.boxMinV6.Name = "boxMinV6";
            this.boxMinV6.Size = new System.Drawing.Size(51, 20);
            this.boxMinV6.TabIndex = 125;
            this.boxMinV6.Text = "3,66";
            this.boxMinV6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxMinV5
            // 
            this.boxMinV5.Enabled = false;
            this.boxMinV5.Location = new System.Drawing.Point(273, 155);
            this.boxMinV5.Name = "boxMinV5";
            this.boxMinV5.Size = new System.Drawing.Size(51, 20);
            this.boxMinV5.TabIndex = 124;
            this.boxMinV5.Text = "3,66";
            this.boxMinV5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxMinV4
            // 
            this.boxMinV4.Enabled = false;
            this.boxMinV4.Location = new System.Drawing.Point(273, 129);
            this.boxMinV4.Name = "boxMinV4";
            this.boxMinV4.Size = new System.Drawing.Size(51, 20);
            this.boxMinV4.TabIndex = 123;
            this.boxMinV4.Text = "3,66";
            this.boxMinV4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxMinV3
            // 
            this.boxMinV3.Enabled = false;
            this.boxMinV3.Location = new System.Drawing.Point(273, 103);
            this.boxMinV3.Name = "boxMinV3";
            this.boxMinV3.Size = new System.Drawing.Size(51, 20);
            this.boxMinV3.TabIndex = 122;
            this.boxMinV3.Text = "3,66";
            this.boxMinV3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxMinV2
            // 
            this.boxMinV2.Enabled = false;
            this.boxMinV2.Location = new System.Drawing.Point(273, 77);
            this.boxMinV2.Name = "boxMinV2";
            this.boxMinV2.Size = new System.Drawing.Size(51, 20);
            this.boxMinV2.TabIndex = 121;
            this.boxMinV2.Text = "3,66";
            this.boxMinV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxMaxV1
            // 
            this.boxMaxV1.Enabled = false;
            this.boxMaxV1.Location = new System.Drawing.Point(201, 51);
            this.boxMaxV1.Name = "boxMaxV1";
            this.boxMaxV1.Size = new System.Drawing.Size(51, 20);
            this.boxMaxV1.TabIndex = 120;
            this.boxMaxV1.Text = "3,66";
            this.boxMaxV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxMaxV6
            // 
            this.boxMaxV6.Enabled = false;
            this.boxMaxV6.Location = new System.Drawing.Point(201, 181);
            this.boxMaxV6.Name = "boxMaxV6";
            this.boxMaxV6.Size = new System.Drawing.Size(51, 20);
            this.boxMaxV6.TabIndex = 119;
            this.boxMaxV6.Text = "3,66";
            this.boxMaxV6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxMaxV5
            // 
            this.boxMaxV5.Enabled = false;
            this.boxMaxV5.Location = new System.Drawing.Point(201, 155);
            this.boxMaxV5.Name = "boxMaxV5";
            this.boxMaxV5.Size = new System.Drawing.Size(51, 20);
            this.boxMaxV5.TabIndex = 118;
            this.boxMaxV5.Text = "3,66";
            this.boxMaxV5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxMaxV4
            // 
            this.boxMaxV4.Enabled = false;
            this.boxMaxV4.Location = new System.Drawing.Point(201, 129);
            this.boxMaxV4.Name = "boxMaxV4";
            this.boxMaxV4.Size = new System.Drawing.Size(51, 20);
            this.boxMaxV4.TabIndex = 117;
            this.boxMaxV4.Text = "3,66";
            this.boxMaxV4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxMaxV3
            // 
            this.boxMaxV3.Enabled = false;
            this.boxMaxV3.Location = new System.Drawing.Point(201, 103);
            this.boxMaxV3.Name = "boxMaxV3";
            this.boxMaxV3.Size = new System.Drawing.Size(51, 20);
            this.boxMaxV3.TabIndex = 116;
            this.boxMaxV3.Text = "3,66";
            this.boxMaxV3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxMaxV2
            // 
            this.boxMaxV2.Enabled = false;
            this.boxMaxV2.Location = new System.Drawing.Point(201, 77);
            this.boxMaxV2.Name = "boxMaxV2";
            this.boxMaxV2.Size = new System.Drawing.Size(51, 20);
            this.boxMaxV2.TabIndex = 115;
            this.boxMaxV2.Text = "3,66";
            this.boxMaxV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox0
            // 
            this.textBox0.Enabled = false;
            this.textBox0.Location = new System.Drawing.Point(56, 51);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(51, 20);
            this.textBox0.TabIndex = 114;
            this.textBox0.Text = "3,66";
            this.textBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 54);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 113;
            this.label18.Text = "CELL 1";
            // 
            // boxStatus1b2
            // 
            this.boxStatus1b2.BackColor = System.Drawing.Color.LimeGreen;
            this.boxStatus1b2.Enabled = false;
            this.boxStatus1b2.Location = new System.Drawing.Point(154, 292);
            this.boxStatus1b2.Name = "boxStatus1b2";
            this.boxStatus1b2.Size = new System.Drawing.Size(65, 20);
            this.boxStatus1b2.TabIndex = 112;
            this.boxStatus1b2.Text = "EMPTY";
            this.boxStatus1b2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxStatus1b3
            // 
            this.boxStatus1b3.BackColor = System.Drawing.Color.LimeGreen;
            this.boxStatus1b3.Enabled = false;
            this.boxStatus1b3.Location = new System.Drawing.Point(227, 292);
            this.boxStatus1b3.Name = "boxStatus1b3";
            this.boxStatus1b3.Size = new System.Drawing.Size(65, 20);
            this.boxStatus1b3.TabIndex = 111;
            this.boxStatus1b3.Text = "CUT-OFF";
            this.boxStatus1b3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(-325, 313);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 108;
            this.label17.Text = " Status";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(-290, 302);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 108;
            this.label16.Text = " Status";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(-277, 305);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 108;
            this.label15.Text = " Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 108;
            this.label1.Text = "Status byte1";
            // 
            // boxStatus0b0
            // 
            this.boxStatus0b0.BackColor = System.Drawing.Color.LimeGreen;
            this.boxStatus0b0.Enabled = false;
            this.boxStatus0b0.Location = new System.Drawing.Point(435, 240);
            this.boxStatus0b0.Name = "boxStatus0b0";
            this.boxStatus0b0.Size = new System.Drawing.Size(65, 20);
            this.boxStatus0b0.TabIndex = 107;
            this.boxStatus0b0.Text = "ROK6";
            this.boxStatus0b0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxStatus0b1
            // 
            this.boxStatus0b1.BackColor = System.Drawing.Color.LimeGreen;
            this.boxStatus0b1.Enabled = false;
            this.boxStatus0b1.Location = new System.Drawing.Point(364, 240);
            this.boxStatus0b1.Name = "boxStatus0b1";
            this.boxStatus0b1.Size = new System.Drawing.Size(65, 20);
            this.boxStatus0b1.TabIndex = 106;
            this.boxStatus0b1.Text = "ROK5";
            this.boxStatus0b1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxStatus0b3
            // 
            this.boxStatus0b3.BackColor = System.Drawing.Color.LimeGreen;
            this.boxStatus0b3.Enabled = false;
            this.boxStatus0b3.Location = new System.Drawing.Point(222, 240);
            this.boxStatus0b3.Name = "boxStatus0b3";
            this.boxStatus0b3.Size = new System.Drawing.Size(65, 20);
            this.boxStatus0b3.TabIndex = 105;
            this.boxStatus0b3.Text = "ROK3";
            this.boxStatus0b3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxStatus0b2
            // 
            this.boxStatus0b2.BackColor = System.Drawing.Color.LimeGreen;
            this.boxStatus0b2.Enabled = false;
            this.boxStatus0b2.Location = new System.Drawing.Point(293, 240);
            this.boxStatus0b2.Name = "boxStatus0b2";
            this.boxStatus0b2.Size = new System.Drawing.Size(65, 20);
            this.boxStatus0b2.TabIndex = 104;
            this.boxStatus0b2.Text = "ROK4";
            this.boxStatus0b2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxStatus0b4
            // 
            this.boxStatus0b4.BackColor = System.Drawing.Color.LimeGreen;
            this.boxStatus0b4.Enabled = false;
            this.boxStatus0b4.Location = new System.Drawing.Point(151, 240);
            this.boxStatus0b4.Name = "boxStatus0b4";
            this.boxStatus0b4.Size = new System.Drawing.Size(65, 20);
            this.boxStatus0b4.TabIndex = 103;
            this.boxStatus0b4.Text = "ROK2";
            this.boxStatus0b4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxStatus0b5
            // 
            this.boxStatus0b5.BackColor = System.Drawing.Color.LimeGreen;
            this.boxStatus0b5.Enabled = false;
            this.boxStatus0b5.Location = new System.Drawing.Point(80, 240);
            this.boxStatus0b5.Name = "boxStatus0b5";
            this.boxStatus0b5.Size = new System.Drawing.Size(65, 20);
            this.boxStatus0b5.TabIndex = 102;
            this.boxStatus0b5.Text = "ROK1";
            this.boxStatus0b5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxStatus0b6
            // 
            this.boxStatus0b6.BackColor = System.Drawing.Color.LimeGreen;
            this.boxStatus0b6.Enabled = false;
            this.boxStatus0b6.Location = new System.Drawing.Point(9, 240);
            this.boxStatus0b6.Name = "boxStatus0b6";
            this.boxStatus0b6.Size = new System.Drawing.Size(65, 20);
            this.boxStatus0b6.TabIndex = 101;
            this.boxStatus0b6.Text = "READ OK";
            this.boxStatus0b6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxStatus1b1
            // 
            this.boxStatus1b1.BackColor = System.Drawing.Color.LimeGreen;
            this.boxStatus1b1.Enabled = false;
            this.boxStatus1b1.Location = new System.Drawing.Point(80, 292);
            this.boxStatus1b1.Name = "boxStatus1b1";
            this.boxStatus1b1.Size = new System.Drawing.Size(65, 20);
            this.boxStatus1b1.TabIndex = 99;
            this.boxStatus1b1.Text = "ONE FULL";
            this.boxStatus1b1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxTemp4
            // 
            this.boxTemp4.Enabled = false;
            this.boxTemp4.Location = new System.Drawing.Point(529, 129);
            this.boxTemp4.Name = "boxTemp4";
            this.boxTemp4.Size = new System.Drawing.Size(51, 20);
            this.boxTemp4.TabIndex = 98;
            this.boxTemp4.Text = "3,66";
            this.boxTemp4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxTemp3
            // 
            this.boxTemp3.Enabled = false;
            this.boxTemp3.Location = new System.Drawing.Point(529, 100);
            this.boxTemp3.Name = "boxTemp3";
            this.boxTemp3.Size = new System.Drawing.Size(51, 20);
            this.boxTemp3.TabIndex = 97;
            this.boxTemp3.Text = "3,66";
            this.boxTemp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxTemp2
            // 
            this.boxTemp2.Enabled = false;
            this.boxTemp2.Location = new System.Drawing.Point(527, 74);
            this.boxTemp2.Name = "boxTemp2";
            this.boxTemp2.Size = new System.Drawing.Size(51, 20);
            this.boxTemp2.TabIndex = 96;
            this.boxTemp2.Text = "3,66";
            this.boxTemp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxStatus1b0
            // 
            this.boxStatus1b0.BackColor = System.Drawing.Color.LimeGreen;
            this.boxStatus1b0.Enabled = false;
            this.boxStatus1b0.Location = new System.Drawing.Point(9, 292);
            this.boxStatus1b0.Name = "boxStatus1b0";
            this.boxStatus1b0.Size = new System.Drawing.Size(65, 20);
            this.boxStatus1b0.TabIndex = 95;
            this.boxStatus1b0.Text = "ALL FULL";
            this.boxStatus1b0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 88;
            this.label7.Text = "Status byte0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "Temperature Ch4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 86;
            this.label10.Text = "Temperature Ch3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(432, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 85;
            this.label11.Text = "Temperature Ch2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(432, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 83;
            this.label13.Text = "Temperature Ch1";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // boxTemp1
            // 
            this.boxTemp1.Enabled = false;
            this.boxTemp1.Location = new System.Drawing.Point(527, 47);
            this.boxTemp1.Name = "boxTemp1";
            this.boxTemp1.Size = new System.Drawing.Size(51, 20);
            this.boxTemp1.TabIndex = 84;
            this.boxTemp1.Text = "3,66";
            this.boxTemp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(56, 181);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(51, 20);
            this.textBox5.TabIndex = 82;
            this.textBox5.Text = "3,66";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(56, 155);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(51, 20);
            this.textBox4.TabIndex = 81;
            this.textBox4.Text = "3,66";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(56, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(51, 20);
            this.textBox3.TabIndex = 80;
            this.textBox3.Text = "3,66";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(56, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 20);
            this.textBox2.TabIndex = 79;
            this.textBox2.Text = "3,66";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(56, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 78;
            this.textBox1.Text = "3,66";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BoxPWM6
            // 
            this.BoxPWM6.BackColor = System.Drawing.Color.LimeGreen;
            this.BoxPWM6.Enabled = false;
            this.BoxPWM6.Location = new System.Drawing.Point(128, 181);
            this.BoxPWM6.Name = "BoxPWM6";
            this.BoxPWM6.Size = new System.Drawing.Size(52, 20);
            this.BoxPWM6.TabIndex = 77;
            this.BoxPWM6.Text = "100";
            this.BoxPWM6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BoxPWM5
            // 
            this.BoxPWM5.BackColor = System.Drawing.Color.LimeGreen;
            this.BoxPWM5.Enabled = false;
            this.BoxPWM5.Location = new System.Drawing.Point(128, 155);
            this.BoxPWM5.Name = "BoxPWM5";
            this.BoxPWM5.Size = new System.Drawing.Size(52, 20);
            this.BoxPWM5.TabIndex = 76;
            this.BoxPWM5.Text = "100";
            this.BoxPWM5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BoxPWM4
            // 
            this.BoxPWM4.BackColor = System.Drawing.Color.LimeGreen;
            this.BoxPWM4.Enabled = false;
            this.BoxPWM4.Location = new System.Drawing.Point(128, 129);
            this.BoxPWM4.Name = "BoxPWM4";
            this.BoxPWM4.Size = new System.Drawing.Size(52, 20);
            this.BoxPWM4.TabIndex = 75;
            this.BoxPWM4.Text = "100";
            this.BoxPWM4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BoxPWM3
            // 
            this.BoxPWM3.BackColor = System.Drawing.Color.LimeGreen;
            this.BoxPWM3.Enabled = false;
            this.BoxPWM3.Location = new System.Drawing.Point(128, 103);
            this.BoxPWM3.Name = "BoxPWM3";
            this.BoxPWM3.Size = new System.Drawing.Size(52, 20);
            this.BoxPWM3.TabIndex = 74;
            this.BoxPWM3.Text = "100";
            this.BoxPWM3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BoxPWM2
            // 
            this.BoxPWM2.BackColor = System.Drawing.Color.LimeGreen;
            this.BoxPWM2.Enabled = false;
            this.BoxPWM2.Location = new System.Drawing.Point(128, 77);
            this.BoxPWM2.Name = "BoxPWM2";
            this.BoxPWM2.Size = new System.Drawing.Size(52, 20);
            this.BoxPWM2.TabIndex = 73;
            this.BoxPWM2.Text = "100";
            this.BoxPWM2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BoxPWM1
            // 
            this.BoxPWM1.BackColor = System.Drawing.Color.LimeGreen;
            this.BoxPWM1.Enabled = false;
            this.BoxPWM1.Location = new System.Drawing.Point(128, 51);
            this.BoxPWM1.Name = "BoxPWM1";
            this.BoxPWM1.Size = new System.Drawing.Size(52, 20);
            this.BoxPWM1.TabIndex = 72;
            this.BoxPWM1.Text = "100";
            this.BoxPWM1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "CELL 6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "CELL 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "CELL 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "CELL 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "CELL 2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(625, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.appCANbaudrate);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Location = new System.Drawing.Point(15, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 79);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "APP Settings";
            // 
            // appCANbaudrate
            // 
            this.appCANbaudrate.FormattingEnabled = true;
            this.appCANbaudrate.Items.AddRange(new object[] {
            "250",
            "500"});
            this.appCANbaudrate.Location = new System.Drawing.Point(80, 29);
            this.appCANbaudrate.Name = "appCANbaudrate";
            this.appCANbaudrate.Size = new System.Drawing.Size(121, 21);
            this.appCANbaudrate.TabIndex = 61;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(16, 37);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(58, 13);
            this.label36.TabIndex = 64;
            this.label36.Text = "Baud Rate";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.boxNewMasterId);
            this.groupBox2.Controls.Add(this.boxBaudRate);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnSaveSettings);
            this.groupBox2.Controls.Add(this.MasterID);
            this.groupBox2.Location = new System.Drawing.Point(15, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 135);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BMS Settings";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 67;
            this.label14.Text = "Old ID";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 53);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 13);
            this.label22.TabIndex = 65;
            this.label22.Text = "New ID";
            // 
            // boxNewMasterId
            // 
            this.boxNewMasterId.Location = new System.Drawing.Point(80, 46);
            this.boxNewMasterId.Name = "boxNewMasterId";
            this.boxNewMasterId.Size = new System.Drawing.Size(58, 20);
            this.boxNewMasterId.TabIndex = 66;
            // 
            // boxBaudRate
            // 
            this.boxBaudRate.FormattingEnabled = true;
            this.boxBaudRate.Items.AddRange(new object[] {
            "250",
            "500"});
            this.boxBaudRate.Location = new System.Drawing.Point(80, 72);
            this.boxBaudRate.Name = "boxBaudRate";
            this.boxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.boxBaudRate.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 64;
            this.label12.Text = "Baud Rate";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(220, 74);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 68;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // MasterID
            // 
            this.MasterID.Location = new System.Drawing.Point(80, 19);
            this.MasterID.Name = "MasterID";
            this.MasterID.Size = new System.Drawing.Size(58, 20);
            this.MasterID.TabIndex = 63;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(90, 57);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(296, 18);
            this.label29.TabIndex = 123;
            this.label29.Text = "Battery Managment System  configuration";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 139;
            this.label9.Text = "Detected packs";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(19, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(89, 277);
            this.listBox1.TabIndex = 127;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(371, 249);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(127, 20);
            this.textBox6.TabIndex = 128;
            this.textBox6.Text = "7";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_BMS_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(726, 742);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnReleseCAN);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.lbxInfo);
            this.Controls.Add(this.Btn_connectCAN);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_BMS_Config";
            this.Text = "BMS_Config";
            this.Load += new System.EventHandler(this.Form_BMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupDataFromBms.ResumeLayout(false);
            this.groupDataFromBms.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_connectCAN;
        private System.Windows.Forms.ListBox lbxInfo;
        private System.Windows.Forms.Timer tmrDisplay;
        private System.Windows.Forms.ListView lstMessages;
        private System.Windows.Forms.ColumnHeader clhType;
        private System.Windows.Forms.ColumnHeader clhID;
        private System.Windows.Forms.ColumnHeader clhLength;
        private System.Windows.Forms.ColumnHeader clhData;
        private System.Windows.Forms.ColumnHeader clhCount;
        private System.Windows.Forms.ColumnHeader clhRcvTime;
        private System.Windows.Forms.Timer tmrRead;
        private System.Windows.Forms.Button btnReleseCAN;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupDataFromBms;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox boxStatus1b2;
        private System.Windows.Forms.TextBox boxStatus1b3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxStatus0b0;
        private System.Windows.Forms.TextBox boxStatus0b1;
        private System.Windows.Forms.TextBox boxStatus0b3;
        private System.Windows.Forms.TextBox boxStatus0b2;
        private System.Windows.Forms.TextBox boxStatus0b4;
        private System.Windows.Forms.TextBox boxStatus0b5;
        private System.Windows.Forms.TextBox boxStatus0b6;
        private System.Windows.Forms.TextBox boxStatus1b1;
        private System.Windows.Forms.TextBox boxTemp4;
        private System.Windows.Forms.TextBox boxTemp3;
        private System.Windows.Forms.TextBox boxTemp2;
        private System.Windows.Forms.TextBox boxStatus1b0;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox boxTemp1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox BoxPWM6;
        private System.Windows.Forms.TextBox BoxPWM5;
        private System.Windows.Forms.TextBox BoxPWM4;
        private System.Windows.Forms.TextBox BoxPWM3;
        private System.Windows.Forms.TextBox BoxPWM2;
        private System.Windows.Forms.TextBox BoxPWM1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox boxBaudRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.TextBox MasterID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox boxNumberOfPacks;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox boxNewMasterId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox boxMaxPwm1;
        private System.Windows.Forms.TextBox boxMaxPwm6;
        private System.Windows.Forms.TextBox boxMaxPwm5;
        private System.Windows.Forms.TextBox boxMaxPwm4;
        private System.Windows.Forms.TextBox boxMaxPwm3;
        private System.Windows.Forms.TextBox boxMaxPwm2;
        private System.Windows.Forms.TextBox boxMinV1;
        private System.Windows.Forms.TextBox boxMinV6;
        private System.Windows.Forms.TextBox boxMinV5;
        private System.Windows.Forms.TextBox boxMinV4;
        private System.Windows.Forms.TextBox boxMinV3;
        private System.Windows.Forms.TextBox boxMinV2;
        private System.Windows.Forms.TextBox boxMaxV1;
        private System.Windows.Forms.TextBox boxMaxV6;
        private System.Windows.Forms.TextBox boxMaxV5;
        private System.Windows.Forms.TextBox boxMaxV4;
        private System.Windows.Forms.TextBox boxMaxV3;
        private System.Windows.Forms.TextBox boxMaxV2;
        private System.Windows.Forms.TextBox boxStatus1b4;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox appCANbaudrate;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ListBox ListBoxBmsIds;
        private System.Windows.Forms.Button ListBoxBmsIdsReset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox6;
    }
}