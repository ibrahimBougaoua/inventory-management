
namespace inventory_management.PL.Client
{
    partial class Form_Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery3 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Client));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.colCust_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCust_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCust_Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCust_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Customers";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1239, 605);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCust_ID,
            this.colCust_Name,
            this.colCust_Address,
            this.colCust_Phone,
            this.colNotes});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Sales_System";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression11.ColumnName = "Cust_ID";
            table3.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"183\" />";
            table3.Name = "Customers";
            columnExpression11.Table = table3;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "Cust_Name";
            columnExpression12.Table = table3;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "Cust_Address";
            columnExpression13.Table = table3;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "Cust_Phone";
            columnExpression14.Table = table3;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "Notes";
            columnExpression15.Table = table3;
            column15.Expression = columnExpression15;
            selectQuery3.Columns.Add(column11);
            selectQuery3.Columns.Add(column12);
            selectQuery3.Columns.Add(column13);
            selectQuery3.Columns.Add(column14);
            selectQuery3.Columns.Add(column15);
            selectQuery3.Name = "Customers";
            selectQuery3.Tables.Add(table3);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // colCust_ID
            // 
            this.colCust_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colCust_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCust_ID.Caption = "ID";
            this.colCust_ID.FieldName = "Cust_ID";
            this.colCust_ID.Name = "colCust_ID";
            this.colCust_ID.Visible = true;
            this.colCust_ID.VisibleIndex = 0;
            this.colCust_ID.Width = 98;
            // 
            // colCust_Name
            // 
            this.colCust_Name.Caption = "Nom";
            this.colCust_Name.FieldName = "Cust_Name";
            this.colCust_Name.Name = "colCust_Name";
            this.colCust_Name.Visible = true;
            this.colCust_Name.VisibleIndex = 1;
            this.colCust_Name.Width = 144;
            // 
            // colCust_Address
            // 
            this.colCust_Address.Caption = "Adresse";
            this.colCust_Address.FieldName = "Cust_Address";
            this.colCust_Address.Name = "colCust_Address";
            this.colCust_Address.Visible = true;
            this.colCust_Address.VisibleIndex = 3;
            this.colCust_Address.Width = 144;
            // 
            // colCust_Phone
            // 
            this.colCust_Phone.Caption = "Téléphone";
            this.colCust_Phone.FieldName = "Cust_Phone";
            this.colCust_Phone.Name = "colCust_Phone";
            this.colCust_Phone.Visible = true;
            this.colCust_Phone.VisibleIndex = 2;
            this.colCust_Phone.Width = 144;
            // 
            // colNotes
            // 
            this.colNotes.Caption = "Notes";
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 4;
            this.colNotes.Width = 150;
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 605);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form_Client";
            this.Text = "Gestion des clients";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colCust_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCust_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colCust_Address;
        private DevExpress.XtraGrid.Columns.GridColumn colCust_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
    }
}