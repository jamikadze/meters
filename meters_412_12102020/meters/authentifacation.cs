using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using meters.Properties;

namespace meters
{
    public partial class authentifacation : DevExpress.XtraEditors.XtraForm
    {
        public authentifacation()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                //this.usersTableAdapter.Fill("jjj", "jjj");
                this.usersTableAdapter.FillByUserProga(this.mMSDataSet.Users, textBoxLogin.Text.Trim(), textBoxPass.Text.Trim());
                if (mMSDataSet != null && mMSDataSet.Users.Count() > 0)
                {
                    Settings.Default.UserNowName = textBoxLogin.Text;
                    Globals.id_user = (int)((DataRowView)usersBindingSource.Current).Row["id"];
                    Globals.name_user = (string)((DataRowView)usersBindingSource.Current).Row["first_last_name"];
                    Globals.userId4SCM=(int)((DataRowView)usersBindingSource.Current).Row["userId4SCM"];

                    Globals.id_slujbi = (int)((DataRowView)usersBindingSource.Current).Row["id_slujba"];
                    Globals.name_slujbi = (string)((DataRowView)usersBindingSource.Current).Row["name_slujba"];
                    Globals.id_access = (int)((DataRowView)usersBindingSource.Current).Row["id_access"];
                    Globals.main_menu = 1;
                    Settings.Default.Save();
                    Close();
                    //if (Globals.id_access == 1)
                    //{
                    //    Globals.main_menu= 1;
                    //    Settings.Default.Save();
                    //    Close();
                    //}
                    //if (Globals.id_access == 2)
                    //{
                    //    Globals.main_menu = 2;
                    //    Settings.Default.Save();
                    //    Close();
                    //}
                    //if (Globals.id_access == 3)
                    //{
                    //    Globals.main_menu = 3;
                    //    Settings.Default.Save();
                    //    Close();
                    //}
                    //if (Globals.id_access == 4)
                    //{
                    //    Globals.main_menu = 4;
                    //    Settings.Default.Save();
                    //    Close();
                    //}
                    //if (Globals.id_access == 5)
                    //{
                    //    Globals.main_menu = 5;
                    //    Settings.Default.Save();
                    //    Close();
                    //}
                   

                }
                else
                {
                    textBoxLogin.SelectAll();
                    //textBoxPass.();
                    textBoxLogin.Focus();
                    labelControl3.Visible = true;
                    pictureBox1.Visible = false;
                }

            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMSDataSet);

        }

        private void authentifacation_Load(object sender, EventArgs e)
        {
            labelControl3.Visible = false;
            textBoxLogin.Text = Settings.Default.UserNowName;

        }

        private void textBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton2_Click(null, null);
            }
        }
    }
}