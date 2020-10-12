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
    public partial class spent_mat : Form
    {
        public spent_mat()
        {
            InitializeComponent();
        }

      

        private void spent_mat_Load(object sender, EventArgs e)
        {
            this.ostatok_mat_operatorTableAdapter.Fill(this.mMSDataSet.ostatok_mat_operator, Globals.id_slujbi);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           

        }

       
    }
}
