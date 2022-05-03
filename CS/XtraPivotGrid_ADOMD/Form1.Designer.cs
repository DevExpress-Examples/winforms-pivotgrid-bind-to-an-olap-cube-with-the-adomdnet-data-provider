namespace XtraPivotGrid_ADOMD
{
    partial class Form1
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
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.field = new DevExpress.XtraPivotGrid.PivotGridField();
            this.field1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.field2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.field,
            this.field1,
            this.field2});
            pivotGridGroup1.Caption = "Year - Month";
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.pivotGridControl1.Location = new System.Drawing.Point(12, 12);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1});
            this.pivotGridControl1.Size = new System.Drawing.Size(389, 321);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // field
            // 
            this.field.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.field.AreaIndex = 0;
            this.field.Caption = "Internet Sales Amount";
            dataSourceColumnBinding1.ColumnName = "[Measures].[Internet Sales Amount]";
            this.field.DataBinding = dataSourceColumnBinding1;
            this.field.Name = "field";
            // 
            // field1
            // 
            this.field1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.field1.AreaIndex = 0;
            this.field1.Caption = "Country";
            dataSourceColumnBinding2.ColumnName = "[Customer].[Country].[Country]";
            this.field1.DataBinding = dataSourceColumnBinding2;
            this.field1.Name = "field1";
            // 
            // field2
            // 
            this.field2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.field2.AreaIndex = 0;
            this.field2.Caption = "Fiscal Year";
            dataSourceColumnBinding3.ColumnName = "[Date].[Fiscal].[Fiscal Year]";
            this.field2.DataBinding = dataSourceColumnBinding3;
            this.field2.Name = "field2";
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemProgressBar1.DisplayFormat.FormatString = "{0}%";
            this.repositoryItemProgressBar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            this.repositoryItemProgressBar1.ShowTitle = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 345);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraPivotGrid.PivotGridField field;
        private DevExpress.XtraPivotGrid.PivotGridField field1;
        private DevExpress.XtraPivotGrid.PivotGridField field2;
    }
}

