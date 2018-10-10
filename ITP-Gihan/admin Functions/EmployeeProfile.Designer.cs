namespace AttendanceRecorder
{
    partial class EmployeeProfile
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
            this.pnlMyprofile = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtHome = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNic = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMyattendence = new System.Windows.Forms.Panel();
            this.txtTo = new System.Windows.Forms.DateTimePicker();
            this.txtFrom = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvMyAttendance = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlrequestLeave = new System.Windows.Forms.Panel();
            this.lblShortLeaveDate = new System.Windows.Forms.Label();
            this.txtShortLeaveDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.cmbHalfdayType = new System.Windows.Forms.ComboBox();
            this.lblhalfDayTime = new System.Windows.Forms.Label();
            this.txtDateTo = new System.Windows.Forms.DateTimePicker();
            this.txtDateFrom = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblDatefrom = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRequestLeave = new System.Windows.Forms.Button();
            this.btnMyAttendence = new System.Windows.Forms.Button();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.btnLeaverequest = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMyprofile.SuspendLayout();
            this.pnlMyattendence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyAttendance)).BeginInit();
            this.pnlrequestLeave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMyprofile
            // 
            this.pnlMyprofile.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlMyprofile.Controls.Add(this.btnUpdate);
            this.pnlMyprofile.Controls.Add(this.btnChangePassword);
            this.pnlMyprofile.Controls.Add(this.txtHome);
            this.pnlMyprofile.Controls.Add(this.txtMobile);
            this.pnlMyprofile.Controls.Add(this.txtAddress);
            this.pnlMyprofile.Controls.Add(this.txtNic);
            this.pnlMyprofile.Controls.Add(this.txtName);
            this.pnlMyprofile.Controls.Add(this.txtEmployeeID);
            this.pnlMyprofile.Controls.Add(this.pictureBox1);
            this.pnlMyprofile.Controls.Add(this.label7);
            this.pnlMyprofile.Controls.Add(this.label6);
            this.pnlMyprofile.Controls.Add(this.label5);
            this.pnlMyprofile.Controls.Add(this.label4);
            this.pnlMyprofile.Controls.Add(this.label3);
            this.pnlMyprofile.Controls.Add(this.label2);
            this.pnlMyprofile.Controls.Add(this.label1);
            this.pnlMyprofile.Location = new System.Drawing.Point(152, 62);
            this.pnlMyprofile.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMyprofile.Name = "pnlMyprofile";
            this.pnlMyprofile.Size = new System.Drawing.Size(565, 575);
            this.pnlMyprofile.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(174, 412);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(221, 52);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(207, 339);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(190, 26);
            this.btnChangePassword.TabIndex = 24;
            this.btnChangePassword.Text = "Change Login Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click_1);
            // 
            // txtHome
            // 
            this.txtHome.Location = new System.Drawing.Point(207, 303);
            this.txtHome.Margin = new System.Windows.Forms.Padding(2);
            this.txtHome.Name = "txtHome";
            this.txtHome.Size = new System.Drawing.Size(192, 20);
            this.txtHome.TabIndex = 23;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(207, 261);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(2);
            this.txtMobile.MaxLength = 10;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(192, 20);
            this.txtMobile.TabIndex = 22;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(207, 205);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(192, 36);
            this.txtAddress.TabIndex = 21;
            // 
            // txtNic
            // 
            this.txtNic.AutoSize = true;
            this.txtNic.Location = new System.Drawing.Point(204, 159);
            this.txtNic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(35, 13);
            this.txtNic.TabIndex = 20;
            this.txtNic.Text = "label7";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(204, 122);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(35, 13);
            this.txtName.TabIndex = 19;
            this.txtName.Text = "label7";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.AutoSize = true;
            this.txtEmployeeID.Location = new System.Drawing.Point(204, 87);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(35, 13);
            this.txtEmployeeID.TabIndex = 18;
            this.txtEmployeeID.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 346);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 306);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Home Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mobile Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "NIC :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Employee ID : ";
            // 
            // pnlMyattendence
            // 
            this.pnlMyattendence.BackColor = System.Drawing.Color.LightBlue;
            this.pnlMyattendence.Controls.Add(this.btnSearch);
            this.pnlMyattendence.Controls.Add(this.txtTo);
            this.pnlMyattendence.Controls.Add(this.txtFrom);
            this.pnlMyattendence.Controls.Add(this.label10);
            this.pnlMyattendence.Controls.Add(this.label9);
            this.pnlMyattendence.Controls.Add(this.dgvMyAttendance);
            this.pnlMyattendence.Controls.Add(this.label8);
            this.pnlMyattendence.Location = new System.Drawing.Point(154, 63);
            this.pnlMyattendence.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMyattendence.Name = "pnlMyattendence";
            this.pnlMyattendence.Size = new System.Drawing.Size(562, 572);
            this.pnlMyattendence.TabIndex = 13;
            // 
            // txtTo
            // 
            this.txtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTo.Location = new System.Drawing.Point(312, 86);
            this.txtTo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(111, 20);
            this.txtTo.TabIndex = 3;
            // 
            // txtFrom
            // 
            this.txtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFrom.Location = new System.Drawing.Point(113, 86);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(2);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(111, 20);
            this.txtFrom.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(273, 86);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "To";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "From";
            // 
            // dgvMyAttendance
            // 
            this.dgvMyAttendance.AllowUserToAddRows = false;
            this.dgvMyAttendance.AllowUserToDeleteRows = false;
            this.dgvMyAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMyAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyAttendance.Location = new System.Drawing.Point(12, 137);
            this.dgvMyAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMyAttendance.MultiSelect = false;
            this.dgvMyAttendance.Name = "dgvMyAttendance";
            this.dgvMyAttendance.ReadOnly = true;
            this.dgvMyAttendance.RowTemplate.Height = 24;
            this.dgvMyAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyAttendance.Size = new System.Drawing.Size(532, 423);
            this.dgvMyAttendance.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(213, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "My Attendence";
            // 
            // pnlrequestLeave
            // 
            this.pnlrequestLeave.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlrequestLeave.Controls.Add(this.lblShortLeaveDate);
            this.pnlrequestLeave.Controls.Add(this.txtShortLeaveDate);
            this.pnlrequestLeave.Controls.Add(this.btnLeaverequest);
            this.pnlrequestLeave.Controls.Add(this.label11);
            this.pnlrequestLeave.Controls.Add(this.txtReason);
            this.pnlrequestLeave.Controls.Add(this.cmbHalfdayType);
            this.pnlrequestLeave.Controls.Add(this.lblhalfDayTime);
            this.pnlrequestLeave.Controls.Add(this.txtDateTo);
            this.pnlrequestLeave.Controls.Add(this.txtDateFrom);
            this.pnlrequestLeave.Controls.Add(this.comboBox1);
            this.pnlrequestLeave.Controls.Add(this.label12);
            this.pnlrequestLeave.Controls.Add(this.lblDateTo);
            this.pnlrequestLeave.Controls.Add(this.lblDatefrom);
            this.pnlrequestLeave.Location = new System.Drawing.Point(153, 64);
            this.pnlrequestLeave.Margin = new System.Windows.Forms.Padding(2);
            this.pnlrequestLeave.Name = "pnlrequestLeave";
            this.pnlrequestLeave.Size = new System.Drawing.Size(565, 569);
            this.pnlrequestLeave.TabIndex = 15;
            this.pnlrequestLeave.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlrequestLeave_Paint);
            // 
            // lblShortLeaveDate
            // 
            this.lblShortLeaveDate.AutoSize = true;
            this.lblShortLeaveDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortLeaveDate.Location = new System.Drawing.Point(69, 76);
            this.lblShortLeaveDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShortLeaveDate.Name = "lblShortLeaveDate";
            this.lblShortLeaveDate.Size = new System.Drawing.Size(37, 13);
            this.lblShortLeaveDate.TabIndex = 9;
            this.lblShortLeaveDate.Text = "Date";
            // 
            // txtShortLeaveDate
            // 
            this.txtShortLeaveDate.Location = new System.Drawing.Point(154, 76);
            this.txtShortLeaveDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtShortLeaveDate.Name = "txtShortLeaveDate";
            this.txtShortLeaveDate.Size = new System.Drawing.Size(272, 20);
            this.txtShortLeaveDate.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 205);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Reason";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(154, 205);
            this.txtReason.Margin = new System.Windows.Forms.Padding(2);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(272, 74);
            this.txtReason.TabIndex = 5;
            // 
            // cmbHalfdayType
            // 
            this.cmbHalfdayType.FormattingEnabled = true;
            this.cmbHalfdayType.Items.AddRange(new object[] {
            "Morning",
            "Afternoon"});
            this.cmbHalfdayType.Location = new System.Drawing.Point(236, 145);
            this.cmbHalfdayType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHalfdayType.Name = "cmbHalfdayType";
            this.cmbHalfdayType.Size = new System.Drawing.Size(92, 21);
            this.cmbHalfdayType.TabIndex = 4;
            // 
            // lblhalfDayTime
            // 
            this.lblhalfDayTime.AutoSize = true;
            this.lblhalfDayTime.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhalfDayTime.Location = new System.Drawing.Point(133, 148);
            this.lblhalfDayTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhalfDayTime.Name = "lblhalfDayTime";
            this.lblhalfDayTime.Size = new System.Drawing.Size(93, 13);
            this.lblhalfDayTime.TabIndex = 3;
            this.lblhalfDayTime.Text = "Halfday Time";
            // 
            // txtDateTo
            // 
            this.txtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateTo.Location = new System.Drawing.Point(304, 104);
            this.txtDateTo.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(102, 20);
            this.txtDateTo.TabIndex = 2;
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateFrom.Location = new System.Drawing.Point(154, 105);
            this.txtDateFrom.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(102, 20);
            this.txtDateFrom.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Casual Leave 1+ days",
            "Casual Leave One Day",
            "Half Day",
            "Medical Leave",
            "Short Leave"});
            this.comboBox1.Location = new System.Drawing.Point(154, 45);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(51, 45);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Leave type";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTo.Location = new System.Drawing.Point(265, 104);
            this.lblDateTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(23, 13);
            this.lblDateTo.TabIndex = 0;
            this.lblDateTo.Text = "To";
            // 
            // lblDatefrom
            // 
            this.lblDatefrom.AutoSize = true;
            this.lblDatefrom.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatefrom.Location = new System.Drawing.Point(70, 106);
            this.lblDatefrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatefrom.Name = "lblDatefrom";
            this.lblDatefrom.Size = new System.Drawing.Size(37, 13);
            this.lblDatefrom.TabIndex = 0;
            this.lblDatefrom.Text = "Date";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.Image = global::AttendanceRecorder.Properties.Resources.icnBack;
            this.btnBack.Location = new System.Drawing.Point(4, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 34);
            this.btnBack.TabIndex = 16;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRequestLeave
            // 
            this.btnRequestLeave.BackColor = System.Drawing.Color.DimGray;
            this.btnRequestLeave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestLeave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRequestLeave.Image = global::AttendanceRecorder.Properties.Resources.icnLeave;
            this.btnRequestLeave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequestLeave.Location = new System.Drawing.Point(4, 244);
            this.btnRequestLeave.Margin = new System.Windows.Forms.Padding(2);
            this.btnRequestLeave.Name = "btnRequestLeave";
            this.btnRequestLeave.Size = new System.Drawing.Size(144, 64);
            this.btnRequestLeave.TabIndex = 14;
            this.btnRequestLeave.Text = "Leave Request";
            this.btnRequestLeave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRequestLeave.UseVisualStyleBackColor = false;
            this.btnRequestLeave.Click += new System.EventHandler(this.btnRequestLeave_Click);
            // 
            // btnMyAttendence
            // 
            this.btnMyAttendence.BackColor = System.Drawing.Color.DimGray;
            this.btnMyAttendence.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyAttendence.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMyAttendence.Image = global::AttendanceRecorder.Properties.Resources.icnAttendance;
            this.btnMyAttendence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyAttendence.Location = new System.Drawing.Point(4, 149);
            this.btnMyAttendence.Margin = new System.Windows.Forms.Padding(2);
            this.btnMyAttendence.Name = "btnMyAttendence";
            this.btnMyAttendence.Size = new System.Drawing.Size(144, 69);
            this.btnMyAttendence.TabIndex = 14;
            this.btnMyAttendence.Text = "My Attendence";
            this.btnMyAttendence.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMyAttendence.UseVisualStyleBackColor = false;
            this.btnMyAttendence.Click += new System.EventHandler(this.btnMyAttendence_Click);
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.BackColor = System.Drawing.Color.DimGray;
            this.btnMyProfile.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMyProfile.Image = global::AttendanceRecorder.Properties.Resources.icons8_user_filled_25;
            this.btnMyProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyProfile.Location = new System.Drawing.Point(4, 63);
            this.btnMyProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(145, 65);
            this.btnMyProfile.TabIndex = 12;
            this.btnMyProfile.Text = "My Profile";
            this.btnMyProfile.UseVisualStyleBackColor = false;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // btnLeaverequest
            // 
            this.btnLeaverequest.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLeaverequest.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaverequest.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLeaverequest.Image = global::AttendanceRecorder.Properties.Resources.icnOkay;
            this.btnLeaverequest.Location = new System.Drawing.Point(193, 301);
            this.btnLeaverequest.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeaverequest.Name = "btnLeaverequest";
            this.btnLeaverequest.Size = new System.Drawing.Size(178, 77);
            this.btnLeaverequest.TabIndex = 7;
            this.btnLeaverequest.Text = "Request";
            this.btnLeaverequest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLeaverequest.UseVisualStyleBackColor = false;
            this.btnLeaverequest.Click += new System.EventHandler(this.btnLeaverequest_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::AttendanceRecorder.Properties.Resources.icons8_google_web_search_241;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(438, 82);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 32);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(422, 87);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(731, 653);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRequestLeave);
            this.Controls.Add(this.btnMyAttendence);
            this.Controls.Add(this.btnMyProfile);
            this.Controls.Add(this.pnlMyprofile);
            this.Controls.Add(this.pnlrequestLeave);
            this.Controls.Add(this.pnlMyattendence);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeProfile";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "My Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeProfile_FormClosing);
            this.Load += new System.EventHandler(this.EmployeeProfile_Load);
            this.pnlMyprofile.ResumeLayout(false);
            this.pnlMyprofile.PerformLayout();
            this.pnlMyattendence.ResumeLayout(false);
            this.pnlMyattendence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyAttendance)).EndInit();
            this.pnlrequestLeave.ResumeLayout(false);
            this.pnlrequestLeave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMyprofile;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txtHome;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label txtNic;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtEmployeeID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Panel pnlMyattendence;
        private System.Windows.Forms.DataGridView dgvMyAttendance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMyAttendence;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker txtTo;
        private System.Windows.Forms.DateTimePicker txtFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRequestLeave;
        private System.Windows.Forms.Panel pnlrequestLeave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDatefrom;
        private System.Windows.Forms.DateTimePicker txtDateTo;
        private System.Windows.Forms.DateTimePicker txtDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.ComboBox cmbHalfdayType;
        private System.Windows.Forms.Label lblhalfDayTime;
        private System.Windows.Forms.Button btnLeaverequest;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblShortLeaveDate;
        private System.Windows.Forms.DateTimePicker txtShortLeaveDate;
        private System.Windows.Forms.Button btnBack;
    }
}