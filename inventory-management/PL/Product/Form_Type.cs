﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_management.PL.Product
{
    public partial class Form_Type : DevExpress.XtraEditors.XtraForm
    {
        BL.Type.Type type = new BL.Type.Type();

        public Form_Type()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                type.add_Product_Type(txtName.Text);
                sqlDataSource1.FillAsync();
                txtName.Clear();
                txtName.Select();
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Added.wav");
                simpleSound.Play();
            }
            else
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\ValidationError.wav");
                simpleSound.Play();
            }
        }
    }
}