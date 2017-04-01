
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using  Clinic_Managment_System__Better_UI_;

namespace  Clinic_Managment_System__Better_UI_
{
    public partial class Drugs : Form
    {

        Form mainForm;
        Clinic_Managment_System__Better_UI_.Constants.ChoosedItem ChoosedItem = Clinic_Managment_System__Better_UI_.Constants.ChoosedItem.SEARCH;
        List<Drug> drugs = new List<Drug>();
        List<Disease> diseases = new List<Disease>();
        private bool mainFormOpened;
        private Drug choosedDrug;


        public Drugs()
        {
            InitializeComponent();
            drugs = DatabaseUtility.getDrugs(null);
            dataGridView1.DataSource = drugs;


        }
        private void applyBtn_Click(object sender, EventArgs e)
        {
            Drug drug = new Drug();
            drug.Id = idTB.Text.ToString().Trim();
            drug.Name = nameTB.Text.ToString().Trim();
            drug.Description = descriptionTB.Text.ToString().Trim();
            dataGridView1.DataSource = new List<Drug>();

            switch (choosedItem)
            {
                case
                  ChoosedItem.ADD:
                    drug.DiseaseId = ((Disease)diseasesComboBox.SelectedItem).Id;
                    if (DatabaseUtility.addDrug(drug))
                    {
                        drug.Id = "";
                        drugs.Add(drug);
                    }
                    break;
                case ChoosedItem.REMOVE:
                    if (DatabaseUtility.removeDisease(drug.Id))
                    {
                        int idx = drugs.IndexOf(drug);
                        if (idx >= 0)
                        {

                            //foreach (DataGridViewRow dr in dataGridView1.Rows) {
                            //    dr.Selected = false;
                            //}
                            // dataGridView1.Rows[idx].Selected = false;
                            drugs.Remove(drug);

                        }
                    }
                    break;
                case ChoosedItem.UPDATE:
                    if (DatabaseUtility.updateDrug(drug))
                    {
                        int idx = drugs.IndexOf(drug);
                        if (idx >= 0)
                        {
                            drugs.Remove(drug);
                            drugs.Insert(idx, drug);
                        }
                    }
                    break;
                case ChoosedItem.SEARCH:
                    drugs = DatabaseUtility.getDrugs(drug);
                    dataGridView1.DataSource = drugs;
                    break;

            }

            //symptoms = DatabaseUtility.getSymptoms(null);
            dataGridView1.DataSource = drugs;
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

            }
            else
            {
                idTB.Enabled = true;
                diseasesComboBox.Enabled = true;
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
            setChoosedDrug(drugs.ElementAt<Drug>(dataGridView1.CurrentCell.RowIndex));
        }
        private void setChoosedDrug(Drug drug)
        {
            choosedDrug = drug;
            idTB.Text = choosedDrug.Id;
            nameTB.Text = choosedDrug.Name;
            descriptionTB.Text = choosedDrug.Description;
        }

      
        private void showDiseasesBtn_Click(object sender, EventArgs e)
        {
            ListReport<Disease> lr = new ListReport<Disease>();
            Disease d = new Disease();

         
                d.Id = drugs.ElementAt<Drug>(dataGridView1.CurrentCell.RowIndex).DiseaseId;
                lr.List = DatabaseUtility.getDiseases(d);
                lr.ShowDialog();
            
        }
    }
}
