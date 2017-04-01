namespace  Clinic_Managment_System__Better_UI_
{
    partial class Symptoms
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchRB = new System.Windows.Forms.RadioButton();
            this.addRB = new System.Windows.Forms.RadioButton();
            this.editRB = new System.Windows.Forms.RadioButton();
            this.removeRB = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.applyBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.showPatientsBTN = new System.Windows.Forms.Button();
            this.showDiseaseBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(480, 38);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 450);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchRB);
            this.groupBox1.Controls.Add(this.addRB);
            this.groupBox1.Controls.Add(this.editRB);
            this.groupBox1.Controls.Add(this.removeRB);
            this.groupBox1.Location = new System.Drawing.Point(26, 245);
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
            this.removeRB.Text = "Remove";
            this.removeRB.UseVisualStyleBackColor = true;
            this.removeRB.CheckedChanged += new System.EventHandler(this.removeRB_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(26, 109);
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
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(127, 107);
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
            this.applyBtn.Location = new System.Drawing.Point(159, 379);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 1;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.descriptionTB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nameTB);
            this.panel1.Controls.Add(this.idTB);
            this.panel1.Controls.Add(this.applyBtn);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(23, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 450);
            this.panel1.TabIndex = 21;
            // 
            // descriptionTB
            // 
            this.descriptionTB.Location = new System.Drawing.Point(124, 173);
            this.descriptionTB.Multiline = true;
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTB.Size = new System.Drawing.Size(215, 46);
            this.descriptionTB.TabIndex = 30;
            // 
            // showPatientsBTN
            // 
            this.showPatientsBTN.Location = new System.Drawing.Point(477, 506);
            this.showPatientsBTN.Name = "showPatientsBTN";
            this.showPatientsBTN.Size = new System.Drawing.Size(156, 28);
            this.showPatientsBTN.TabIndex = 23;
            this.showPatientsBTN.Text = "Show Patients";
            this.showPatientsBTN.UseVisualStyleBackColor = true;
            this.showPatientsBTN.Click += new System.EventHandler(this.showPatientsBTN_Click);
            // 
            // showDiseaseBTN
            // 
            this.showDiseaseBTN.Location = new System.Drawing.Point(676, 506);
            this.showDiseaseBTN.Name = "showDiseaseBTN";
            this.showDiseaseBTN.Size = new System.Drawing.Size(148, 28);
            this.showDiseaseBTN.TabIndex = 24;
            this.showDiseaseBTN.Text = "Show Disease";
            this.showDiseaseBTN.UseVisualStyleBackColor = true;
            this.showDiseaseBTN.Click += new System.EventHandler(this.showDiseaseBTN_Click);
            // 
            // Symptoms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 537);
            this.Controls.Add(this.showDiseaseBTN);
            this.Controls.Add(this.showPatientsBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Symptoms";
            this.Text = "Symptoms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Symptoms_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton searchRB;
        private System.Windows.Forms.RadioButton addRB;
        private System.Windows.Forms.RadioButton editRB;
        private System.Windows.Forms.RadioButton removeRB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox descriptionTB;
        private System.Windows.Forms.Button showPatientsBTN;
        private System.Windows.Forms.Button showDiseaseBTN;
    }
}