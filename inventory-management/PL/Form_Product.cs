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
using System.Media;
using System.IO;
using System.Drawing.Imaging;

namespace inventory_management
{
    public partial class Form_Product : DevExpress.XtraEditors.XtraForm
    {
        BL.Product.Product product = new BL.Product.Product();
        int order_id = -1;
        int supp_old_id = -1;
        string btn = "";

        public Form_Product()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource2.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource3.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource4.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource5.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource7.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource8.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource9.FillAsync();

            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void Form_Product_Load(object sender, EventArgs e)
        {

        }

            //string Pro_Name,
            //string Ref,
            //int Box,
            //float Box_Price,
            //int Qty_Alert,
            //DateTime Production_Date,
            //DateTime Expiration_Date,
            //DateTime Waiting_period,
            //int Tax_ID,
            //int Ut_ID,
            //int Cate_ID,
            //int Fm_ID,
            //int Brand_ID
            
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {

                byte[] bytes;
                MemoryStream stream = new MemoryStream();
                imgProd.Image.Save(stream, ImageFormat.Jpeg);
                bytes = stream.ToArray();

                int product_id = product.add_Product(txtNomProd.Text,txtRefProd.Text, Convert.ToInt32(cbxCoulissant.EditValue), Convert.ToDecimal(cbxPrixCoulissant.EditValue), Convert.ToInt32(txtQteInit.EditValue), Convert.ToInt32(txtQteAlert.EditValue), DateTime.Now, DateTime.Now, DateTime.Now, bytes, Convert.ToInt32(txtTax.EditValue), Convert.ToInt32(txtUnit.EditValue), Convert.ToInt32(txtCateg.EditValue), Convert.ToInt32(txtFamille.EditValue), Convert.ToInt32(txtBrand.EditValue));
                product.add_Product_Barcode(txtCodeBar.Text, product_id);
                product.add_Product_Price(Convert.ToInt32(txtQteInit.EditValue), Convert.ToDecimal(txtPrixAchat.EditValue), Convert.ToDecimal(txtPrixDetail.EditValue), Convert.ToDecimal(txtPrixGros.EditValue), Convert.ToDecimal(txtPrixSuperGos.EditValue), product_id);
                product.add_Product_to_warehouse(Convert.ToInt32(txtQteInit.EditValue), Convert.ToInt32(cbxWareHouse.EditValue), product_id);

                if (supp_old_id != Convert.ToInt32(cbxSupp.EditValue))
                {
                    order_id = product.add_Product_order(Convert.ToInt32(cbxSupp.EditValue), DateTime.Now);
                    supp_old_id = Convert.ToInt32(cbxSupp.EditValue);
                }

                product.add_Product_order_details(order_id, Convert.ToInt32(cbxSupp.EditValue), product_id, DateTime.Now, Convert.ToInt32(txtQteInit.EditValue), "");
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Added.wav");
                simpleSound.Play();

                if( btn == "save_exit" )
                    this.Close();
            }
            else
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\ValidationError.wav");
                simpleSound.Play();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btn = "save_exit";
            this.btnAddNew_Click(sender, e);
        }

        private void btnAddFamille_Click(object sender, EventArgs e)
        {
            PL.Product.Form_Family family = new PL.Product.Form_Family();
            family.ShowDialog();
        }

        private void btnAddUnit_Click_1(object sender, EventArgs e)
        {
            PL.Product.Form_Unit unit = new PL.Product.Form_Unit();
            unit.ShowDialog();
        }

        private void btnAddCateg_Click(object sender, EventArgs e)
        {
            PL.Product.Form_Category cate = new PL.Product.Form_Category();
            cate.ShowDialog();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            PL.Product.Form_Brand brand = new PL.Product.Form_Brand();
            brand.ShowDialog();
        }

        private void btnADDtax_Click(object sender, EventArgs e)
        {
            PL.Product.Form_Tax tax = new PL.Product.Form_Tax();
            tax.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            PL.Product.Form_Warehouse warehouse = new PL.Product.Form_Warehouse();
            warehouse.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Form_Suppliers suppliers = new Form_Suppliers();
            suppliers.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            PL.Product.Form_Type type = new PL.Product.Form_Type();
            type.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtNomProd.Clear();
            txtRefProd.Clear();
            cbxCoulissant.Clear();
            cbxPrixCoulissant.Clear();
            txtQteInit.Clear();
            txtQteAlert.Clear();
            txtTax.Clear();
            txtUnit.Clear();
            txtCateg.Clear();
            txtFamille.Clear();
            txtBrand.Clear();
            txtCodeBar.Clear();
            txtQteInit.Clear();
            txtPrixAchat.Clear();
            txtPrixDetail.Clear();
            txtPrixGros.Clear();
            txtPrixSuperGos.Clear();
            txtQteInit.Clear();
            cbxWareHouse.Clear();
            cbxSupp.Clear();
            cbxSupp.Clear();
            txtQteInit.Clear();
            cbxTypeProd.Clear();
            imgProd.Image = null;
        }
    }
}