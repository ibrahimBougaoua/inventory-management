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
using DevExpress.XtraEditors;

namespace inventory_management
{
    public partial class Form_Customer : DevExpress.XtraEditors.XtraForm
    {
        int row;

        public Form_Customer()
        {
            InitializeComponent();
        }

        Database db = new Database();
        DataTable tb = new DataTable();

        public void AutoNumber()
        {
            tb.Clear();
            tb = db.readData("select max(Cust_ID) from Customers","");
            if ((tb.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {
                txtID.Text = "1";
            } else
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
            tb = db.readData("select * from Customers where Delete_at IS NULL", "");

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
            tb = db.readData("select * from Customers where Cust_ID = "+ id + "", "");

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

        private void Form_Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customerDataSet.Customers);
            AutoNumber();
        }

        private void textEdit5_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {

        }

        private void textEdit5_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void txtPohne_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(dxValidationProvider1.Validate())
            {
                db.exceuteData("insert into Customers (Cust_ID,Cust_Name,Cust_Address,Cust_Phone,Notes) Values (" + txtID.Text + ",'" + txtName.Text + "','" + memoAdress.Text + "','" + txtPhone.Text + "','" + txtNotes.Text + "')", "Effectué avec succès");
                AutoNumber();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.readData("update Customers set Cust_Name='"+txtName.Text + "',Cust_Address='"+memoAdress.Text + "',Cust_Phone='"+txtPhone.Text + "',Notes='"+txtNotes.Text + "' where Cust_ID = " + txtID.Text + "", "Effectué avec succès");
            AutoNumber();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("êtes-vous sûr ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //db.readData("delete Customers", "Effectué avec succès");
                db.readData("update Customers set Delete_at='" + DateTime.Now + "' where Cust_ID = " + txtID.Text + "", "Effectué avec succès");
                AutoNumber();
            }
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("êtes-vous sûr ?", "Confirmer",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //db.readData("delete Customers where Cust_ID = " + txtID.Text + "", "Effectué avec succès");
                db.readData("update Customers set Delete_at='" + DateTime.Now + "' where Cust_ID = " + txtID.Text + "", "Effectué avec succès");
                AutoNumber();
            }
        }

        private void btnRight2_Click(object sender, EventArgs e)
        {
            tb.Clear();
            tb = db.readData("select count(*) from Customers where Delete_at IS NULL","");
            row = Convert.ToInt32(tb.Rows[0][0]) - 1;
            Show();
            btnRight.Enabled = false;
            btnLeft.Enabled = true;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            tb = db.readData("select count(*) from Customers where Delete_at IS NULL", "");
            if( (Convert.ToInt32(tb.Rows[0][0]) - 1) > row )
            {
                row++;
                Show();
                btnLeft.Enabled = true;
            } else
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
            } else
            {
                btnLeft.Enabled = false;
            }
        }

        private void searchLookUpClient_EditValueChanged(object sender, EventArgs e)
        {
            object obj = searchLookUpClient.EditValue;
            //string text = searchLookUpClient.Text;
            //MessageBox.Show(obj.ToString());
            Get(Convert.ToInt32(obj));
        }

        private void searchLookUpClient_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
        }

        private void searchLookUpClient_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}