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
    public partial class Form_Customer : DevExpress.XtraEditors.XtraForm
    {
        public Form_Customer()
        {
            InitializeComponent();
        }

        Database db = new Database();
        DataTable tb = new DataTable();

        public void AutoNumber()
        {
            tb = db.readData("select max(Cust_ID) from Customers");
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
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            btnExit.Enabled = false;
            btnSave.Enabled = false;
            btnRefresh.Enabled = true;
        }

        private void Form_Customer_Load(object sender, EventArgs e)
        {
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

        }

        private void txtPohne_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.exceuteData("insert into Customers Values ("+txtID.Text+",'"+txtName.Text+"','"+ memoAdress.Text+ "','"+txtPhone.Text+"','"+ txtNotes.Text+"')", "Effectué avec succès");
            AutoNumber();
        }
    }
}