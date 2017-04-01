namespace Clinic_Managment_System__Better_UI_
{
    partial class Diseases
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.searchRB = new System.Windows.Forms.RadioButton();
            this.addRB = new System.Windows.Forms.RadioButton();
            this.editRB = new System.Windows.Forms.RadioButton();
            this.removeRB = new System.Windows.Forms.RadioButton();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addToListBtn = new System.Windows.Forms.Button();
            this.removeFromListBtn = new System.Windows.Forms.Button();
            this.lsBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SymptomsBox = new System.Windows.Forms.ComboBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.applyBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showDrugsBtn = new System.Windows.Forms.Button();
            this.showSymptomsBtn = new System.Windows.Forms.Button();
            this.showPatientsBtn = new System.Windows.Forms.Button();
            this.showDoctorsBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchRB
            // 
            this.searchRB.AutoSize = true;
            this.searchRB.Checked = true;
            this.searchRB.Location = new System.Drawing.Point(13, 41);
            this.searchRB.Name = "searchRB";
            this.searchRB.Size = new System.Drawing.Size(58, 17);
            this.searchRB.TabIndex = 2;
            this.searchRB.TabStop = true;
            this.searchRB.Text = "Search";
            this.searchRB.UseVisualStyleBackColor = true;
            this.searchRB.CheckedChanged += new System.EventHandler(this.searchRB_CheckedChanged);
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
            this.addRB.CheckedChanged += new System.EventHandler(this.addRB_CheckedChanged);
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
            this.editRB.CheckedChanged += new System.EventHandler(this.editRB_CheckedChanged);
            // 
            // removeRB
            // 
            this.removeRB.AutoSize = true;
            this.removeRB.Location = new System.Drawing.Point(267, 41);
            this.removeRB.Name = "removeRB";
            this.removeRB.Size = new System.Drawing.Size(64, 17);
            this.removeRB.TabIndex = 5;
            this.removeRB.TabStop = true;
            this.removeRB.Text = "Remove";
            this.removeRB.UseVisualStyleBackColor = true;
            this.removeRB.CheckedChanged += new System.EventHandler(this.removeRB_CheckedChanged);
            // 
            // descriptionTB
            // 
            this.descriptionTB.Location = new System.Drawing.Point(127, 159);
            this.descriptionTB.Multiline = true;
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTB.Size = new System.Drawing.Size(215, 46);
            this.descriptionTB.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(23, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Description";
            // 
            // addToListBtn
            // 
            this.addToListBtn.Location = new System.Drawing.Point(345, 317);
            this.addToListBtn.Name = "addToListBtn";
            this.addToListBtn.Size = new System.Drawing.Size(57, 23);
            this.addToListBtn.TabIndex = 27;
            this.addToListBtn.Text = "Add";
            this.addToListBtn.UseVisualStyleBackColor = true;
            this.addToListBtn.Click += new System.EventHandler(this.addToListBtn_Click);
            // 
            // removeFromListBtn
            // 
            this.removeFromListBtn.Location = new System.Drawing.Point(345, 354);
            this.removeFromListBtn.Name = "removeFromListBtn";
            this.removeFromListBtn.Size = new System.Drawing.Size(57, 23);
            this.removeFromListBtn.TabIndex = 6;
            this.removeFromListBtn.Text = "Remove";
            this.removeFromListBtn.UseVisualStyleBackColor = true;
            this.removeFromListBtn.Click += new System.EventHandler(this.removeFromListBtn_Click);
            // 
            // lsBox
            // 
            this.lsBox.FormattingEnabled = true;
            this.lsBox.Location = new System.Drawing.Point(124, 282);
            this.lsBox.Name = "lsBox";
            this.lsBox.Size = new System.Drawing.Size(215, 95);
            this.lsBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchRB);
            this.groupBox1.Controls.Add(this.addRB);
            this.groupBox1.Controls.Add(this.editRB);
            this.groupBox1.Controls.Add(this.removeRB);
            this.groupBox1.Location = new System.Drawing.Point(26, 415);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 69);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Symptoms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(26, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Name";
            // 
            // SymptomsBox
            // 
            this.SymptomsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SymptomsBox.FormattingEnabled = true;
            this.SymptomsBox.Location = new System.Drawing.Point(124, 243);
            this.SymptomsBox.Name = "SymptomsBox";
            this.SymptomsBox.Size = new System.Drawing.Size(218, 21);
            this.SymptomsBox.TabIndex = 22;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(127, 107);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(218, 20);
            this.nameTB.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.descriptionTB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.addToListBtn);
            this.panel1.Controls.Add(this.removeFromListBtn);
            this.panel1.Controls.Add(this.lsBox);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SymptomsBox);
            this.panel1.Controls.Add(this.nameTB);
            this.panel1.Controls.Add(this.idTB);
            this.panel1.Controls.Add(this.applyBtn);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 555);
            this.panel1.TabIndex = 21;
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
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(124, 32);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(218, 20);
            this.idTB.TabIndex = 20;
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(161, 507);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 1;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(469, 58);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 357);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // showDrugsBtn
            // 
            this.showDrugsBtn.Location = new System.Drawing.Point(469, 430);
            this.showDrugsBtn.Name = "showDrugsBtn";
            this.showDrugsBtn.Size = new System.Drawing.Size(102, 39);
            this.showDrugsBtn.TabIndex = 32;
            this.showDrugsBtn.Text = "Show drugs";
            this.showDrugsBtn.UseVisualStyleBackColor = true;
            this.showDrugsBtn.Click += new System.EventHandler(this.showDrugsBtn_Click);
            // 
            // showSymptomsBtn
            // 
            this.showSymptomsBtn.Location = new System.Drawing.Point(590, 430);
            this.showSymptomsBtn.Name = "showSymptomsBtn";
            this.showSymptomsBtn.Size = new System.Drawing.Size(113, 39);
            this.showSymptomsBtn.TabIndex = 33;
            this.showSymptomsBtn.Text = "Show Symptoms";
            this.showSymptomsBtn.UseVisualStyleBackColor = true;
            this.showSymptomsBtn.Click += new System.EventHandler(this.showSymptomsBtn_Click);
            // 
            // showPatientsBtn
            // 
            this.showPatientsBtn.Location = new System.Drawing.Point(720, 430);
            this.showPatientsBtn.Name = "showPatientsBtn";
            this.showPatientsBtn.Size = new System.Drawing.Size(119, 39);
            this.showPatientsBtn.TabIndex = 34;
            this.showPatientsBtn.Text = "Show Patients";
            this.showPatientsBtn.UseVisualStyleBackColor = true;
            this.showPatientsBtn.Click += new System.EventHandler(this.showPatientsBtn_Click);
            // 
            // showDoctorsBtn
            // 
            this.showDoctorsBtn.Location = new System.Drawing.Point(852, 430);
            this.showDoctorsBtn.Name = "showDoctorsBtn";
            this.showDoctorsBtn.Size = new System.Drawing.Size(119, 39);
            this.showDoctorsBtn.TabIndex = 35;
            this.showDoctorsBtn.Text = "Show Doctors";
            this.showDoctorsBtn.UseVisualStyleBackColor = true;
            this.showDoctorsBtn.Click += new System.EventHandler(this.showDoctorsBtn_Click);
            // 
            // Diseases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(994, 651);
            this.Controls.Add(this.showDoctorsBtn);
            this.Controls.Add(this.showPatientsBtn);
            this.Controls.Add(this.showSymptomsBtn);
            this.Controls.Add(this.showDrugsBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Diseases";
            this.Text = "Diseases";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RadioButton searchRB;
        private System.Windows.Forms.RadioButton addRB;
        private System.Windows.Forms.RadioButton editRB;
        private System.Windows.Forms.RadioButton removeRB;
        private System.Windows.Forms.TextBox descriptionTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addToListBtn;
        private System.Windows.Forms.Button removeFromListBtn;
        private System.Windows.Forms.ListBox lsBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SymptomsBox;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showDrugsBtn;
        private System.Windows.Forms.Button showSymptomsBtn;
        private System.Windows.Forms.Button showPatientsBtn;
        private System.Windows.Forms.Button showDoctorsBtn;
    }
}