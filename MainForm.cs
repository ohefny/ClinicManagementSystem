
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Clinic_Managment_System__Better_UI_
{
    public partial class MainForm : Form
    {
       

    
        public MainForm()
        {
            InitializeComponent();
            initBodyPanel(new Diseases());
            //    symptoms = DatabaseUtility.getSymptoms(null);
            //   diseases = DatabaseUtility.getDiseases(null);
            //   patients = DatabaseUtility.getPatients(null);
            //  diseasesComboBox.DataSource = diseases;

            //    dataGridView1.DataSource = patients;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void patientsBtn_Click(object sender, EventArgs e)
        {
            if (!(Body is Patients))
                initBodyPanel(new Patients());
        }

        private void doctorsBtn_Click(object sender, EventArgs e)
        {
            if (!(Body is Doctors))
                initBodyPanel(new Doctors());
        }

        private void medicinesBtn_Click(object sender, EventArgs e)
        {
            if (!(Body is Drugs))
                initBodyPanel(new Drugs());
        }

        private void diseasesBtn_Click(object sender, EventArgs e)
        {
            if (!(Body is Diseases))
                initBodyPanel(new Diseases());
        }

        private void symptomsBtn_Click(object sender, EventArgs e)
        {
            if (!(Body is Symptoms))
                initBodyPanel(new Symptoms());
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            if (!(Body is Users))
                initBodyPanel(new Users());
        }
    }
}
