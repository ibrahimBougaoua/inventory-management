
namespace inventory_management.PL.Purchase
{
    partial class Form_Purchase
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Purchase));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.colOrder_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupp_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupp_Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupp_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Buy";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1338, 783);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrder_ID,
            this.colDate,
            this.colSupp_Name,
            this.colSupp_Address,
            this.colSupp_Phone,
            this.colNotes});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Sales_System";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "Order_ID";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"123\" />";
            table1.Name = "Buy";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Date";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "Supp_Name";
            table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"183\" />";
            table2.Name = "Suppliers";
            columnExpression3.Table = table2;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "Supp_Address";
            columnExpression4.Table = table2;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "Supp_Phone";
            columnExpression5.Table = table2;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "Notes";
            columnExpression6.Table = table2;
            column6.Expression = columnExpression6;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Name = "Buy";
            relationColumnInfo1.NestedKeyColumn = "Supp_ID";
            relationColumnInfo1.ParentKeyColumn = "Sup_ID";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // colOrder_ID
            // 
            this.colOrder_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colOrder_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrder_ID.Caption = "ID";
            this.colOrder_ID.FieldName = "Order_ID";
            this.colOrder_ID.Name = "colOrder_ID";
            this.colOrder_ID.Visible = true;
            this.colOrder_ID.VisibleIndex = 0;
            this.colOrder_ID.Width = 82;
            // 
            // colDate
            // 
            this.colDate.Caption = "Date";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 5;
            this.colDate.Width = 123;
            // 
            // colSupp_Name
            // 
            this.colSupp_Name.Caption = "Nom";
            this.colSupp_Name.FieldName = "Supp_Name";
            this.colSupp_Name.Name = "colSupp_Name";
            this.colSupp_Name.Visible = true;
            this.colSupp_Name.VisibleIndex = 1;
            this.colSupp_Name.Width = 117;
            // 
            // colSupp_Address
            // 
            this.colSupp_Address.Caption = "Adresse";
            this.colSupp_Address.FieldName = "Supp_Address";
            this.colSupp_Address.Name = "colSupp_Address";
            this.colSupp_Address.Visible = true;
            this.colSupp_Address.VisibleIndex = 2;
            this.colSupp_Address.Width = 117;
            // 
            // colSupp_Phone
            // 
            this.colSupp_Phone.Caption = "Téléphone";
            this.colSupp_Phone.FieldName = "Supp_Phone";
            this.colSupp_Phone.Name = "colSupp_Phone";
            this.colSupp_Phone.Visible = true;
            this.colSupp_Phone.VisibleIndex = 3;
            this.colSupp_Phone.Width = 117;
            // 
            // colNotes
            // 
            this.colNotes.Caption = "Notes";
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 4;
            this.colNotes.Width = 124;
            // 
            // Form_Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 783);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form_Purchase";
            this.Text = "Achats";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrder_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSupp_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colSupp_Address;
        private DevExpress.XtraGrid.Columns.GridColumn colSupp_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
    }
}