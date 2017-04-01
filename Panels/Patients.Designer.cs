namespace  Clinic_Managment_System__Better_UI_
{
    partial class Patients
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
            this.Body = new System.Windows.Forms.Panel();
            this.showDiseasesBtn = new System.Windows.Forms.Button();
            this.showSymptomsBTN = new System.Windows.Forms.Button();
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
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Body
            // 
            this.Body.Controls.Add(this.showDiseasesBtn);
            this.Body.Controls.Add(this.showSymptomsBTN);
            this.Body.Controls.Add(this.dataGridView1);
            this.Body.Controls.Add(this.panel1);
            this.Body.Location = new System.Drawing.Point(12, 12);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(895, 673);
            this.Body.TabIndex = 34;
            // 
            // showDiseasesBtn
            // 
            this.showDiseasesBtn.Location = new System.Drawing.Point(723, 484);
            this.showDiseasesBtn.Name = "showDiseasesBtn";
            this.showDiseasesBtn.Size = new System.Drawing.Size(126, 32);
            this.showDiseasesBtn.TabIndex = 25;
            this.showDiseasesBtn.Text = "Show Diseases";
            this.showDiseasesBtn.UseVisualStyleBackColor = true;
            this.showDiseasesBtn.Click += new System.EventHandler(this.showDiseasesBtn_Click);
            // 
            // showSymptomsBTN
            // 
            this.showSymptomsBTN.Location = new System.Drawing.Point(499, 484);
            this.showSymptomsBTN.Name = "showSymptomsBTN";
            this.showSymptomsBTN.Size = new System.Drawing.Size(129, 32);
            this.showSymptomsBTN.TabIndex = 24;
            this.showSymptomsBTN.Text = "Show Symptoms";
            this.showSymptomsBTN.UseVisualStyleBackColor = true;
            this.showSymptomsBTN.Click += new System.EventHandler(this.showSymptomsBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(471, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 462);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label6);
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
            this.panel1.Size = new System.Drawing.Size(418, 638);
            this.panel1.TabIndex = 22;
            // 
            // addToSymptoms
            // 
            this.addToSymptoms.Location = new System.Drawing.Point(340, 402);
            this.addToSymptoms.Name = "addToSymptoms";
            this.addToSymptoms.Size = new System.Drawing.Size(57, 23);
            this.addToSymptoms.TabIndex = 34;
            this.addToSymptoms.Text = "Add";
            this.addToSymptoms.UseVisualStyleBackColor = true;
            this.addToSymptoms.Click += new System.EventHandler(this.addToSymptoms_Click);
            // 
            // removeFromSymptoms
            // 
            this.removeFromSymptoms.Location = new System.Drawing.Point(340, 439);
            this.removeFromSymptoms.Name = "removeFromSymptoms";
            this.removeFromSymptoms.Size = new System.Drawing.Size(57, 23);
            this.removeFromSymptoms.TabIndex = 30;
            this.removeFromSymptoms.Text = "Remove";
            this.removeFromSymptoms.UseVisualStyleBackColor = true;
            this.removeFromSymptoms.Click += new System.EventHandler(this.removeFromSymptoms_Click);
            // 
            // symptomsList
            // 
            this.symptomsList.FormattingEnabled = true;
            this.symptomsList.Location = new System.Drawing.Point(119, 367);
            this.symptomsList.Name = "symptomsList";
            this.symptomsList.Size = new System.Drawing.Size(215, 95);
            this.symptomsList.TabIndex = 31;
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
            this.addToDiseasesBtn.Location = new System.Drawing.Point(345, 255);
            this.addToDiseasesBtn.Name = "addToDiseasesBtn";
            this.addToDiseasesBtn.Size = new System.Drawing.Size(57, 23);
            this.addToDiseasesBtn.TabIndex = 27;
            this.addToDiseasesBtn.Text = "Add";
            this.addToDiseasesBtn.UseVisualStyleBackColor = true;
            this.addToDiseasesBtn.Click += new System.EventHandler(this.addToDiseasesBtn_Click);
            // 
            // removeFromListBtn
            // 
            this.removeFromListBtn.Location = new System.Drawing.Point(345, 291);
            this.removeFromListBtn.Name = "removeFromListBtn";
            this.removeFromListBtn.Size = new System.Drawing.Size(57, 23);
            this.removeFromListBtn.TabIndex = 6;
            this.removeFromListBtn.Text = "Remove";
            this.removeFromListBtn.UseVisualStyleBackColor = true;
            this.removeFromListBtn.Click += new System.EventHandler(this.removeFromListBtn_Click);
            // 
            // diseasesList
            // 
            this.diseasesList.FormattingEnabled = true;
            this.diseasesList.Location = new System.Drawing.Point(124, 219);
            this.diseasesList.Name = "diseasesList";
            this.diseasesList.Size = new System.Drawing.Size(215, 95);
            this.diseasesList.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchRB);
            this.groupBox1.Controls.Add(this.addRB);
            this.groupBox1.Controls.Add(this.editRB);
            this.groupBox1.Controls.Add(this.removeRB);
            this.groupBox1.Location = new System.Drawing.Point(26, 528);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 69);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
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
            this.applyBtn.Location = new System.Drawing.Point(158, 603);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 1;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(23, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Illness Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 483);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(895, 684);
            this.Controls.Add(this.Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Patients";
            this.Text = "Patients";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Patients_FormClosing);
            this.Load += new System.EventHandler(this.Patients_Load);
            this.Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Body;
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
        private System.Windows.Forms.Button showDiseasesBtn;
        private System.Windows.Forms.Button showSymptomsBTN;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
    }
}