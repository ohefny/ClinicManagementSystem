
using Clinic_Managment_System__Better_UI_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//using Clinic_Managment_System__Better_UI_;

namespace Clinic_Managment_System__Better_UI_
{
    public partial class Users : Form
    {


        Constants.ChoosedItem choosedItem = Constants.ChoosedItem.SEARCH;
        List<User> users = new List<User>();
        private User choosedUser;


        public Users()
        {
            InitializeComponent();
            priv_box.SelectedItem = priv_box.Items[0];
            users = DatabaseUtility.getUsers(null);
            dataGridView1.DataSource = users;
        }
        private void applyBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Id = idTB.Text.ToString().Trim();
            user.UserName = userNameTB.Text.ToString().Trim();
            user.Pass = passTB.Text.ToString().Trim();
            user.Privilege = DatabaseUtility.stringToPrivilege(priv_box.SelectedItem.ToString());
            dataGridView1.DataSource = new List<User>();

            switch (choosedItem)
            {
                case
                  ChoosedItem.ADD:
                    
                    if (DatabaseUtility.addUser(user))
                    {
                        user.Id = "";
                        users.Add(user);
                    }
                    break;
                case ChoosedItem.REMOVE:
                    if (DatabaseUtility.removeUser(user.Id))
                    {
                        int idx = users.IndexOf(user);
                        if (idx >= 0)
                        {

                            //foreach (DataGridViewRow dr in dataGridView1.Rows) {
                            //    dr.Selected = false;
                            //}
                            // dataGridView1.Rows[idx].Selected = false;
                            users.Remove(user);

                        }
                    }
                    break;
               
                case ChoosedItem.SEARCH:
                    users = DatabaseUtility.getUsers(user);
                    dataGridView1.DataSource = users;
                    break;

            }

            //symptoms = DatabaseUtility.getSymptoms(null);
            dataGridView1.DataSource = users;
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

      

        private void removeRB_CheckedChanged(object sender, EventArgs e)
        {
            choosedItem = ChoosedItem.REMOVE;
            if (((RadioButton)sender).Checked)
            {
                userNameTB.Enabled = false;
                passTB.Enabled = false;
            }
            else
            {
                passTB.Enabled = true;
                userNameTB.Enabled = true;
            }
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            setChoosedUser(users.ElementAt<User>(dataGridView1.CurrentCell.RowIndex));
        }
        private void setChoosedUser(User user)
        {
            choosedUser = user;
            idTB.Text = choosedUser.Id;
            userNameTB.Text = choosedUser.UserName;
            
        }

        private void priv_box_Format(object sender, ListControlConvertEventArgs e)
        {

        }

        private void priv_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
