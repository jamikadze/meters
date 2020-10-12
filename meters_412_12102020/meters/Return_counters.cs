using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace meters
{
    public partial class Return_counters : DevExpress.XtraEditors.XtraUserControl
    {
        int? id_MMOL;
        int? id_MOL;
        public Return_counters()
        {
            InitializeComponent();
        }

        private void Return_counters_Load(object sender, EventArgs e)
        {
            this.spr_MeterTypeTableAdapter.FillByUmnye(this.mMSDataSet.spr_MeterType);
            int i = sprMeterTypeBindingSource.Count;
            // TODO: This line of code loads data into the 'mMSDataSet.spr_ReturnReason' table. You can move, or remove it, as needed.
            this.spr_ReturnReasonTableAdapter.Fill(this.mMSDataSet.spr_ReturnReason);
            // TODO: This line of code loads data into the 'mMSDataSet.Shipments' table. You can move, or remove it, as needed.
            //this.shipmentsTableAdapter.Fill(this.mMSDataSet.Shipments);//
            // TODO: This line of code loads data into the 'mMSDataSet.MeterMOLdocs2' table. You can move, or remove it, as needed.
            this.meterMOLdocs2TableAdapter.FillByIDMeterMOLDoc2(this.mMSDataSet.MeterMOLdocs2, Globals.id_doc_meter_mol_docs);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Executor' table. You can move, or remove it, as needed.
            //this.spr_ExecutorTableAdapter.FillBy_id_slujba(this.mMSDataSet.spr_Executor, Globals.id_slujbi);
            this.spr_ExecutorTableAdapter.Fill(this.mMSDataSet.spr_Executor);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_MMOL' table. You can move, or remove it, as needed.
            this.spr_MMOLTableAdapter.Fill(this.mMSDataSet.spr_MMOL);
            // TODO: This line of code loads data into the 'mMSDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.mMSDataSet.Users);
            // TODO: This line of code loads data into the 'mMSDataSet.MeterMOLdocs' table. You can move, or remove it, as needed.
            this.meterMOLdocsTableAdapter.FillByReturn(this.mMSDataSet.MeterMOLdocs);
            groupControl3.Visible = false;
            this.spr_SlujbaTableAdapter1.FillByRES(this.mMSDataSet.spr_Slujba);
            Delegate.RemoveAll(Globals.en_delegate_return, Globals.en_delegate_return);
            Globals.en_delegate_return = visible_main1;
        }
        private void visible_main1()
        {
            this.spr_MeterTypeTableAdapter.FillByUmnye(this.mMSDataSet.spr_MeterType);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_ReturnReason' table. You can move, or remove it, as needed.
            this.spr_ReturnReasonTableAdapter.Fill(this.mMSDataSet.spr_ReturnReason);
            // TODO: This line of code loads data into the 'mMSDataSet.Shipments' table. You can move, or remove it, as needed.
            //this.shipmentsTableAdapter.Fill(this.mMSDataSet.Shipments);//
            // TODO: This line of code loads data into the 'mMSDataSet.MeterMOLdocs2' table. You can move, or remove it, as needed.
            this.meterMOLdocs2TableAdapter.FillByIDMeterMOLDoc2(this.mMSDataSet.MeterMOLdocs2, Globals.id_doc_meter_for_main);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_Executor' table. You can move, or remove it, as needed.
            this.spr_ExecutorTableAdapter.Fill(this.mMSDataSet.spr_Executor);
            // TODO: This line of code loads data into the 'mMSDataSet.spr_MMOL' table. You can move, or remove it, as needed.
            this.spr_MMOLTableAdapter.Fill(this.mMSDataSet.spr_MMOL);
            // TODO: This line of code loads data into the 'mMSDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.mMSDataSet.Users);
            // TODO: This line of code loads data into the 'mMSDataSet.MeterMOLdocs' table. You can move, or remove it, as needed.
            this.spr_SlujbaTableAdapter1.FillByRES(this.mMSDataSet.spr_Slujba);
            this.meterMOLdocsTableAdapter.FillByReturn(this.mMSDataSet.MeterMOLdocs);
            this.meterMOLdocs2TableAdapter.FillByIDMeterMOLDoc2(this.mMSDataSet.MeterMOLdocs2, Globals.id_doc_meter_for_main);
            meterMOLdocs2BindingSource.MoveLast();


        }

        private void lookUpEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_MMOL = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
            }
        }

        private void lookUpEdit2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_MOL = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dateEdit1.Text = "";
            lookUpEdit1.EditValue = null;
            lookUpEdit2.EditValue = null;
            groupControl3.Visible = false;
        }

      

        private void simpleButton3_Click(object sender, EventArgs e)
        {
             try
            {
                if (dateEdit1.Text != "" && lookUpEdit1.Text != "" && lookUpEdit2.Text != "")
                {
                    DateTime? date = Convert.ToDateTime(dateEdit1.Text);
                    int? id_user = Globals.id_user;
                    int? id_current_doc = Globals.id_current_doc;
                    queriesTableAdapter1.insert_MeterMOLdocs(date, id_MOL, id_MMOL, id_user, ref id_current_doc, 1);
                    this.meterMOLdocsTableAdapter.FillByReturn(this.mMSDataSet.MeterMOLdocs);
                    meterMOLdocsBindingSource.MoveLast();
                    dateEdit1.Text = "";
                    lookUpEdit1.EditValue = null;
                    lookUpEdit2.EditValue = null;
                   
                     groupControl3.Visible=true;
                     groupBox1.Visible = false;
                     radioButton4.Checked=true;
                     textBox1.Focus();

                }
                else { MessageBox.Show("Не все поля заполнены"); }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

          

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            int id_shipments;
            if (lookUpEdit3.Text != "" && textEdit2.Text != "")
            {
                Globals.znum = textEdit2.Text;
                this.shipmentsTableAdapter.FillByShipments(this.mMSDataSet.Shipments, Globals.znum, Globals.id_meter_type);
                if (shipmentsBindingSource.Count > 0)
               {

                   id_shipments = Convert.ToInt32(((DataRowView)shipmentsBindingSource.Current).Row["id"]);


                    //this.meterMOLdocs2TableAdapter.FillBy(this.mMSDataSet.MeterMOLdocs2, id_shipments);
                    //if (meterMOLdocs2BindingSource.Count == 0)
                    try
                        {
                     this.meterMOLdocs2_poiskTableAdapter.FillBy_lastRetunReason(this.mMSDataSet.MeterMOLdocs2_poisk, Globals.znum);
                            
                             if (this.mMSDataSet.MeterMOLdocs2_poisk.Rows.Count != 0)
                        {
                            
                            foreach (DataRow tr in mMSDataSet.MeterMOLdocs2_poisk.Rows)
                            {
                             
                                if ((tr[3].ToString().Equals("") || tr[3].ToString().Equals("NULL")))
                                {
                                    queriesTableAdapter1.insert_one_meter_MeterMOLdocs2(Globals.id_doc_meter_mol_docs, id_shipments);
                                this.shipmentsTableAdapter.UpdateStatus_returned(id_shipments);
                                
                                }
                                else
                               {
                               MessageBox.Show("Этот счетчик " + Globals.znum + "нельзя вернуть повторно. Возможно он уже возвращен, \nсмотрите последний статус");
                                    return;
                               }
                             }
                    
                           }
                                 else 
                                 {
                                  MessageBox.Show("Этот счетчик " + Globals.znum + "нельзя вернуть. Он ни разу не выдавался");
                                    return;
                                 }
                                
                            }
                        
                        catch (Exception ex) { MessageBox.Show(ex.ToString()); }

                    }
                               
                else { MessageBox.Show("Нет такого счетчика " + Globals.znum + " в Shipments"); }
            }
            else {
                MessageBox.Show("Не все поля заполнены"); 
            }
            lookUpEdit3.EditValue = null; textEdit2.Text = "";
            lookUpEdit3.Focus();
            this.meterMOLdocs2TableAdapter.FillByIDMeterMOLDoc2(this.mMSDataSet.MeterMOLdocs2, Globals.id_doc_meter_mol_docs);
            meterMOLdocs2BindingSource.MoveLast();
        }

        

       

        private void radioButton4_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                groupBox1.Visible = false;
                textBox1.Visible = true;
                radioButton3.Checked = false;
            }
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                groupBox1.Visible = true;
                textBox1.Visible = false;
                radioButton4.Checked = false;
                lookUpEdit3.Focus();
            }
        }

        private void lookUpEdit3_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                Globals.id_meter_type = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_Type");
            }
          
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно \nхотите закрыть дркумент \nи сформировать накладной???", "Внимание!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.meterMOLdocsTableAdapter.UpdateStatus(Globals.id_doc_meter_mol_docs);
                Form S = new ReturnMeters();
                S.Show();

            }
        }

     

        private void textEdit2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton4_Click(null, null);
            }
        }

        private void meterMOLdocsBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.id_doc_meter_mol_docs = Convert.ToInt32(((DataRowView)meterMOLdocsBindingSource.Current).Row["id"]);
                Globals.Date_return = Convert.ToDateTime(((DataRowView)meterMOLdocsBindingSource.Current).Row["Date"]);
                Globals.NameExportReturn = Convert.ToInt32(((DataRowView)meterMOLdocsBindingSource.Current).Row["id_Executor_Exporter"]);
                Globals.NameImportReturn = Convert.ToInt32(((DataRowView)meterMOLdocsBindingSource.Current).Row["id_Executor_Importer"]);
                if ((((DataRowView)meterMOLdocsBindingSource.Current).Row["doc_status"]) is DBNull) { Globals.meter_doc_status = false; }
                else { Globals.meter_doc_status = Convert.ToBoolean(((DataRowView)meterMOLdocsBindingSource.Current).Row["doc_status"]); }
                this.meterMOLdocs2TableAdapter.FillByIDMeterMOLDoc2(this.mMSDataSet.MeterMOLdocs2, Globals.id_doc_meter_mol_docs);
            }
            catch { }
        }

        private void добавитьСчетчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.meter_doc_status == false)
            {
                groupControl3.Visible = true;
                radioButton4.Checked = true;
                textBox1.Visible = true;
                groupBox1.Visible = false;
            }
            else { MessageBox.Show("Нельзя добавить к этому документу счетчик он уже закрыт!!!"); }
        }

        private void сменаСтатусаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form d = new Shipments_status();
            d.Show();          
        }

        private void meterMOLdocs2BindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {

                Globals.id_Shipments= Convert.ToInt32(((DataRowView)meterMOLdocs2BindingSource.Current).Row["id_Shipments"]);
                Globals.id_sim = Convert.ToInt32(((DataRowView)meterMOLdocs2BindingSource.Current).Row["sim_id"]);
               //    shipmentsBindingSource.Current).Row["id_Shipments"]);//

              //  Globals.id_sim= Convert.ToInt32(((DataRowView)shipmentsBindingSource.Current).Row["Expr1"]);
            }
            catch { }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 23)
            {
                Globals.str = textBox1.Text;
                Globals.wtr = Globals.str.Substring(0, 3);
                Globals.znum = Globals.str.Substring(15, 8);

                this.spr_MeterTypeTableAdapter.FillByTYPE_meter(this.mMSDataSet.spr_MeterType, Globals.wtr);
                if (sprMeterTypeBindingSource.Count > 0)
                {
                    Globals.id_meter_type = Convert.ToInt32(((DataRowView)sprMeterTypeBindingSource.Current).Row["id_Type"]);
                    this.shipmentsTableAdapter.FillByShipments(this.mMSDataSet.Shipments, Globals.znum, Globals.id_meter_type);
                    if (shipmentsBindingSource.Count > 0)
                    {
                        int id_shipments = Convert.ToInt32(((DataRowView)shipmentsBindingSource.Current).Row["id"]);
                        try
                        {
                            this.meterMOLdocs2_poiskTableAdapter.FillBy_lastRetunReason(this.mMSDataSet.MeterMOLdocs2_poisk, Globals.znum);

                            if (this.mMSDataSet.MeterMOLdocs2_poisk.Rows.Count != 0)
                            {

                                foreach (DataRow tr in mMSDataSet.MeterMOLdocs2_poisk.Rows)
                                {

                                    if ((tr[3].ToString().Equals("") || tr[3].ToString().Equals("NULL")))
                                    {
                                        queriesTableAdapter1.insert_one_meter_MeterMOLdocs2(Globals.id_doc_meter_mol_docs, id_shipments);
                                        this.shipmentsTableAdapter.UpdateStatus_returned(id_shipments);
                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show("Этот счетчик " + Globals.znum + "нельзя вернуть повторно. Возможно он уже возвращен, \nсмотрите последний статус");
                                        return;
                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("Этот счетчик " + Globals.znum + "нельзя вернуть. Он ни разу не выдавался");
                                return;
                            }

                        }

                        catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                        //int id_shipments = Convert.ToInt32(((DataRowView)shipmentsBindingSource.Current).Row["id"]);

                        //this.meterMOLdocs2TableAdapter.FillByIdShipments(this.mMSDataSet.MeterMOLdocs2, id_shipments);
                        //if (meterMOLdocs2BindingSource.Count == 0)
                        //{
                        //    MessageBox.Show("Этот счетчик " + Globals.znum + "нельзя вернуть. Он ни разу не выдавался");
                        //}
                        //else
                        //{

                        //    try
                        //    {
                        //        queriesTableAdapter1.insert_one_meter_MeterMOLdocs2(Globals.id_doc_meter_mol_docs, id_shipments);
                        //        this.shipmentsTableAdapter.UpdateStatus_returned(id_shipments);
                        //    }
                        //    catch (Exception ex) { MessageBox.Show(ex.ToString()); }

                        //}

                    }
                    else { MessageBox.Show("Нет такого счетчика " + Globals.znum + " в Shipments"); }
                }

                else
                {
                    MessageBox.Show("Нет такого типа. Позвоните на 64-23, чтобы завели в справочник");
                }
            }
                else
                {
                    MessageBox.Show("Штрих код не совподает!");
                    return;
            }
                textBox1.Text = "";
                textBox1.Focus();
                this.meterMOLdocs2TableAdapter.FillByIDMeterMOLDoc2(this.mMSDataSet.MeterMOLdocs2, Globals.id_doc_meter_mol_docs);
                meterMOLdocs2BindingSource.MoveLast();
            
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
         (e.KeyChar != '0') &&
         (e.KeyChar != '1') &&
         (e.KeyChar != '2') &&
         (e.KeyChar != '3') &&
         (e.KeyChar != '4') &&
         (e.KeyChar != '5') &&
         (e.KeyChar != '6') &&
         (e.KeyChar != '7') &&
         (e.KeyChar != '8') &&
         (e.KeyChar != '9')

       )
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox11_TextChanged(null, null);
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lookUpEdit4_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                Globals.id_slujbi = (int)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");
                this.spr_ExecutorTableAdapter.FillBy_id_slujba(this.mMSDataSet.spr_Executor, Globals.id_slujbi);
            }
        }

       
        
    }
}
