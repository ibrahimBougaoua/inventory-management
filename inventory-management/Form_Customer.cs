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
            tb = db.readData("select max(Cust_ID)+1 from Customers");
            if ((tb.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {
                txtNclient.Text = "1";
            } else
            {
                txtNclient.Text = tb.Rows[0][0].ToString();
            }
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
    }
}