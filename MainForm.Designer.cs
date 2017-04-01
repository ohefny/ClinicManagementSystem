
using System.Windows.Forms;

namespace Clinic_Managment_System__Better_UI_
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
            this.navBar = new System.Windows.Forms.ToolStrip();
            this.bookingBtn = new System.Windows.Forms.ToolStripButton();
            this.patientsBtn = new System.Windows.Forms.ToolStripButton();
            this.doctorsBtn = new System.Windows.Forms.ToolStripButton();
            this.medicinesBtn = new System.Windows.Forms.ToolStripButton();
            this.diseasesBtn = new System.Windows.Forms.ToolStripButton();
            this.symptomsBtn = new System.Windows.Forms.ToolStripButton();
            this.usersBtn = new System.Windows.Forms.ToolStripButton();
            this.logoutBtn = new System.Windows.Forms.ToolStripButton();
            this.exitBtn = new System.Windows.Forms.ToolStripButton();
            this.Header = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addToSymptoms = new System.Windows.Forms.Button();
            this.removeFromSymptoms = new System.Windows.Forms.Button();
            this.symptomsList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SymptomsBox = new System.Windows.Forms.ComboBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addToDiseasesBtn = new System.Windows.Forms.Button();
            this.removeFromListBtn = new System.Windows.Forms.Button();
            this.diseasesList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchRB = new System.Windows.Forms.RadioButton();
            this.addRB = new System.Windows.Forms.RadioButton();
            this.editRB = new System.Windows.Forms.RadioButton();
            this.removeRB = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.diseasesComboBox = new System.Windows.Forms.ComboBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.applyBtn = new System.Windows.Forms.Button();
            this.userInfoPanel = new System.Windows.Forms.Panel();
            this.userJobLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navBar.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.userInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.navBar.AutoSize = false;
            this.navBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.navBar.Dock = System.Windows.Forms.DockStyle.None;
            this.navBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingBtn,
            this.patientsBtn,
            this.doctorsBtn,
            this.medicinesBtn,
            this.diseasesBtn,
            this.symptomsBtn,
            this.usersBtn,
            this.logoutBtn,
            this.exitBtn});
            this.navBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.navBar.Location = new System.Drawing.Point(0, 63);
            this.navBar.Name = "navBar";
            this.navBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.navBar.Size = new System.Drawing.Size(231, 653);
            this.navBar.TabIndex = 32;
            this.navBar.Text = "toolStrip1";
            this.navBar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // bookingBtn
            // 
            this.bookingBtn.AutoSize = false;
            this.bookingBtn.BackgroundImage = global::Clinic_Managment_System__Better_UI_.Properties.Resources.Booking;
            this.bookingBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookingBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bookingBtn.Name = "bookingBtn";
            this.bookingBtn.Size = new System.Drawing.Size(230, 60);
            this.bookingBtn.Text = "Booking";
            // 
            // patientsBtn
            // 
            this.patientsBtn.AutoSize = false;
            this.patientsBtn.BackgroundImage = global::Clinic_Managment_System__Better_UI_.Properties.Resources.patients;
            this.patientsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.patientsBtn.Name = "patientsBtn";
            this.patientsBtn.Size = new System.Drawing.Size(230, 60);
            this.patientsBtn.Text = "Patients";
            this.patientsBtn.Click += new System.EventHandler(this.patientsBtn_Click);
            // 
            // doctorsBtn
            // 
            this.doctorsBtn.AutoSize = false;
            this.doctorsBtn.BackgroundImage = global::Clinic_Managment_System__Better_UI_.Properties.Resources.doctors;
            this.doctorsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.doctorsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.doctorsBtn.Name = "doctorsBtn";
            this.doctorsBtn.Size = new System.Drawing.Size(230, 60);
            this.doctorsBtn.Text = "Doctors";
            this.doctorsBtn.Click += new System.EventHandler(this.doctorsBtn_Click);
            // 
            // medicinesBtn
            // 
            this.medicinesBtn.AutoSize = false;
            this.medicinesBtn.BackgroundImage = global::Clinic_Managment_System__Better_UI_.Properties.Resources.drugs;
            this.medicinesBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medicinesBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.medicinesBtn.Name = "medicinesBtn";
            this.medicinesBtn.Size = new System.Drawing.Size(230, 60);
            this.medicinesBtn.Text = "Medicines";
            this.medicinesBtn.Click += new System.EventHandler(this.medicinesBtn_Click);
            // 
            // diseasesBtn
            // 
            this.diseasesBtn.AutoSize = false;
            this.diseasesBtn.BackgroundImage = global::Clinic_Managment_System__Better_UI_.Properties.Resources.diseases;
            this.diseasesBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.diseasesBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.diseasesBtn.Name = "diseasesBtn";
            this.diseasesBtn.Size = new System.Drawing.Size(230, 60);
            this.diseasesBtn.Text = "Diseases";
            this.diseasesBtn.Click += new System.EventHandler(this.diseasesBtn_Click);
            // 
            // symptomsBtn
            // 
            this.symptomsBtn.AutoSize = false;
            this.symptomsBtn.BackgroundImage = global::Clinic_Managment_System__Better_UI_.Properties.Resources.Symptoms;
            this.symptomsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.symptomsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.symptomsBtn.Name = "symptomsBtn";
            this.symptomsBtn.Size = new System.Drawing.Size(230, 60);
            this.symptomsBtn.Text = "Symptoms";
            this.symptomsBtn.Click += new System.EventHandler(this.symptomsBtn_Click);
            // 
            // usersBtn
            // 
            this.usersBtn.AutoSize = false;
            this.usersBtn.BackgroundImage = global::Clinic_Managment_System__Better_UI_.Properties.Resources.usersbg;
            this.usersBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usersBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(230, 60);
            this.usersBtn.Text = "Users";
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.AutoSize = false;
            this.logoutBtn.BackgroundImage = global::Clinic_Managment_System__Better_UI_.Properties.Resources.logout;
            this.logoutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.logoutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(230, 60);
            this.logoutBtn.Text = "Log Out";
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = false;
            this.exitBtn.BackgroundImage = global::Clinic_Managment_System__Better_UI_.Properties.Resources.exit;
            this.exitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(219, 60);
            this.exitBtn.Text = "Exit";
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Header.Controls.Add(this.headerLabel);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1129, 64);
            this.Header.TabIndex = 33;
            // 
            // headerLabel
            // 
            this.headerLabel.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(275, 3);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(704, 60);
            this.headerLabel.TabIndex = 35;
            this.headerLabel.Text = "Clinic Management System";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(471, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 314);
            this.dataGridView1.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.addToSymptoms);
            this.panel1.Controls.Add(this.removeFromSymptoms);
            this.panel1.Controls.Add(this.symptomsList);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.SymptomsBox);
            this.panel1.Controls.Add(this.phoneTB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.addToDiseasesBtn);
            this.panel1.Controls.Add(this.removeFromListBtn);
            this.panel1.Controls.Add(this.diseasesList);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.diseasesComboBox);
            this.panel1.Controls.Add(this.nameTB);
            this.panel1.Controls.Add(this.idTB);
            this.panel1.Controls.Add(this.applyBtn);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(26, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 613);
            this.panel1.TabIndex = 22;
            // 
            // addToSymptoms
            // 
            this.addToSymptoms.Enabled = false;
            this.addToSymptoms.Location = new System.Drawing.Point(340, 402);
            this.addToSymptoms.Name = "addToSymptoms";
            this.addToSymptoms.Size = new System.Drawing.Size(57, 23);
            this.addToSymptoms.TabIndex = 34;
            this.addToSymptoms.Text = "Add";
            this.addToSymptoms.UseVisualStyleBackColor = true;
            this.addToSymptoms.Visible = false;
            // 
            // removeFromSymptoms
            // 
            this.removeFromSymptoms.Enabled = false;
            this.removeFromSymptoms.Location = new System.Drawing.Point(340, 439);
            this.removeFromSymptoms.Name = "removeFromSymptoms";
            this.removeFromSymptoms.Size = new System.Drawing.Size(57, 23);
            this.removeFromSymptoms.TabIndex = 30;
            this.removeFromSymptoms.Text = "Remove";
            this.removeFromSymptoms.UseVisualStyleBackColor = true;
            this.removeFromSymptoms.Visible = false;
            // 
            // symptomsList
            // 
            this.symptomsList.FormattingEnabled = true;
            this.symptomsList.Location = new System.Drawing.Point(119, 367);
            this.symptomsList.Name = "symptomsList";
            this.symptomsList.Size = new System.Drawing.Size(215, 95);
            this.symptomsList.TabIndex = 31;
            this.symptomsList.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(23, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "Symptoms";
            // 
            // SymptomsBox
            // 
            this.SymptomsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SymptomsBox.FormattingEnabled = true;
            this.SymptomsBox.Location = new System.Drawing.Point(119, 328);
            this.SymptomsBox.Name = "SymptomsBox";
            this.SymptomsBox.Size = new System.Drawing.Size(218, 21);
            this.SymptomsBox.TabIndex = 32;
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(127, 127);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(218, 20);
            this.phoneTB.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(23, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Phone";
            // 
            // addToDiseasesBtn
            // 
            this.addToDiseasesBtn.Enabled = false;
            this.addToDiseasesBtn.Location = new System.Drawing.Point(345, 255);
            this.addToDiseasesBtn.Name = "addToDiseasesBtn";
            this.addToDiseasesBtn.Size = new System.Drawing.Size(57, 23);
            this.addToDiseasesBtn.TabIndex = 27;
            this.addToDiseasesBtn.Text = "Add";
            this.addToDiseasesBtn.UseVisualStyleBackColor = true;
            this.addToDiseasesBtn.Visible = false;
            // 
            // removeFromListBtn
            // 
            this.removeFromListBtn.Enabled = false;
            this.removeFromListBtn.Location = new System.Drawing.Point(345, 291);
            this.removeFromListBtn.Name = "removeFromListBtn";
            this.removeFromListBtn.Size = new System.Drawing.Size(57, 23);
            this.removeFromListBtn.TabIndex = 6;
            this.removeFromListBtn.Text = "Remove";
            this.removeFromListBtn.UseVisualStyleBackColor = true;
            this.removeFromListBtn.Visible = false;
            // 
            // diseasesList
            // 
            this.diseasesList.FormattingEnabled = true;
            this.diseasesList.Location = new System.Drawing.Point(124, 219);
            this.diseasesList.Name = "diseasesList";
            this.diseasesList.Size = new System.Drawing.Size(215, 95);
            this.diseasesList.TabIndex = 6;
            this.diseasesList.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchRB);
            this.groupBox1.Controls.Add(this.addRB);
            this.groupBox1.Controls.Add(this.editRB);
            this.groupBox1.Controls.Add(this.removeRB);
            this.groupBox1.Location = new System.Drawing.Point(26, 486);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 69);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // searchRB
            // 
            this.searchRB.AutoSize = true;
            this.searchRB.Location = new System.Drawing.Point(13, 41);
            this.searchRB.Name = "searchRB";
            this.searchRB.Size = new System.Drawing.Size(59, 17);
            this.searchRB.TabIndex = 2;
            this.searchRB.TabStop = true;
            this.searchRB.Text = "Search";
            this.searchRB.UseVisualStyleBackColor = true;
            // 
            // addRB
            // 
            this.addRB.AutoSize = true;
            this.addRB.Location = new System.Drawing.Point(101, 41);
            this.addRB.Name = "addRB";
            this.addRB.Size = new System.Drawing.Size(44, 17);
            this.addRB.TabIndex = 4;
            this.addRB.TabStop = true;
            this.addRB.Text = "Add";
            this.addRB.UseVisualStyleBackColor = true;
            // 
            // editRB
            // 
            this.editRB.AutoSize = true;
            this.editRB.Location = new System.Drawing.Point(197, 41);
            this.editRB.Name = "editRB";
            this.editRB.Size = new System.Drawing.Size(43, 17);
            this.editRB.TabIndex = 3;
            this.editRB.TabStop = true;
            this.editRB.Text = "Edit";
            this.editRB.UseVisualStyleBackColor = true;
            // 
            // removeRB
            // 
            this.removeRB.AutoSize = true;
            this.removeRB.Location = new System.Drawing.Point(267, 41);
            this.removeRB.Name = "removeRB";
            this.removeRB.Size = new System.Drawing.Size(65, 17);
            this.removeRB.TabIndex = 5;
            this.removeRB.TabStop = true;
            this.removeRB.Text = "Remove";
            this.removeRB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(23, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Diseases";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Id";
            // 
            // diseasesComboBox
            // 
            this.diseasesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diseasesComboBox.FormattingEnabled = true;
            this.diseasesComboBox.Location = new System.Drawing.Point(124, 180);
            this.diseasesComboBox.Name = "diseasesComboBox";
            this.diseasesComboBox.Size = new System.Drawing.Size(218, 21);
            this.diseasesComboBox.TabIndex = 22;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(124, 80);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(218, 20);
            this.nameTB.TabIndex = 21;
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(124, 32);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(218, 20);
            this.idTB.TabIndex = 20;
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(161, 578);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 1;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            // 
            // userInfoPanel
            // 
            this.userInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userInfoPanel.Controls.Add(this.userJobLabel);
            this.userInfoPanel.Controls.Add(this.userNameLabel);
            this.userInfoPanel.Controls.Add(this.pictureBox1);
            this.userInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.userInfoPanel.Name = "userInfoPanel";
            this.userInfoPanel.Size = new System.Drawing.Size(231, 64);
            this.userInfoPanel.TabIndex = 34;
            // 
            // userJobLabel
            // 
            this.userJobLabel.AutoSize = true;
            this.userJobLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userJobLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.userJobLabel.Location = new System.Drawing.Point(118, 32);
            this.userJobLabel.Name = "userJobLabel";
            this.userJobLabel.Size = new System.Drawing.Size(53, 23);
            this.userJobLabel.TabIndex = 2;
            this.userJobLabel.Text = "User";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.userNameLabel.Location = new System.Drawing.Point(81, 9);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(137, 23);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "Ahmed Samir";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 69);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1129, 716);
            this.Controls.Add(this.userInfoPanel);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.navBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.userInfoPanel.ResumeLayout(false);
            this.userInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void initBodyPanel(Form body)
        {
            
            if (Body != null) {
                Body.Visible = false;
                this.Controls.Remove(Body);
            }
            Body = body;
            // 
            // Body
            // 
            this.Body.Location = new System.Drawing.Point(234, 63);
            this.Body.Name = "Body";
           // this.Body.Size = new System.Drawing.Size(895, 653);
            this.Body.TabIndex = 34;
            this.Body.TopLevel = false;
            this.Body.FormBorderStyle = FormBorderStyle.None;
            this.Body.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.Body);
            this.Body.ResumeLayout(false);
            this.Body.SuspendLayout();
            this.Body.Visible = true;
            // 
        }

        #endregion
        private System.Windows.Forms.ToolStrip navBar;
        private System.Windows.Forms.ToolStripButton exitBtn;
        private System.Windows.Forms.ToolStripButton bookingBtn;
        private System.Windows.Forms.ToolStripButton doctorsBtn;
        private System.Windows.Forms.ToolStripButton patientsBtn;
        private System.Windows.Forms.ToolStripButton medicinesBtn;
        private System.Windows.Forms.ToolStripButton diseasesBtn;
        private System.Windows.Forms.ToolStripButton symptomsBtn;
        private System.Windows.Forms.ToolStripButton usersBtn;
        private System.Windows.Forms.ToolStripButton logoutBtn;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel userInfoPanel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addToSymptoms;
        private System.Windows.Forms.Button removeFromSymptoms;
        private System.Windows.Forms.ListBox symptomsList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SymptomsBox;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addToDiseasesBtn;
        private System.Windows.Forms.Button removeFromListBtn;
        private System.Windows.Forms.ListBox diseasesList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton searchRB;
        private System.Windows.Forms.RadioButton addRB;
        private System.Windows.Forms.RadioButton editRB;
        private System.Windows.Forms.RadioButton removeRB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox diseasesComboBox;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Label userJobLabel;
    }
}