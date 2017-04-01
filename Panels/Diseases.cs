
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

namespace Clinic_Managment_System__Better_UI_
{
    public partial class Diseases : Form
    {
        Form mainForm;
        Constants.ChoosedItem choosedItem = Constants.ChoosedItem.SEARCH;
        List<Symptom> symptoms = new List<Symptom>();
        List<Disease> diseases = new List<Disease>();
        Disease choosedDisease;
        
        private bool mainFormOpened = false;

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
        public Diseases()
        {
            InitializeComponent();
            symptoms = DatabaseUtility.getSymptoms(null);
            SymptomsBox.DataSource = symptoms;
            diseases = DatabaseUtility.getDiseases(null);
            dataGridView1.DataSource = diseases;
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            mainFormOpened = true;
            mainForm.Show();
            this.Close();
        }

        private void Diseases_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!mainFormOpened)
                System.Windows.Forms.Application.Exit();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            Disease disease = new Disease();
            disease.Id = idTB.Text.ToString().Trim();
            disease.Name = nameTB.Text.ToString().Trim();
            disease.Description = descriptionTB.Text.ToString().Trim();
            dataGridView1.DataSource = new List<Disease>();

            switch (choosedItem)
            {
                case
                  ChoosedItem.ADD:
                    foreach (object ob in lsBox.Items)
                    {
                        disease.Symptoms.Add((Symptom)ob);
                    }
                    if (DatabaseUtility.addDisease(disease))
                    {

                        disease.Id = "";
                        diseases.Add(disease);
                    }
                    break;
                case ChoosedItem.REMOVE:
                    if (DatabaseUtility.removeDisease(disease.Id))
                    {
                        int idx = diseases.IndexOf(disease);
                        if (idx >= 0)
                        {

                            //foreach (DataGridViewRow dr in dataGridView1.Rows) {
                            //    dr.Selected = false;
                            //}
                            // dataGridView1.Rows[idx].Selected = false;
                            diseases.Remove(disease);

                        }
                    }
                    break;
                case ChoosedItem.UPDATE:
                    if (DatabaseUtility.updateDisease(disease))
                    {
                        int idx = diseases.IndexOf(disease);
                        if (idx >= 0)
                        {
                            diseases.Remove(disease);
                            diseases.Insert(idx, disease);
                        }
                    }
                    break;
                case ChoosedItem.SEARCH:
                    diseases = DatabaseUtility.getDiseases(disease);
                    dataGridView1.DataSource = diseases;
                    break;

            }

            //symptoms = DatabaseUtility.getSymptoms(null);
            dataGridView1.DataSource = diseases;
            dataGridView1.Invalidate();

        }

        private void addToListBtn_Click(object sender, EventArgs e)
        {
            if (lsBox.Items.Contains((Symptom)SymptomsBox.SelectedItem))
                return;
            lsBox.Items.Add((Symptom)SymptomsBox.SelectedItem);
        }

        private void removeFromListBtn_Click(object sender, EventArgs e)
        {
            lsBox.Items.Remove(lsBox.SelectedItem);
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
                idTB.Text = "";
            }
            else
            {
                idTB.Enabled = true;
            }
        }

        private void editRB_CheckedChanged(object sender, EventArgs e)
        {
            choosedItem = ChoosedItem.UPDATE;
            if (((RadioButton)sender).Checked)
            {
                idTB.Enabled = false;
                SymptomsBox.Enabled = false;
                lsBox.Enabled = false;
                addToListBtn.Enabled = false;
                removeFromListBtn.Enabled = false;
            }
            else
            {
                idTB.Enabled = true;
                idTB.Enabled = true;
                SymptomsBox.Enabled = true;
                lsBox.Enabled = true;
                addToListBtn.Enabled = true;
                removeFromListBtn.Enabled = true;
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

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            setChoosedDisease(diseases.ElementAt<Disease>(dataGridView1.CurrentCell.RowIndex));
        }
        private void setChoosedDisease(Disease disease)
        {
            choosedDisease = disease;
            idTB.Text = choosedDisease.Id;
            nameTB.Text = choosedDisease.Name;
            descriptionTB.Text = choosedDisease.Description;


        }

        private void showDrugsBtn_Click(object sender, EventArgs e)
        {
            int idx = dataGridView1.CurrentCell.RowIndex;
            if (idx < 0){
              MessageBox.Show("Select a disease to show drugs");
            }

            ListReport<Drug> drugsReport = new ListReport<Drug>();
            drugsReport.List =DatabaseUtility.getDrugsOfDisease( diseases.ElementAt<Disease>(dataGridView1.CurrentCell.RowIndex));
            drugsReport.ShowDialog();
        }

        private void showSymptomsBtn_Click(object sender, EventArgs e)
        {
            int idx = dataGridView1.CurrentCell.RowIndex;
            if (idx < 0)
            {
                MessageBox.Show("Select a disease to show Symptoms");
            }

            ListReport<Symptom> symptomsReport = new ListReport<Symptom>();
            symptomsReport.List = DatabaseUtility.getSymptomsOfDisease(diseases.ElementAt<Disease>(dataGridView1.CurrentCell.RowIndex));
            symptomsReport.ShowDialog();
        }

        private void showPatientsBtn_Click(object sender, EventArgs e)
        {
            int idx = dataGridView1.CurrentCell.RowIndex;
            if (idx < 0)
            {
                MessageBox.Show("Select a disease to show Symptoms");
            }

            ListReport<Patient> patientsReport = new ListReport<Patient>();
            patientsReport.List = DatabaseUtility.getPatientsOfDisease(diseases.ElementAt<Disease>(dataGridView1.CurrentCell.RowIndex));
            patientsReport.ShowDialog();

        }

        private void showDoctorsBtn_Click(object sender, EventArgs e)
        {
            int idx = dataGridView1.CurrentCell.RowIndex;
            if (idx < 0)
            {
                MessageBox.Show("Select a disease to show Symptoms");
            }

            ListReport<Doctor> doctorsReport = new ListReport<Doctor>();
            doctorsReport.List = DatabaseUtility.getDoctorsOfdisease(diseases.ElementAt<Disease>(dataGridView1.CurrentCell.RowIndex));
            doctorsReport.ShowDialog();
        }
    }
}
