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
    public partial class parametr : DevExpress.XtraEditors.XtraForm
    {
        public parametr()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Globals.y = 3;
            Form otchet = new otchet();
            Globals.Date_n = Convert.ToDateTime(dateEdit1.Text);
            Globals.Date_k = Convert.ToDateTime(dateEdit2.Text);
            otchet.Show();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Globals.y = 4;
            Form otchet = new otchet();
            Globals.Date_n = Convert.ToDateTime(dateEdit1.Text);
            Globals.Date_k = Convert.ToDateTime(dateEdit2.Text);
            otchet.Show();
        }
    }
}
