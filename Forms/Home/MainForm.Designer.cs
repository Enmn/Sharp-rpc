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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureAvatar = new PictureBox();
            username = new Label();
            lblApplication = new Label();
            label3 = new Label();
            label4 = new Label();
            txtApplication = new TextBox();
            txtDetail = new TextBox();
            txtState = new TextBox();
            btnConnect = new Button();
            label5 = new Label();
            btnDisconnect = new Button();
            label7 = new Label();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox7 = new TextBox();
            label11 = new Label();
            IconRunning = new NotifyIcon(components);
            btnExit = new Button();
            checkTime = new CheckBox();
            label12 = new Label();
            textBox8 = new TextBox();
            label13 = new Label();
            textBox9 = new TextBox();
            label14 = new Label();
            textBox10 = new TextBox();
            label15 = new Label();
            textBox11 = new TextBox();
            comboLargeKey = new FlatComboBox();
            comboSmallKey = new FlatComboBox();
            label16 = new Label();
            statusUser = new Label();
            partySize = new NumericUpDown();
            label19 = new Label();
            partyMax = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partySize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partyMax).BeginInit();
            SuspendLayout();
            // 
            // pictureAvatar
            // 
            pictureAvatar.BackColor = Color.FromArgb(52, 53, 56);
            pictureAvatar.BorderStyle = BorderStyle.FixedSingle;
            pictureAvatar.Location = new Point(11, 12);
            pictureAvatar.Name = "pictureAvatar";
            pictureAvatar.Size = new Size(85, 85);
            pictureAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureAvatar.TabIndex = 0;
            pictureAvatar.TabStop = false;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            username.ForeColor = Color.White;
            username.Location = new Point(101, 33);
            username.Name = "username";
            username.Size = new Size(58, 17);
            username.TabIndex = 1;
            username.Text = "Unknow";
            // 
            // lblApplication
            // 
            lblApplication.AutoSize = true;
            lblApplication.ForeColor = Color.White;
            lblApplication.Location = new Point(11, 126);
            lblApplication.Name = "lblApplication";
            lblApplication.Size = new Size(82, 15);
            lblApplication.TabIndex = 2;
            lblApplication.Text = "Application ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 156);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(11, 188);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 4;
            label4.Text = "State";
            // 
            // txtApplication
            // 
            txtApplication.BackColor = Color.FromArgb(52, 53, 56);
            txtApplication.BorderStyle = BorderStyle.None;
            txtApplication.ForeColor = Color.White;
            txtApplication.Location = new Point(114, 126);
            txtApplication.Multiline = true;
            txtApplication.Name = "txtApplication";
            txtApplication.Size = new Size(324, 23);
            txtApplication.TabIndex = 5;
            txtApplication.TextChanged += txtApplication_TextChanged;
            // 
            // txtDetail
            // 
            txtDetail.BackColor = Color.FromArgb(52, 53, 56);
            txtDetail.BorderStyle = BorderStyle.None;
            txtDetail.ForeColor = Color.White;
            txtDetail.Location = new Point(114, 156);
            txtDetail.Multiline = true;
            txtDetail.Name = "txtDetail";
            txtDetail.Size = new Size(324, 23);
            txtDetail.TabIndex = 6;
            // 
            // txtState
            // 
            txtState.BackColor = Color.FromArgb(52, 53, 56);
            txtState.BorderStyle = BorderStyle.None;
            txtState.ForeColor = Color.White;
            txtState.Location = new Point(114, 186);
            txtState.Multiline = true;
            txtState.Name = "txtState";
            txtState.Size = new Size(192, 23);
            txtState.TabIndex = 7;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.FromArgb(52, 53, 56);
            btnConnect.FlatAppearance.BorderSize = 0;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(12, 451);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 22);
            btnConnect.TabIndex = 8;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(143, 151, 160);
            label5.Location = new Point(101, 16);
            label5.Name = "label5";
            label5.Size = new Size(76, 13);
            label5.TabIndex = 9;
            label5.Text = "USERNAME";
            // 
            // btnDisconnect
            // 
            btnDisconnect.BackColor = Color.FromArgb(52, 53, 56);
            btnDisconnect.FlatAppearance.BorderSize = 0;
            btnDisconnect.FlatStyle = FlatStyle.Flat;
            btnDisconnect.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDisconnect.ForeColor = Color.White;
            btnDisconnect.Location = new Point(93, 451);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(92, 22);
            btnDisconnect.TabIndex = 10;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = false;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(11, 244);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 12;
            label7.Text = "Large Image Key";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(276, 244);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 14;
            label8.Text = "Text";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(52, 53, 56);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(309, 240);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(129, 23);
            textBox5.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(11, 272);
            label9.Name = "label9";
            label9.Size = new Size(94, 15);
            label9.TabIndex = 16;
            label9.Text = "Small Image Key";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(276, 272);
            label10.Name = "label10";
            label10.Size = new Size(28, 15);
            label10.TabIndex = 18;
            label10.Text = "Text";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(52, 53, 56);
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.ForeColor = Color.White;
            textBox7.Location = new Point(309, 269);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(129, 23);
            textBox7.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(12, 327);
            label11.Name = "label11";
            label11.Size = new Size(68, 15);
            label11.TabIndex = 20;
            label11.Text = "First Button";
            // 
            // IconRunning
            // 
            IconRunning.Icon = (Icon)resources.GetObject("IconRunning.Icon");
            IconRunning.Text = "SharpRPC Running";
            IconRunning.Visible = true;
            IconRunning.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(52, 53, 56);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(191, 451);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 22);
            btnExit.TabIndex = 22;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // checkTime
            // 
            checkTime.AutoSize = true;
            checkTime.ForeColor = Color.White;
            checkTime.Location = new Point(112, 406);
            checkTime.Name = "checkTime";
            checkTime.Size = new Size(68, 19);
            checkTime.TabIndex = 23;
            checkTime.Text = "Enabled";
            checkTime.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(12, 407);
            label12.Name = "label12";
            label12.Size = new Size(66, 15);
            label12.TabIndex = 24;
            label12.Text = "Timestamp";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(52, 53, 56);
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.ForeColor = Color.White;
            textBox8.Location = new Point(113, 323);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(159, 23);
            textBox8.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(277, 327);
            label13.Name = "label13";
            label13.Size = new Size(28, 15);
            label13.TabIndex = 26;
            label13.Text = "URL";
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.FromArgb(52, 53, 56);
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.ForeColor = Color.White;
            textBox9.Location = new Point(309, 323);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(129, 23);
            textBox9.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.White;
            label14.Location = new Point(12, 356);
            label14.Name = "label14";
            label14.Size = new Size(85, 15);
            label14.TabIndex = 28;
            label14.Text = "Second Button";
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.FromArgb(52, 53, 56);
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.ForeColor = Color.White;
            textBox10.Location = new Point(113, 352);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(159, 23);
            textBox10.TabIndex = 29;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.White;
            label15.Location = new Point(276, 356);
            label15.Name = "label15";
            label15.Size = new Size(28, 15);
            label15.TabIndex = 30;
            label15.Text = "URL";
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.FromArgb(52, 53, 56);
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.ForeColor = Color.White;
            textBox11.Location = new Point(309, 352);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(129, 23);
            textBox11.TabIndex = 31;
            // 
            // comboLargeKey
            // 
            comboLargeKey.BackColor = Color.FromArgb(52, 53, 56);
            comboLargeKey.BorderColor = Color.FromArgb(52, 53, 56);
            comboLargeKey.ButtonColor = Color.FromArgb(37, 38, 50);
            comboLargeKey.FlatStyle = FlatStyle.Flat;
            comboLargeKey.ForeColor = Color.White;
            comboLargeKey.FormattingEnabled = true;
            comboLargeKey.Location = new Point(114, 240);
            comboLargeKey.Name = "comboLargeKey";
            comboLargeKey.Size = new Size(158, 23);
            comboLargeKey.TabIndex = 34;
            // 
            // comboSmallKey
            // 
            comboSmallKey.BackColor = Color.FromArgb(52, 53, 56);
            comboSmallKey.BorderColor = Color.FromArgb(52, 53, 56);
            comboSmallKey.ButtonColor = Color.FromArgb(37, 38, 40);
            comboSmallKey.FlatStyle = FlatStyle.Flat;
            comboSmallKey.ForeColor = Color.White;
            comboSmallKey.FormattingEnabled = true;
            comboSmallKey.Location = new Point(114, 269);
            comboSmallKey.Name = "comboSmallKey";
            comboSmallKey.Size = new Size(158, 23);
            comboSmallKey.TabIndex = 35;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(143, 151, 160);
            label16.Location = new Point(101, 64);
            label16.Name = "label16";
            label16.Size = new Size(56, 13);
            label16.TabIndex = 36;
            label16.Text = "STATUS";
            // 
            // statusUser
            // 
            statusUser.AutoSize = true;
            statusUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            statusUser.ForeColor = Color.White;
            statusUser.Location = new Point(101, 80);
            statusUser.Name = "statusUser";
            statusUser.Size = new Size(58, 17);
            statusUser.TabIndex = 37;
            statusUser.Text = "Unknow";
            // 
            // partySize
            // 
            partySize.BackColor = Color.FromArgb(52, 53, 56);
            partySize.BorderStyle = BorderStyle.None;
            partySize.ForeColor = Color.White;
            partySize.Location = new Point(312, 188);
            partySize.Name = "partySize";
            partySize.Size = new Size(50, 19);
            partySize.TabIndex = 39;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.White;
            label19.Location = new Point(365, 189);
            label19.Name = "label19";
            label19.Size = new Size(18, 15);
            label19.TabIndex = 40;
            label19.Text = "of";
            // 
            // partyMax
            // 
            partyMax.BackColor = Color.FromArgb(52, 53, 56);
            partyMax.BorderStyle = BorderStyle.None;
            partyMax.ForeColor = Color.White;
            partyMax.Location = new Point(387, 188);
            partyMax.Name = "partyMax";
            partyMax.Size = new Size(50, 19);
            partyMax.TabIndex = 41;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 69, 73);
            ClientSize = new Size(460, 488);
            Controls.Add(partyMax);
            Controls.Add(label19);
            Controls.Add(partySize);
            Controls.Add(statusUser);
            Controls.Add(label16);
            Controls.Add(comboSmallKey);
            Controls.Add(comboLargeKey);
            Controls.Add(textBox11);
            Controls.Add(label15);
            Controls.Add(textBox10);
            Controls.Add(label14);
            Controls.Add(textBox9);
            Controls.Add(label13);
            Controls.Add(textBox8);
            Controls.Add(label12);
            Controls.Add(checkTime);
            Controls.Add(btnExit);
            Controls.Add(label11);
            Controls.Add(textBox7);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnDisconnect);
            Controls.Add(label5);
            Controls.Add(btnConnect);
            Controls.Add(txtState);
            Controls.Add(txtDetail);
            Controls.Add(txtApplication);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblApplication);
            Controls.Add(username);
            Controls.Add(pictureAvatar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sharp Rich Presence";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)partySize).EndInit();
            ((System.ComponentModel.ISupportInitialize)partyMax).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}