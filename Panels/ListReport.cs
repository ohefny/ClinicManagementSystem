
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  Clinic_Managment_System__Better_UI_
{
    public partial class ListReport<T> : Form
    {
        List<T> list = new List<T>();
        public ListReport()
        {
            InitializeComponent();
        }

        public List<T> List
        {
            get
            {
                return list;
            }

            set
            {

                list = value;
            }
        }

        private void DrugsReport_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = list;

        }
        
    }
}
