namespace SharpRPC
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureAvatar = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.Label();
            this.lblApplication = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApplication = new System.Windows.Forms.TextBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.statusOnline = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.IconRunning = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.checkTime = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.comboLargeKey = new SharpRPC.FlatComboBox();
            this.comboSmallKey = new SharpRPC.FlatComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.statusUser = new System.Windows.Forms.Label();
            this.partySize = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.partyMax = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyMax)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.pictureAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureAvatar.Location = new System.Drawing.Point(11, 12);
            this.pictureAvatar.Name = "pictureAvatar";
            this.pictureAvatar.Size = new System.Drawing.Size(85, 85);
            this.pictureAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAvatar.TabIndex = 0;
            this.pictureAvatar.TabStop = false;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(101, 33);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(58, 17);
            this.username.TabIndex = 1;
            this.username.Text = "Unknow";
            // 
            // lblApplication
            // 
            this.lblApplication.AutoSize = true;
            this.lblApplication.ForeColor = System.Drawing.Color.White;
            this.lblApplication.Location = new System.Drawing.Point(11, 126);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Size = new System.Drawing.Size(82, 15);
            this.lblApplication.TabIndex = 2;
            this.lblApplication.Text = "Application ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "State";
            // 
            // txtApplication
            // 
            this.txtApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.txtApplication.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApplication.ForeColor = System.Drawing.Color.White;
            this.txtApplication.Location = new System.Drawing.Point(114, 126);
            this.txtApplication.Multiline = true;
            this.txtApplication.Name = "txtApplication";
            this.txtApplication.Size = new System.Drawing.Size(324, 23);
            this.txtApplication.TabIndex = 5;
            this.txtApplication.TextChanged += new System.EventHandler(this.txtApplication_TextChanged);
            // 
            // txtDetail
            // 
            this.txtDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.txtDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetail.ForeColor = System.Drawing.Color.White;
            this.txtDetail.Location = new System.Drawing.Point(114, 156);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(324, 23);
            this.txtDetail.TabIndex = 6;
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtState.ForeColor = System.Drawing.Color.White;
            this.txtState.Location = new System.Drawing.Point(114, 186);
            this.txtState.Multiline = true;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(192, 23);
            this.txtState.TabIndex = 7;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(11, 466);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 22);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans ExtraBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(101, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "USERNAME";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.btnDisconnect.FlatAppearance.BorderSize = 0;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnDisconnect.Location = new System.Drawing.Point(93, 466);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(92, 22);
            this.btnDisconnect.TabIndex = 10;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // statusOnline
            // 
            this.statusOnline.AutoSize = true;
            this.statusOnline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            this.statusOnline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusOnline.Location = new System.Drawing.Point(12, 11);
            this.statusOnline.Name = "statusOnline";
            this.statusOnline.Size = new System.Drawing.Size(88, 15);
            this.statusOnline.TabIndex = 11;
            this.statusOnline.Text = "Not Connected";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Large Image Key";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(276, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Text";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(309, 240);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(129, 23);
            this.textBox5.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Small Image Key";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(276, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Text";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(309, 269);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(129, 23);
            this.textBox7.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "First Button";
            // 
            // IconRunning
            // 
            this.IconRunning.Icon = ((System.Drawing.Icon)(resources.GetObject("IconRunning.Icon")));
            this.IconRunning.Text = "SharpRPC Running";
            this.IconRunning.Visible = true;
            this.IconRunning.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(191, 466);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 22);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // checkTime
            // 
            this.checkTime.AutoSize = true;
            this.checkTime.ForeColor = System.Drawing.Color.White;
            this.checkTime.Location = new System.Drawing.Point(112, 406);
            this.checkTime.Name = "checkTime";
            this.checkTime.Size = new System.Drawing.Size(68, 19);
            this.checkTime.TabIndex = 23;
            this.checkTime.Text = "Enabled";
            this.checkTime.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Timestamp";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(113, 323);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(159, 23);
            this.textBox8.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(277, 327);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "URL";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.ForeColor = System.Drawing.Color.White;
            this.textBox9.Location = new System.Drawing.Point(309, 323);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(129, 23);
            this.textBox9.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(12, 356);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "Second Button";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.ForeColor = System.Drawing.Color.White;
            this.textBox10.Location = new System.Drawing.Point(113, 352);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(159, 23);
            this.textBox10.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(276, 356);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 15);
            this.label15.TabIndex = 30;
            this.label15.Text = "URL";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.ForeColor = System.Drawing.Color.White;
            this.textBox11.Location = new System.Drawing.Point(309, 352);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(129, 23);
            this.textBox11.TabIndex = 31;
            // 
            // comboLargeKey
            // 
            this.comboLargeKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.comboLargeKey.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.comboLargeKey.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.comboLargeKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboLargeKey.ForeColor = System.Drawing.Color.White;
            this.comboLargeKey.FormattingEnabled = true;
            this.comboLargeKey.Location = new System.Drawing.Point(114, 240);
            this.comboLargeKey.Name = "comboLargeKey";
            this.comboLargeKey.Size = new System.Drawing.Size(158, 23);
            this.comboLargeKey.TabIndex = 34;
            // 
            // comboSmallKey
            // 
            this.comboSmallKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.comboSmallKey.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.comboSmallKey.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.comboSmallKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSmallKey.ForeColor = System.Drawing.Color.White;
            this.comboSmallKey.FormattingEnabled = true;
            this.comboSmallKey.Location = new System.Drawing.Point(114, 269);
            this.comboSmallKey.Name = "comboSmallKey";
            this.comboSmallKey.Size = new System.Drawing.Size(158, 23);
            this.comboSmallKey.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Open Sans ExtraBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(151)))), ((int)(((byte)(160)))));
            this.label16.Location = new System.Drawing.Point(101, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 15);
            this.label16.TabIndex = 36;
            this.label16.Text = "STATUS";
            // 
            // statusUser
            // 
            this.statusUser.AutoSize = true;
            this.statusUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusUser.ForeColor = System.Drawing.Color.White;
            this.statusUser.Location = new System.Drawing.Point(101, 74);
            this.statusUser.Name = "statusUser";
            this.statusUser.Size = new System.Drawing.Size(58, 17);
            this.statusUser.TabIndex = 37;
            this.statusUser.Text = "Unknow";
            // 
            // partySize
            // 
            this.partySize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.partySize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.partySize.ForeColor = System.Drawing.Color.White;
            this.partySize.Location = new System.Drawing.Point(312, 188);
            this.partySize.Name = "partySize";
            this.partySize.Size = new System.Drawing.Size(50, 19);
            this.partySize.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(365, 189);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(18, 15);
            this.label19.TabIndex = 40;
            this.label19.Text = "of";
            // 
            // partyMax
            // 
            this.partyMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.partyMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.partyMax.ForeColor = System.Drawing.Color.White;
            this.partyMax.Location = new System.Drawing.Point(387, 188);
            this.partyMax.Name = "partyMax";
            this.partyMax.Size = new System.Drawing.Size(50, 19);
            this.partyMax.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.statusOnline);
            this.panel1.Location = new System.Drawing.Point(0, 497);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 37);
            this.panel1.TabIndex = 42;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(460, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.partyMax);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.partySize);
            this.Controls.Add(this.statusUser);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboSmallKey);
            this.Controls.Add(this.comboLargeKey);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.checkTime);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.txtApplication);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblApplication);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pictureAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp Rich Presence";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyMax)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureAvatar;
        private Label username;
        private Label lblApplication;
        private Label label3;
        private Label label4;
        private TextBox txtApplication;
        private TextBox txtDetail;
        private TextBox txtState;
        private Button btnConnect;
        private Label label5;
        private Button btnDisconnect;
        private Label statusOnline;
        private Label label7;
        private Label label8;
        private TextBox textBox5;
        private Label label9;
        private Label label10;
        private TextBox textBox7;
        private Label label11;
        private NotifyIcon IconRunning;
        private Button btnExit;
        private CheckBox checkTime;
        private Label label12;
        private TextBox textBox8;
        private Label label13;
        private TextBox textBox9;
        private Label label14;
        private TextBox textBox10;
        private Label label15;
        private TextBox textBox11;
        private FlatComboBox comboLargeKey;
        private FlatComboBox comboSmallKey;
        private Label label16;
        private Label statusUser;
        private NumericUpDown partySize;
        private Label label19;
        private NumericUpDown partyMax;
        private Panel panel1;
    }
}