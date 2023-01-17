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
            Form_Customer frm = new Form_Customer();
            frm.ShowDialog();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_Suppliers frm = new Form_Suppliers();
            frm.ShowDialog();
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
    }
}
