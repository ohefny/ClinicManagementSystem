
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
    public partial class Patients : Form
    {
        Form mainForm;
        Constants.ChoosedItem choosedItem = Constants.ChoosedItem.SEARCH;
        List<Symptom> symptoms = new List<Symptom>();
        //List<Patient> patients = new List<Patient>();
        List<Disease> diseases = new List<Disease>();
        Patient choosedPatient;
        List<Patient> patients = new List<Patient>();
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
        public Patients()
        {
            InitializeComponent();
            patients = DatabaseUtility.getPatients(null);
            symptoms = DatabaseUtility.getSymptoms(null);
            SymptomsBox.DataSource = symptoms;
            diseases = DatabaseUtility.getDiseases(null);
            diseasesComboBox.DataSource = diseases;
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Parse("01/01/1985");
            //    symptoms = DatabaseUtility.getSymptoms(null);
            //   diseases = DatabaseUtility.getDiseases(null);
            //   patients = DatabaseUtility.getPatients(null);
            //  diseasesComboBox.DataSource = diseases;

                dataGridView1.DataSource = patients;

        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            mainFormOpened = true;
            mainForm.Show();
            this.Close();
        }

        private void Patients_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!mainFormOpened)
                System.Windows.Forms.Application.Exit();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Id = idTB.Text.ToString().Trim();
            patient.Name = nameTB.Text.ToString().Trim();
            patient.Phone=phoneTB.Text.ToString().Trim();
            patient.IllnessDate = dateTimePicker1.Value;
            dataGridView1.DataSource = new List<Patient>();
            
            switch (choosedItem)
            {
                case
                  ChoosedItem.ADD:
                    foreach (Object o in diseasesList.Items)
                    {
                        patient.Diseases.Add((Disease)o);
                    }
                    foreach (Object o in symptomsList.Items)
                    {
                        patient.Symptoms.Add((Symptom)o);
                    }
                    if (DatabaseUtility.addPatient(patient))
                    {
                        patient.Id = "";
                        patients.Add(patient);
                    }
                    break;
                case ChoosedItem.REMOVE:
                    if (DatabaseUtility.removePatient(patient.Id))
                    {
                        int idx = patients.IndexOf(patient);
                        if (idx >= 0)
                        {

                            //foreach (DataGridViewRow dr in dataGridView1.Rows) {
                            //    dr.Selected = false;
                            //}
                            // dataGridView1.Rows[idx].Selected = false;
                            patients.Remove(patient);

                        }
                    }
                    break;
                case ChoosedItem.UPDATE:
                    if (DatabaseUtility.updatePatient(patient))
                    {
                        int idx = patients.IndexOf(patient);
                        if (idx >= 0)
                        {
                            patients.Remove(patient);
                            patients.Insert(idx, patient);
                        }
                    }
                    break;
                case ChoosedItem.SEARCH:
                    patients = DatabaseUtility.getPatients(patient);
                    dataGridView1.DataSource = patients;
                    break;

            }

            //symptoms = DatabaseUtility.getSymptoms(null);
            dataGridView1.DataSource = patients;
            dataGridView1.Invalidate();
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
                idTB.Text = "";
                idTB.Enabled = false;
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
                diseasesComboBox.Enabled = false;
                SymptomsBox.Enabled = false;
                addToDiseasesBtn.Enabled = false;
                removeFromListBtn.Enabled = false;
                removeFromSymptoms.Enabled = false;
                addToSymptoms.Enabled = false;

            }
            else
            {
                idTB.Enabled = true;
                diseasesComboBox.Enabled = true;
                SymptomsBox.Enabled = true;
                addToDiseasesBtn.Enabled = true;
                removeFromListBtn.Enabled = true;
                removeFromSymptoms.Enabled = true;
                addToSymptoms.Enabled = true;
            }
        }

        private void removeRB_CheckedChanged(object sender, EventArgs e)
        {
            choosedItem = ChoosedItem.REMOVE;
            if (((RadioButton)sender).Checked)
            {
                nameTB.Enabled = false;
              //  descriptionTB.Enabled = false;
            }
            else
            {
             //   descriptionTB.Enabled = true;
                nameTB.Enabled = true;
            }

        }

        private void addToDiseasesBtn_Click(object sender, EventArgs e)
        {
            if (diseasesList.Items.Contains((Disease)diseasesComboBox.SelectedItem))
                return;
            diseasesList.Items.Add((Disease)diseasesComboBox.SelectedItem);

        }

        private void removeFromListBtn_Click(object sender, EventArgs e)
        {
            diseasesList.Items.Remove(diseasesList.SelectedItem);
        }

        private void addToSymptoms_Click(object sender, EventArgs e)
        {

            if (symptomsList.Items.Contains((Symptom)SymptomsBox.SelectedItem))
                return;
            symptomsList.Items.Add((Symptom)SymptomsBox.SelectedItem);
        }

        private void removeFromSymptoms_Click(object sender, EventArgs e)
        {
            symptomsList.Items.Remove(symptomsList.SelectedItem);
        }

        private void Patients_Load(object sender, EventArgs e)
        {

        }

        private void Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showSymptomsBTN_Click(object sender, EventArgs e)
        {
            ListReport<Symptom> lr = new ListReport<Symptom>();
            lr.List = DatabaseUtility.getSymptomsOfPatient(patients.ElementAt<Patient>(dataGridView1.CurrentCell.RowIndex));
            lr.ShowDialog();
        }

        private void showDiseasesBtn_Click(object sender, EventArgs e)
        {
            ListReport<Disease> lr = new ListReport<Disease>();
            lr.List = DatabaseUtility.getDiseasesOfPatient(patients.ElementAt<Patient>(dataGridView1.CurrentCell.RowIndex));
            lr.ShowDialog();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            choosedPatient = patients.ElementAt<Patient>(dataGridView1.CurrentCell.RowIndex);
        }
    }
}
