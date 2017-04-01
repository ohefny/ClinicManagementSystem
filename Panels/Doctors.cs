
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
    public partial class Doctors : Form
    {
       
        Form mainForm;
        Constants.ChoosedItem choosedItem = Constants.ChoosedItem.SEARCH;
        List<Doctor> doctors = new List<Doctor>();
        //List<Patient> patients = new List<Patient>();
        List<Disease> diseases = new List<Disease>();
        Doctor choosedDoctor;
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
        public Doctors()
        {
            InitializeComponent();
            doctors = DatabaseUtility.getDoctors(null);
            diseases = DatabaseUtility.getDiseases(null);
            diseasesComboBox.DataSource = diseases;
            doctors = DatabaseUtility.getDoctors(null);
            dataGridView1.DataSource = doctors;

        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            mainFormOpened = true;
            mainForm.Show();
            this.Close();
        }

        private void Doctors_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!mainFormOpened)
                System.Windows.Forms.Application.Exit();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.Id = idTB.Text.ToString().Trim();
            doctor.Name = nameTB.Text.ToString().Trim();
            
            dataGridView1.DataSource = new List<Disease>();

            switch (choosedItem)
            {
                case
                  ChoosedItem.ADD:
                    foreach (object ob in diseasesBox.Items)
                    {
                        doctor.Diseases.Add((Disease)ob);
                    }
                    if (DatabaseUtility.addDoctor(doctor))
                    {

                        doctor.Id = "";
                        doctors.Add(doctor);
                    }
                    break;
                case ChoosedItem.REMOVE:
                    if (DatabaseUtility.removeDoctor(doctor.Id))
                    {
                        int idx = doctors.IndexOf(doctor);
                        if (idx >= 0)
                        {

                            //foreach (DataGridViewRow dr in dataGridView1.Rows) {
                            //    dr.Selected = false;
                            //}
                            // dataGridView1.Rows[idx].Selected = false;
                            doctors.Remove(doctor);

                        }
                    }
                    break;
                case ChoosedItem.UPDATE:
                    if (DatabaseUtility.updateDoctor(doctor))
                    {
                        int idx = doctors.IndexOf(doctor);
                        if (idx >= 0)
                        {
                            doctors.Remove(doctor);
                            doctors.Insert(idx, doctor);
                        }
                    }
                    break;
                case ChoosedItem.SEARCH:
                    doctors = DatabaseUtility.getDoctors(doctor);
                    dataGridView1.DataSource = doctors;
                    break;

            }

            //symptoms = DatabaseUtility.getSymptoms(null);
            dataGridView1.DataSource = doctors;
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
                diseasesBox.Enabled = false;
                diseasesComboBox.Enabled = false;
                diseaseAddbtn.Enabled = false;
                diseaseRemovebtn.Enabled = false;
            }
            else
            {
                idTB.Enabled = true;
                diseasesBox.Enabled = true;
                diseasesComboBox.Enabled = true;
                diseaseAddbtn.Enabled = true;
                diseaseRemovebtn.Enabled = true;
            }
        }

        private void removeRB_CheckedChanged(object sender, EventArgs e)
        {
            choosedItem = ChoosedItem.REMOVE;
            if (((RadioButton)sender).Checked)
            {
                nameTB.Enabled = false;
                
            }
            else
            {
                nameTB.Enabled = true;
            }
        }

        private void diseaseAddbtn_Click(object sender, EventArgs e)
        {
            if (diseasesBox.Items.Contains((Disease)diseasesComboBox.SelectedItem))
                return;
            diseasesBox.Items.Add((Disease)diseasesComboBox.SelectedItem);

        }

        private void diseaseRemovebtn_Click(object sender, EventArgs e)
        {
            diseasesBox.Items.Remove(diseasesBox.SelectedItem);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            setChoosedDoctors(doctors.ElementAt<Doctor>(dataGridView1.CurrentCell.RowIndex));
        }
        private void setChoosedDoctors(Doctor doctor)
        {
            choosedDoctor = doctor;
            idTB.Text = choosedDoctor.Id;
            nameTB.Text = choosedDoctor.Name;
          
        }
        private void showDiseases_Click(object sender, EventArgs e)
        {
            ListReport<Disease> lr = new ListReport<Disease>();
           
           
                lr.List = DatabaseUtility.getDiseaseOfDoctor(doctors.ElementAt<Doctor>(dataGridView1.CurrentCell.RowIndex));
                lr.ShowDialog();
            
        }
        private void showPatients_Click(object sender, EventArgs e)
        {
            ListReport<Patient> lr = new ListReport<Patient>();

            lr.List = DatabaseUtility.getPatientssOfDoctor(doctors.ElementAt<Doctor>(dataGridView1.CurrentCell.RowIndex));
            lr.ShowDialog();
           
        }
    }
}
