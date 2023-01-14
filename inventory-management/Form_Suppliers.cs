using DevExpress.XtraEditors;
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
    public partial class Form_Suppliers : DevExpress.XtraEditors.XtraForm
    {
        int row;

        public Form_Suppliers()
        {
            InitializeComponent();
        }

        Database db = new Database();
        DataTable tb = new DataTable();

        public void AutoNumber()
        {
            tb.Clear();
            tb = db.readData("select max(Supp_ID) from Suppliers", "");
            if ((tb.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {
                txtID.Text = "1";
            }
            else
            {
                txtID.Text = (Convert.ToInt32(tb.Rows[0][0]) + 1).ToString();
            }

            txtName.Clear();
            txtNotes.Clear();
            txtPhone.Clear();
            memoAdress.Clear();

            btnAdd.Enabled = true;
            btnRefresh.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            btnSave.Enabled = false;
        }

        public void Show()
        {
            tb.Clear();
            tb = db.readData("select * from Suppliers where Delete_at IS NULL", "");

            if (tb.Rows.Count <= 0)
            {
                MessageBox.Show("Aucune donnée sur cet écran");
            }
            else
            {
                txtID.Text = tb.Rows[row][0].ToString();
                txtName.Text = tb.Rows[row][1].ToString();
                memoAdress.Text = tb.Rows[row][2].ToString();
                txtPhone.Text = tb.Rows[row][3].ToString();
                txtNotes.Text = tb.Rows[row][4].ToString();

                btnAdd.Enabled = false;
                btnRefresh.Enabled = true;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;
                btnSave.Enabled = true;
            }

        }
        public void Get(int id)
        {
            tb.Clear();
            tb = db.readData("select * from Suppliers where Supp_ID = " + id + "", "");

            if (tb.Rows.Count <= 0)
            {
                MessageBox.Show("Aucune donnée sur cet écran");
            }
            else
            {
                txtID.Text = tb.Rows[0][0].ToString();
                txtName.Text = tb.Rows[0][1].ToString();
                memoAdress.Text = tb.Rows[0][2].ToString();
                txtPhone.Text = tb.Rows[0][3].ToString();
                txtNotes.Text = tb.Rows[0][4].ToString();

                btnAdd.Enabled = false;
                btnRefresh.Enabled = true;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;
                btnSave.Enabled = true;
            }

        }

        private void txtPhone_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
            db.exceuteData("insert into Suppliers (Supp_ID,Supp_Name,Supp_Address,Supp_Phone,Notes) Values (" + txtID.Text + ",'" + txtName.Text + "','" + memoAdress.Text + "','" + txtPhone.Text + "','" + txtNotes.Text + "')", "Effectué avec succès");
            AutoNumber();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.readData("update Suppliers set Supp_Name='" + txtName.Text + "',Supp_Address='" + memoAdress.Text + "',Supp_Phone='" + txtPhone.Text + "',Notes='" + txtNotes.Text + "' where Supp_ID = " + txtID.Text + "", "Effectué avec succès");
            AutoNumber();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("êtes-vous sûr ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //db.readData("delete Customers where Cust_ID = " + txtID.Text + "", "Effectué avec succès");
                db.readData("update Suppliers set Delete_at='" + DateTime.Now + "' where Supp_ID = " + txtID.Text + "", "Effectué avec succès");
                AutoNumber();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("êtes-vous sûr ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //db.readData("delete Customers", "Effectué avec succès");
                db.readData("update Suppliers set Delete_at='" + DateTime.Now + "' where Supp_ID = " + txtID.Text + "", "Effectué avec succès");
                AutoNumber();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRight2_Click(object sender, EventArgs e)
        {
            tb.Clear();
            tb = db.readData("select count(*) from Suppliers where Delete_at IS NULL", "");
            row = Convert.ToInt32(tb.Rows[0][0]) - 1;
            Show();
            btnRight.Enabled = false;
            btnLeft.Enabled = true;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            tb = db.readData("select count(*) from Suppliers where Delete_at IS NULL", "");
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

        private void Form_Suppliers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supplierDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.supplierDataSet.Suppliers);

        }

        private void searchLookUpClient_EditValueChanged(object sender, EventArgs e)
        {
            object obj = searchLookUpClient.EditValue;
            //string text = searchLookUpClient.Text;
            //MessageBox.Show(obj.ToString());
            Get(Convert.ToInt32(obj));
        }
    }
}