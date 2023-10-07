namespace StudentInfo
{
    partial class StudentInfoDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInfoDetails));
            this.studentInfoDataSet = new StudentInfo.StudentInfoDataSet();
            this.studentInfoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.dataGrid_DispRec = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGpa = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLogin_One = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLogin2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.dataGrid_Display2 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentInfoDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnDisplay2 = new System.Windows.Forms.Button();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.studentInfoDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DispRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Display2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentInfoDataSet
            // 
            this.studentInfoDataSet.DataSetName = "StudentInfoDataSet";
            this.studentInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInfoDataSetBindingSource
            // 
            this.studentInfoDataSetBindingSource.DataSource = this.studentInfoDataSet;
            this.studentInfoDataSetBindingSource.Position = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.IndianRed;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(246, 376);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(97, 34);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(382, 376);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 34);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(512, 376);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(757, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(97, 34);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.IndianRed;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(685, 447);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 34);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Brown;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(357, 684);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(150, 34);
            this.btnDisplay.TabIndex = 5;
            this.btnDisplay.Text = "Display Records";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // dataGrid_DispRec
            // 
            this.dataGrid_DispRec.AutoGenerateColumns = false;
            this.dataGrid_DispRec.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGrid_DispRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_DispRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.majorDataGridViewTextBoxColumn1,
            this.gPADataGridViewTextBoxColumn1});
            this.dataGrid_DispRec.DataMember = "StudentInfo";
            this.dataGrid_DispRec.DataSource = this.studentInfoDataSetBindingSource;
            this.dataGrid_DispRec.Location = new System.Drawing.Point(152, 500);
            this.dataGrid_DispRec.Name = "dataGrid_DispRec";
            this.dataGrid_DispRec.RowHeadersWidth = 51;
            this.dataGrid_DispRec.Size = new System.Drawing.Size(553, 161);
            this.dataGrid_DispRec.TabIndex = 6;
            this.dataGrid_DispRec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_DispRec_CellContentClick);
            // 
            // studentIDDataGridViewTextBoxColumn1
            // 
            this.studentIDDataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn1.Name = "studentIDDataGridViewTextBoxColumn1";
            this.studentIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // majorDataGridViewTextBoxColumn1
            // 
            this.majorDataGridViewTextBoxColumn1.DataPropertyName = "Major";
            this.majorDataGridViewTextBoxColumn1.HeaderText = "Major";
            this.majorDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.majorDataGridViewTextBoxColumn1.Name = "majorDataGridViewTextBoxColumn1";
            this.majorDataGridViewTextBoxColumn1.Width = 125;
            // 
            // gPADataGridViewTextBoxColumn1
            // 
            this.gPADataGridViewTextBoxColumn1.DataPropertyName = "GPA";
            this.gPADataGridViewTextBoxColumn1.HeaderText = "GPA";
            this.gPADataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.gPADataGridViewTextBoxColumn1.Name = "gPADataGridViewTextBoxColumn1";
            this.gPADataGridViewTextBoxColumn1.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Major";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "GPA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGpa
            // 
            this.txtGpa.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGpa.Location = new System.Drawing.Point(183, 312);
            this.txtGpa.Multiline = true;
            this.txtGpa.Name = "txtGpa";
            this.txtGpa.Size = new System.Drawing.Size(483, 28);
            this.txtGpa.TabIndex = 12;
            // 
            // txtMajor
            // 
            this.txtMajor.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMajor.Location = new System.Drawing.Point(183, 261);
            this.txtMajor.Multiline = true;
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(483, 28);
            this.txtMajor.TabIndex = 13;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(183, 208);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(483, 28);
            this.txtLastName.TabIndex = 14;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(183, 155);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(483, 29);
            this.txtFirstName.TabIndex = 15;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(183, 105);
            this.txtStudentID.Multiline = true;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(483, 29);
            this.txtStudentID.TabIndex = 16;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(183, 447);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(483, 33);
            this.txtSearch.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(402, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Student Information";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(131, 447);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 34);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(335, 730);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "DoreenChirwa, Inc. Dunwoody College\r\n";
            // 
            // btnLogin_One
            // 
            this.btnLogin_One.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogin_One.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin_One.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin_One.Location = new System.Drawing.Point(641, 12);
            this.btnLogin_One.Name = "btnLogin_One";
            this.btnLogin_One.Size = new System.Drawing.Size(97, 34);
            this.btnLogin_One.TabIndex = 22;
            this.btnLogin_One.Text = "Login";
            this.btnLogin_One.UseVisualStyleBackColor = false;
            this.btnLogin_One.Click += new System.EventHandler(this.btnLogin_One_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnExit);
            this.pnlLogin.Controls.Add(this.label10);
            this.pnlLogin.Controls.Add(this.btnLogin2);
            this.pnlLogin.Controls.Add(this.label8);
            this.pnlLogin.Controls.Add(this.pictureBox3);
            this.pnlLogin.Controls.Add(this.label9);
            this.pnlLogin.Controls.Add(this.pictureBox4);
            this.pnlLogin.Controls.Add(this.txtSearch2);
            this.pnlLogin.Controls.Add(this.dataGrid_Display2);
            this.pnlLogin.Controls.Add(this.btnDisplay2);
            this.pnlLogin.Controls.Add(this.btnSearch2);
            this.pnlLogin.Location = new System.Drawing.Point(-1, -1);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(909, 780);
            this.pnlLogin.TabIndex = 23;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(367, 602);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 34);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(309, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 15);
            this.label10.TabIndex = 46;
            this.label10.Text = "You must login to modify student records.";
            // 
            // btnLogin2
            // 
            this.btnLogin2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogin2.FlatAppearance.BorderSize = 0;
            this.btnLogin2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin2.Location = new System.Drawing.Point(247, 524);
            this.btnLogin2.Name = "btnLogin2";
            this.btnLogin2.Size = new System.Drawing.Size(172, 34);
            this.btnLogin2.TabIndex = 45;
            this.btnLogin2.Text = "Login";
            this.btnLogin2.UseVisualStyleBackColor = false;
            this.btnLogin2.Click += new System.EventHandler(this.btnLogin2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(336, 571);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 12);
            this.label8.TabIndex = 44;
            this.label8.Text = "DoreenChirwa, Inc. Dunwoody College\r\n";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(132, 262);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 34);
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(334, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 18);
            this.label9.TabIndex = 42;
            this.label9.Text = "Student Information";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(403, 128);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // txtSearch2
            // 
            this.txtSearch2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch2.Location = new System.Drawing.Point(184, 262);
            this.txtSearch2.Multiline = true;
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(483, 33);
            this.txtSearch2.TabIndex = 40;
            // 
            // dataGrid_Display2
            // 
            this.dataGrid_Display2.AutoGenerateColumns = false;
            this.dataGrid_Display2.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGrid_Display2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Display2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.majorDataGridViewTextBoxColumn,
            this.gPADataGridViewTextBoxColumn});
            this.dataGrid_Display2.DataMember = "StudentInfo";
            this.dataGrid_Display2.DataSource = this.studentInfoDataSetBindingSource2;
            this.dataGrid_Display2.Location = new System.Drawing.Point(153, 334);
            this.dataGrid_Display2.Name = "dataGrid_Display2";
            this.dataGrid_Display2.RowHeadersWidth = 51;
            this.dataGrid_Display2.Size = new System.Drawing.Size(553, 161);
            this.dataGrid_Display2.TabIndex = 29;
            this.dataGrid_Display2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Display2_CellContentClick);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // majorDataGridViewTextBoxColumn
            // 
            this.majorDataGridViewTextBoxColumn.DataPropertyName = "Major";
            this.majorDataGridViewTextBoxColumn.HeaderText = "Major";
            this.majorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            this.majorDataGridViewTextBoxColumn.Width = 125;
            // 
            // gPADataGridViewTextBoxColumn
            // 
            this.gPADataGridViewTextBoxColumn.DataPropertyName = "GPA";
            this.gPADataGridViewTextBoxColumn.HeaderText = "GPA";
            this.gPADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gPADataGridViewTextBoxColumn.Name = "gPADataGridViewTextBoxColumn";
            this.gPADataGridViewTextBoxColumn.Width = 125;
            // 
            // studentInfoDataSetBindingSource2
            // 
            this.studentInfoDataSetBindingSource2.DataSource = this.studentInfoDataSet;
            this.studentInfoDataSetBindingSource2.Position = 0;
            // 
            // btnDisplay2
            // 
            this.btnDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDisplay2.FlatAppearance.BorderSize = 0;
            this.btnDisplay2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay2.Location = new System.Drawing.Point(452, 524);
            this.btnDisplay2.Name = "btnDisplay2";
            this.btnDisplay2.Size = new System.Drawing.Size(172, 34);
            this.btnDisplay2.TabIndex = 28;
            this.btnDisplay2.Text = "Display Records";
            this.btnDisplay2.UseVisualStyleBackColor = false;
            this.btnDisplay2.Click += new System.EventHandler(this.btnDisplay2_Click);
            // 
            // btnSearch2
            // 
            this.btnSearch2.BackColor = System.Drawing.Color.IndianRed;
            this.btnSearch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch2.Location = new System.Drawing.Point(698, 262);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(97, 34);
            this.btnSearch2.TabIndex = 27;
            this.btnSearch2.Text = "Search";
            this.btnSearch2.UseVisualStyleBackColor = false;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click_1);
            // 
            // studentInfoDataSetBindingSource1
            // 
            this.studentInfoDataSetBindingSource1.DataSource = this.studentInfoDataSet;
            this.studentInfoDataSetBindingSource1.Position = 0;
            // 
            // StudentInfoDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(902, 734);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.btnLogin_One);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.txtGpa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_DispRec);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Name = "StudentInfoDetails";
            this.Text = "StudentInfo";
            this.Load += new System.EventHandler(this.StudentInfoDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DispRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Display2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentInfoDataSet studentInfoDataSet;
        private System.Windows.Forms.BindingSource studentInfoDataSetBindingSource;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.DataGridView dataGrid_DispRec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGpa;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLogin_One;
        private System.Windows.Forms.Button btnLogin2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtSearch2;
        private System.Windows.Forms.DataGridView dataGrid_Display2;
        private System.Windows.Forms.Button btnDisplay2;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.BindingSource studentInfoDataSetBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPADataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentInfoDataSetBindingSource2;
        private System.Windows.Forms.Button btnExit;
    }
}