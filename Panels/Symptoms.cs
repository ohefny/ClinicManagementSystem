
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic_Managment_System__Better_UI_;

namespace  Clinic_Managment_System__Better_UI_
{
    public partial class Symptoms : Form
    {
        Form mainForm;
        Constants.ChoosedItem choosedItem = Constants.ChoosedItem.SEARCH;
        List<Symptom> symptoms = new List<Symptom>();
        Symptom choosedSymptom;
        public Form MainForm
        {
            get
            {
                return mainForm;
            }

            set
            {
                mainForm = value;
            }
        }
        public Symptoms()
        {
            InitializeComponent();
            symptoms = DatabaseUtility.getSymptoms(null);
            dataGridView1.DataSource= symptoms;
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
            
        }

        private void Symptoms_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mainForm.ShowInTaskbar)
                return;
            System.Windows.Forms.Application.Exit();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            Symptom symptom = new Symptom();
            symptom.Id = idTB.Text.ToString().Trim();
            symptom.Name = nameTB.Text.ToString().Trim();
            symptom.Description = descriptionTB.Text.ToString().Trim();
            dataGridView1.DataSource = new List<Symptom>();
            switch (choosedItem) {
                case
                  ChoosedItem.ADD:
                    if (DatabaseUtility.addSymptom(symptom)) {
                        symptom.Id = "";
                        symptoms.Add(symptom);
                    }
                    break;
                case ChoosedItem.REMOVE:
                    if (DatabaseUtility.removeSymptoms(symptom.Id))
                    {
                        int idx = symptoms.IndexOf(symptom);
                        if (idx >= 0)
                        {
                            
                            //foreach (DataGridViewRow dr in dataGridView1.Rows) {
                            //    dr.Selected = false;
                            //}
                           // dataGridView1.Rows[idx].Selected = false;
                            symptoms.Remove(symptom);
                            
                        }
                    }
                    break;
                case ChoosedItem.UPDATE:
                    if (DatabaseUtility.updateSymptom(symptom)) { 
                    int idx = symptoms.IndexOf(symptom);
                        if (idx >= 0) {
                            symptoms.Remove(symptom);
                            symptoms.Insert(idx, symptom);
                        }
                    }
                    break;
                case ChoosedItem.SEARCH:
                    symptoms= DatabaseUtility.getSymptoms(symptom);
                    dataGridView1.DataSource= symptoms;
                    break;

            }

            //symptoms = DatabaseUtility.getSymptoms(null);
            dataGridView1.DataSource = symptoms;
            dataGridView1.Invalidate();
           // dataGridView1.Update();
        }

        private void searchRB_CheckedChanged(object sender, EventArgs e)
        {
             choosedItem = ChoosedItem.SEARCH;
        }

        private void addRB_CheckedChanged(object sender, EventArgs e)
        {
             choosedItem = ChoosedItem.ADD;
            if (((RadioButton)sender).Checked)
            {
                idTB.Enabled = false;
            }
            else {
                idTB.Enabled = true;
            }
       }

        private void editRB_CheckedChanged(object sender, EventArgs e)
        {
             choosedItem = ChoosedItem.UPDATE;
            if (((RadioButton)sender).Checked)
            {
                idTB.Enabled = false;
            }
            else
            {
                idTB.Enabled = true;
            }
        }

        private void removeRB_CheckedChanged(object sender, EventArgs e)
        {
             choosedItem = ChoosedItem.REMOVE;
            if (((RadioButton)sender).Checked)
            {
                nameTB.Enabled = false;
                descriptionTB.Enabled = false;
            }
            else
            {
                descriptionTB.Enabled = true;
                nameTB.Enabled = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            setChoosedSymptom(symptoms.ElementAt<Symptom>( dataGridView1.CurrentCell.RowIndex));
        }

        private void setChoosedSymptom(Symptom symptom)
        {
            choosedSymptom = symptom;
            idTB.Text= choosedSymptom.Id;
            nameTB.Text = choosedSymptom.Name;
            descriptionTB.Text = choosedSymptom.Description;


        }

        private void showPatientsBTN_Click(object sender, EventArgs e)
        {
            ListReport<Patient> lr = new ListReport<Patient>();
            Symptom sym = symptoms.ElementAt<Symptom>(dataGridView1.CurrentCell.RowIndex);
            lr.List =DatabaseUtility.getPatientsOfSymptom(sym);
            lr.ShowDialog();

        }

        private void showDiseaseBTN_Click(object sender, EventArgs e)
        {
            ListReport<Disease> lr = new ListReport<Disease>();
            Symptom sym = symptoms.ElementAt<Symptom>(dataGridView1.CurrentCell.RowIndex);
            lr.List = DatabaseUtility.getDiseasesOfSymptom(sym);
            lr.ShowDialog();
        }
    }
}
