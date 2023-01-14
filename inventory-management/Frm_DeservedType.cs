﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace inventory_management
{
    public partial class Frm_DeservedType : DevExpress.XtraEditors.XtraForm
    {
        int row;
        public Frm_DeservedType()
        {
            InitializeComponent();
        }


        Database db = new Database();
        DataTable tb = new DataTable();

        public void AutoNumber()
        {
            tb.Clear();
            tb = db.readData("select max(Des_ID) from Deserved_Type", "");
            if ((tb.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {
                txtID.Text = "1";
            }
            else
            {
                txtID.Text = (Convert.ToInt32(tb.Rows[0][0]) + 1).ToString();
            }

            txtName.Clear();
          

            btnAdd.Enabled = true;
            btnRefresh.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            btnExit.Enabled = false;
            btnSave.Enabled = false;
        }

        public void Show()
        {
            tb.Clear();
            tb = db.readData("select * from Deserved_Type where Delete_at IS NULL", "");

            if (tb.Rows.Count <= 0)
            {
                MessageBox.Show("Aucune donnée sur cet écran");
            }
            else
            {
                txtID.Text = tb.Rows[row][0].ToString();
                txtName.Text = tb.Rows[row][1].ToString();
                

                btnAdd.Enabled = false;
                btnRefresh.Enabled = true;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;
                btnExit.Enabled = true;
                btnSave.Enabled = true;
            }

        }
        public void Get(int id)
        {
            tb.Clear();
            tb = db.readData("select * from Deserved_Type where Des_ID = " + id + "", "");

            if (tb.Rows.Count <= 0)
            {
                MessageBox.Show("Aucune donnée sur cet écran");
            }
            else
            {
                txtID.Text = tb.Rows[0][0].ToString();
                txtName.Text = tb.Rows[0][1].ToString();
            

                btnAdd.Enabled = false;
                btnRefresh.Enabled = true;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;
                btnExit.Enabled = true;
                btnSave.Enabled = true;
            }

        }

        private void Frm_DeservedType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deservedTypeDataSet.Deserved_Type' table. You can move, or remove it, as needed.
            this.deserved_TypeTableAdapter.Fill(this.deservedTypeDataSet.Deserved_Type);
            AutoNumber();
        }

        private void btnLeft2_Click(object sender, EventArgs e)
        {
            row = 0;
            Show();
            btnLeft.Enabled = false;
            btnRight.Enabled = true;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (row > 0)
            {
                row--;
                Show();
                btnRight.Enabled = true;
            }
            else
            {
                btnLeft.Enabled = false;
            }

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            tb = db.readData("select count(*) from Deserved_Type where Delete_at IS NULL", "");
            if ((Convert.ToInt32(tb.Rows[0][0]) - 1) > row)
            {
                row++;
                Show();
                btnLeft.Enabled = true;
            }
            else
            {
                btnRight.Enabled = false;
            }
        }

        private void btnRight2_Click(object sender, EventArgs e)
        {
            tb.Clear();
            tb = db.readData("select count(*) from Deserved_Type where Delete_at IS NULL", "");
            row = Convert.ToInt32(tb.Rows[0][0]) - 1;
            Show();
            btnRight.Enabled = false;
            btnLeft.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                db.exceuteData("insert into Deserved_Type (Des_ID,Name) Values (" + txtID.Text + ",'" + txtName.Text + "')", "Effectué avec succès");
                this.deserved_TypeTableAdapter.Fill(this.deservedTypeDataSet.Deserved_Type);
                AutoNumber();
            }
        }

        private void searchLookUpClient_EditValueChanged(object sender, EventArgs e)
        {
            object obj = searchLookUpClient.EditValue;
            //string text = searchLookUpClient.Text;
            //MessageBox.Show(obj.ToString());
            Get(Convert.ToInt32(obj));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            AutoNumber();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                db.exceuteData("update Deserved_Type set Name='" + txtName.Text + "' where Des_ID = " + txtID.Text + "", "Effectué avec succès");
                this.deserved_TypeTableAdapter.Fill(this.deservedTypeDataSet.Deserved_Type);
            }
                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("êtes-vous sûr ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //db.readData("delete Customers where Cust_ID = " + txtID.Text + "", "Effectué avec succès");
                db.readData("update Deserved_Type set Delete_at='" + DateTime.Now + "' where Des_ID = " + txtID.Text + "", "Effectué avec succès");
                AutoNumber();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("êtes-vous sûr ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //db.readData("delete Customers", "Effectué avec succès");
                db.readData("update Deserved_Type set Delete_at='" + DateTime.Now + "'", "Effectué avec succès");
                AutoNumber();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}