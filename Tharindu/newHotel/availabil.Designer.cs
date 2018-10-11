namespace AttendanceRecorder
{
    partial class availabil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCustomerdetails = new System.Windows.Forms.Panel();
            this.txtNICR = new System.Windows.Forms.Label();
            this.btnCleardgr = new System.Windows.Forms.Button();
            this.btnDeletedgr = new System.Windows.Forms.Button();
            this.dgvCustomerDetails = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearchroom = new System.Windows.Forms.Button();
            this.txtroomSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUpdateform = new System.Windows.Forms.Label();
            this.pnlHalldetails = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeletehall = new System.Windows.Forms.Button();
            this.txtNICR1 = new System.Windows.Forms.Label();
            this.dgvHallDetails = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.btnHallSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchhall = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHalldetails = new System.Windows.Forms.Label();
            this.pnlCheckAvailability = new System.Windows.Forms.Panel();
            this.btnCheck1 = new System.Windows.Forms.Button();
            this.cmbPackage = new System.Windows.Forms.ComboBox();
            this.dgvCheckAvailability = new System.Windows.Forms.DataGridView();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.btnViewall = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblsearchname = new System.Windows.Forms.Label();
            this.txtsearchitem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkout2 = new System.Windows.Forms.DateTimePicker();
            this.chkin1 = new System.Windows.Forms.DateTimePicker();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.lblCheckin = new System.Windows.Forms.Label();
            this.hotelDataSet1 = new AttendanceRecorder.hotelDataSet1();
            this.hotelDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hallbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hallbookTableAdapter = new AttendanceRecorder.hotelDataSet1TableAdapters.hallbookTableAdapter();
            this.pnlCustomerdetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).BeginInit();
            this.pnlHalldetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHallDetails)).BeginInit();
            this.pnlCheckAvailability.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckAvailability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallbookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCustomerdetails
            // 
            this.pnlCustomerdetails.Controls.Add(this.txtNICR);
            this.pnlCustomerdetails.Controls.Add(this.btnCleardgr);
            this.pnlCustomerdetails.Controls.Add(this.btnDeletedgr);
            this.pnlCustomerdetails.Controls.Add(this.dgvCustomerDetails);
            this.pnlCustomerdetails.Controls.Add(this.button1);
            this.pnlCustomerdetails.Controls.Add(this.btnSearchroom);
            this.pnlCustomerdetails.Controls.Add(this.txtroomSearch);
            this.pnlCustomerdetails.Controls.Add(this.label3);
            this.pnlCustomerdetails.Controls.Add(this.lblUpdateform);
            this.pnlCustomerdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCustomerdetails.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomerdetails.Name = "pnlCustomerdetails";
            this.pnlCustomerdetails.Size = new System.Drawing.Size(1254, 903);
            this.pnlCustomerdetails.TabIndex = 83;
            this.pnlCustomerdetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCustomerdetails_Paint);
            // 
            // txtNICR
            // 
            this.txtNICR.AutoSize = true;
            this.txtNICR.Location = new System.Drawing.Point(3, 2);
            this.txtNICR.Name = "txtNICR";
            this.txtNICR.Size = new System.Drawing.Size(22, 25);
            this.txtNICR.TabIndex = 94;
            this.txtNICR.Text = "||";
            this.txtNICR.Visible = false;
            // 
            // btnCleardgr
            // 
            this.btnCleardgr.Location = new System.Drawing.Point(506, 112);
            this.btnCleardgr.Name = "btnCleardgr";
            this.btnCleardgr.Size = new System.Drawing.Size(161, 37);
            this.btnCleardgr.TabIndex = 93;
            this.btnCleardgr.Text = "Clear";
            this.btnCleardgr.UseVisualStyleBackColor = true;
            this.btnCleardgr.Click += new System.EventHandler(this.btnCleardgr_Click);
            // 
            // btnDeletedgr
            // 
            this.btnDeletedgr.Location = new System.Drawing.Point(237, 112);
            this.btnDeletedgr.Name = "btnDeletedgr";
            this.btnDeletedgr.Size = new System.Drawing.Size(161, 37);
            this.btnDeletedgr.TabIndex = 92;
            this.btnDeletedgr.Text = "Delete";
            this.btnDeletedgr.UseVisualStyleBackColor = true;
            this.btnDeletedgr.Click += new System.EventHandler(this.btnDeletedgr_Click);
            // 
            // dgvCustomerDetails
            // 
            this.dgvCustomerDetails.AllowUserToAddRows = false;
            this.dgvCustomerDetails.AllowUserToDeleteRows = false;
            this.dgvCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerDetails.Location = new System.Drawing.Point(110, 276);
            this.dgvCustomerDetails.Name = "dgvCustomerDetails";
            this.dgvCustomerDetails.ReadOnly = true;
            this.dgvCustomerDetails.RowTemplate.Height = 24;
            this.dgvCustomerDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerDetails.Size = new System.Drawing.Size(989, 531);
            this.dgvCustomerDetails.TabIndex = 91;
            this.dgvCustomerDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            this.dgvCustomerDetails.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvCustomerDetails_MouseClick);
            this.dgvCustomerDetails.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvCustomerDetails_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 37);
            this.button1.TabIndex = 90;
            this.button1.Text = "View All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnSearchroom
            // 
            this.btnSearchroom.Location = new System.Drawing.Point(578, 173);
            this.btnSearchroom.Name = "btnSearchroom";
            this.btnSearchroom.Size = new System.Drawing.Size(161, 37);
            this.btnSearchroom.TabIndex = 89;
            this.btnSearchroom.Text = "Search";
            this.btnSearchroom.UseVisualStyleBackColor = true;
            this.btnSearchroom.Click += new System.EventHandler(this.btnSearchroom_Click);
            // 
            // txtroomSearch
            // 
            this.txtroomSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtroomSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtroomSearch.Location = new System.Drawing.Point(237, 175);
            this.txtroomSearch.Name = "txtroomSearch";
            this.txtroomSearch.Size = new System.Drawing.Size(280, 30);
            this.txtroomSearch.TabIndex = 87;
            this.txtroomSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtroomSearch_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 83;
            // 
            // lblUpdateform
            // 
            this.lblUpdateform.AutoSize = true;
            this.lblUpdateform.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateform.Location = new System.Drawing.Point(464, 23);
            this.lblUpdateform.Name = "lblUpdateform";
            this.lblUpdateform.Size = new System.Drawing.Size(284, 29);
            this.lblUpdateform.TabIndex = 0;
            this.lblUpdateform.Text = "Customer Details (Room)";
            // 
            // pnlHalldetails
            // 
            this.pnlHalldetails.Controls.Add(this.button2);
            this.pnlHalldetails.Controls.Add(this.btnDeletehall);
            this.pnlHalldetails.Controls.Add(this.txtNICR1);
            this.pnlHalldetails.Controls.Add(this.dgvHallDetails);
            this.pnlHalldetails.Controls.Add(this.button3);
            this.pnlHalldetails.Controls.Add(this.btnHallSearch);
            this.pnlHalldetails.Controls.Add(this.label4);
            this.pnlHalldetails.Controls.Add(this.txtSearchhall);
            this.pnlHalldetails.Controls.Add(this.label6);
            this.pnlHalldetails.Controls.Add(this.lblHalldetails);
            this.pnlHalldetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHalldetails.Location = new System.Drawing.Point(1, 2);
            this.pnlHalldetails.Name = "pnlHalldetails";
            this.pnlHalldetails.Size = new System.Drawing.Size(1256, 906);
            this.pnlHalldetails.TabIndex = 92;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(505, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 33);
            this.button2.TabIndex = 104;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeletehall
            // 
            this.btnDeletehall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletehall.Location = new System.Drawing.Point(260, 71);
            this.btnDeletehall.Name = "btnDeletehall";
            this.btnDeletehall.Size = new System.Drawing.Size(225, 32);
            this.btnDeletehall.TabIndex = 103;
            this.btnDeletehall.Text = "delete";
            this.btnDeletehall.UseVisualStyleBackColor = true;
            this.btnDeletehall.Click += new System.EventHandler(this.btnDeletehall_Click);
            // 
            // txtNICR1
            // 
            this.txtNICR1.AutoSize = true;
            this.txtNICR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNICR1.Location = new System.Drawing.Point(2, 0);
            this.txtNICR1.Name = "txtNICR1";
            this.txtNICR1.Size = new System.Drawing.Size(17, 25);
            this.txtNICR1.TabIndex = 100;
            this.txtNICR1.Text = "|";
            this.txtNICR1.Visible = false;
            // 
            // dgvHallDetails
            // 
            this.dgvHallDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHallDetails.Location = new System.Drawing.Point(178, 236);
            this.dgvHallDetails.Name = "dgvHallDetails";
            this.dgvHallDetails.RowTemplate.Height = 24;
            this.dgvHallDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHallDetails.Size = new System.Drawing.Size(876, 597);
            this.dgvHallDetails.TabIndex = 99;
            this.dgvHallDetails.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvHallDetails_MouseClick);
            this.dgvHallDetails.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvHallDetails_MouseDoubleClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(713, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 32);
            this.button3.TabIndex = 98;
            this.button3.Text = "View All";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnHallSearch
            // 
            this.btnHallSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHallSearch.Location = new System.Drawing.Point(713, 140);
            this.btnHallSearch.Name = "btnHallSearch";
            this.btnHallSearch.Size = new System.Drawing.Size(225, 30);
            this.btnHallSearch.TabIndex = 97;
            this.btnHallSearch.Text = "Search";
            this.btnHallSearch.UseVisualStyleBackColor = true;
            this.btnHallSearch.Click += new System.EventHandler(this.btnHallSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 96;
            this.label4.Text = "Search";
            // 
            // txtSearchhall
            // 
            this.txtSearchhall.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearchhall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchhall.Location = new System.Drawing.Point(353, 140);
            this.txtSearchhall.Name = "txtSearchhall";
            this.txtSearchhall.Size = new System.Drawing.Size(335, 30);
            this.txtSearchhall.TabIndex = 95;
            this.txtSearchhall.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txthallSearch_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(688, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 92;
            // 
            // lblHalldetails
            // 
            this.lblHalldetails.AutoSize = true;
            this.lblHalldetails.Location = new System.Drawing.Point(491, 23);
            this.lblHalldetails.Name = "lblHalldetails";
            this.lblHalldetails.Size = new System.Drawing.Size(208, 25);
            this.lblHalldetails.TabIndex = 0;
            this.lblHalldetails.Text = "Customer Details(Hall)";
            // 
            // pnlCheckAvailability
            // 
            this.pnlCheckAvailability.Controls.Add(this.btnCheck1);
            this.pnlCheckAvailability.Controls.Add(this.cmbPackage);
            this.pnlCheckAvailability.Controls.Add(this.dgvCheckAvailability);
            this.pnlCheckAvailability.Controls.Add(this.lblAvailability);
            this.pnlCheckAvailability.Controls.Add(this.btnViewall);
            this.pnlCheckAvailability.Controls.Add(this.btnSearch);
            this.pnlCheckAvailability.Controls.Add(this.lblsearchname);
            this.pnlCheckAvailability.Controls.Add(this.txtsearchitem);
            this.pnlCheckAvailability.Controls.Add(this.label9);
            this.pnlCheckAvailability.Controls.Add(this.chkout2);
            this.pnlCheckAvailability.Controls.Add(this.chkin1);
            this.pnlCheckAvailability.Controls.Add(this.lblCheckout);
            this.pnlCheckAvailability.Controls.Add(this.lblCheckin);
            this.pnlCheckAvailability.Location = new System.Drawing.Point(2, 0);
            this.pnlCheckAvailability.Name = "pnlCheckAvailability";
            this.pnlCheckAvailability.Size = new System.Drawing.Size(1253, 903);
            this.pnlCheckAvailability.TabIndex = 92;
            this.pnlCheckAvailability.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCheckAvailability_Paint);
            // 
            // btnCheck1
            // 
            this.btnCheck1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck1.Location = new System.Drawing.Point(1050, 121);
            this.btnCheck1.Name = "btnCheck1";
            this.btnCheck1.Size = new System.Drawing.Size(170, 64);
            this.btnCheck1.TabIndex = 99;
            this.btnCheck1.Text = " Check Availability";
            this.btnCheck1.UseVisualStyleBackColor = true;
            this.btnCheck1.Click += new System.EventHandler(this.btnCheck1_Click);
            // 
            // cmbPackage
            // 
            this.cmbPackage.FormattingEnabled = true;
            this.cmbPackage.Items.AddRange(new object[] {
            "Room",
            "Hall"});
            this.cmbPackage.Location = new System.Drawing.Point(842, 120);
            this.cmbPackage.Name = "cmbPackage";
            this.cmbPackage.Size = new System.Drawing.Size(180, 24);
            this.cmbPackage.TabIndex = 98;
            // 
            // dgvCheckAvailability
            // 
            this.dgvCheckAvailability.AllowUserToAddRows = false;
            this.dgvCheckAvailability.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dgvCheckAvailability.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCheckAvailability.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheckAvailability.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCheckAvailability.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckAvailability.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCheckAvailability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckAvailability.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCheckAvailability.Location = new System.Drawing.Point(64, 341);
            this.dgvCheckAvailability.Name = "dgvCheckAvailability";
            this.dgvCheckAvailability.ReadOnly = true;
            this.dgvCheckAvailability.RowHeadersVisible = false;
            this.dgvCheckAvailability.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvCheckAvailability.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCheckAvailability.RowTemplate.Height = 24;
            this.dgvCheckAvailability.Size = new System.Drawing.Size(1132, 433);
            this.dgvCheckAvailability.TabIndex = 97;
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailability.Location = new System.Drawing.Point(560, 27);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(184, 25);
            this.lblAvailability.TabIndex = 95;
            this.lblAvailability.Text = "Check Availability";
            // 
            // btnViewall
            // 
            this.btnViewall.Location = new System.Drawing.Point(842, 163);
            this.btnViewall.Name = "btnViewall";
            this.btnViewall.Size = new System.Drawing.Size(181, 25);
            this.btnViewall.TabIndex = 94;
            this.btnViewall.Text = "View All";
            this.btnViewall.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(552, 160);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(270, 25);
            this.btnSearch.TabIndex = 93;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblsearchname
            // 
            this.lblsearchname.AutoSize = true;
            this.lblsearchname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchname.Location = new System.Drawing.Point(57, 167);
            this.lblsearchname.Name = "lblsearchname";
            this.lblsearchname.Size = new System.Drawing.Size(62, 20);
            this.lblsearchname.TabIndex = 92;
            this.lblsearchname.Text = "Search";
            // 
            // txtsearchitem
            // 
            this.txtsearchitem.Location = new System.Drawing.Point(159, 163);
            this.txtsearchitem.Name = "txtsearchitem";
            this.txtsearchitem.Size = new System.Drawing.Size(270, 22);
            this.txtsearchitem.TabIndex = 91;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(656, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 87;
            // 
            // chkout2
            // 
            this.chkout2.Location = new System.Drawing.Point(552, 120);
            this.chkout2.Name = "chkout2";
            this.chkout2.Size = new System.Drawing.Size(270, 22);
            this.chkout2.TabIndex = 86;
            // 
            // chkin1
            // 
            this.chkin1.Location = new System.Drawing.Point(159, 122);
            this.chkin1.Name = "chkin1";
            this.chkin1.Size = new System.Drawing.Size(271, 22);
            this.chkin1.TabIndex = 85;
            // 
            // lblCheckout
            // 
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckout.Location = new System.Drawing.Point(448, 125);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(84, 20);
            this.lblCheckout.TabIndex = 83;
            this.lblCheckout.Text = "Check out";
            // 
            // lblCheckin
            // 
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckin.Location = new System.Drawing.Point(57, 121);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(74, 20);
            this.lblCheckin.TabIndex = 84;
            this.lblCheckin.Text = "Check in";
            // 
            // hotelDataSet1
            // 
            this.hotelDataSet1.DataSetName = "hotelDataSet1";
            this.hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelDataSet1BindingSource
            // 
            this.hotelDataSet1BindingSource.DataSource = this.hotelDataSet1;
            this.hotelDataSet1BindingSource.Position = 0;
            // 
            // hallbookBindingSource
            // 
            this.hallbookBindingSource.DataMember = "hallbook";
            this.hallbookBindingSource.DataSource = this.hotelDataSet1;
            // 
            // hallbookTableAdapter
            // 
            this.hallbookTableAdapter.ClearBeforeFill = true;
            // 
            // availabil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1257, 911);
            this.Controls.Add(this.pnlHalldetails);
            this.Controls.Add(this.pnlCustomerdetails);
            this.Controls.Add(this.pnlCheckAvailability);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "availabil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "availabil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.availabil_FormClosing);
            this.Load += new System.EventHandler(this.availabil_Load);
            this.pnlCustomerdetails.ResumeLayout(false);
            this.pnlCustomerdetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).EndInit();
            this.pnlHalldetails.ResumeLayout(false);
            this.pnlHalldetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHallDetails)).EndInit();
            this.pnlCheckAvailability.ResumeLayout(false);
            this.pnlCheckAvailability.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckAvailability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallbookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCustomerdetails;
        private System.Windows.Forms.Label lblUpdateform;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearchroom;
        private System.Windows.Forms.TextBox txtroomSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCustomerDetails;
        private System.Windows.Forms.Panel pnlHalldetails;
        private System.Windows.Forms.Label lblHalldetails;
        private System.Windows.Forms.Panel pnlCheckAvailability;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Button btnViewall;
        private System.Windows.Forms.Label lblsearchname;
        private System.Windows.Forms.TextBox txtsearchitem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker chkout2;
        private System.Windows.Forms.DateTimePicker chkin1;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.Label lblCheckin;
        private System.Windows.Forms.Button btnCleardgr;
        private System.Windows.Forms.Button btnDeletedgr;
        public System.Windows.Forms.Label txtNICR;
        private System.Windows.Forms.Label txtNICR1;
        private System.Windows.Forms.DataGridView dgvCheckAvailability;
        private System.Windows.Forms.ComboBox cmbPackage;
     //   private System.Windows.Forms.Button button5_Click;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCheck1;
        private hotelDataSet1 hotelDataSet1;
        private System.Windows.Forms.BindingSource hotelDataSet1BindingSource;
        private System.Windows.Forms.BindingSource hallbookBindingSource;
        private hotelDataSet1TableAdapters.hallbookTableAdapter hallbookTableAdapter;
        public System.Windows.Forms.DataGridView dgvHallDetails;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button btnHallSearch;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtSearchhall;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnDeletehall;
        private System.Windows.Forms.Button button2;
    }
}