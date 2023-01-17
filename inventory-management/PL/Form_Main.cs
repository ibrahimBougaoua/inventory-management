using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inventory_management
{
    public partial class Form_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form formToOpen = isActive(typeof(PL.Client.Form_Client));
            if (formToOpen == null) // if form is not open create it
            {
                PL.Client.Form_Client client = new PL.Client.Form_Client();
                client.MdiParent = this;
                client.Show();
            }
            else  // else it's open so open it
            {
                formToOpen.Activate();
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form formToOpen = isActive(typeof(PL.Suppliers.Form_Supplier));
            if (formToOpen == null) // if form is not open create it
            {
                PL.Suppliers.Form_Supplier supplier = new PL.Suppliers.Form_Supplier();
                supplier.MdiParent = this;
                supplier.Show();
            }
            else  // else it's open so open it
            {
                formToOpen.Activate();
            }
        }

        private void skinRibbonGalleryBarItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private Form isActive(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form formToOpen = isActive(typeof(PL.Purchase.Form_Purchase));
            if (formToOpen == null) // if form is not open create it
            {
                PL.Purchase.Form_Purchase purchase = new PL.Purchase.Form_Purchase();
                purchase.MdiParent = this;
                purchase.Show();
            }
            else  // else it's open so open it
            {
                formToOpen.Activate();
            }
        }

        private void barButtonItem44_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_Customer customer = new Form_Customer();
            customer.ShowDialog();
        }

        private void barButtonItem45_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_Suppliers supplier = new Form_Suppliers();
            supplier.ShowDialog();
        }
    }
}
