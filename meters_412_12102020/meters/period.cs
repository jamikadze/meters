using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meters
{
    public partial class period : Form
    {
        public period()
        {
            InitializeComponent();
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btok_Click(object sender, EventArgs e)
        {
            Globals.date1 = dateTimePicker1.Value;
            Globals.date2 = dateTimePicker2.Value;

            if(comboBox1.Text=="Монтер")
            {
            Form mm = new reportExec();
            mm.Show();
            }
            if (comboBox1.Text == "Счетчик")
            {
            Form mm = new shipMaterials();
            mm.Show();
            }
            this.Close();

        }
    }
}
