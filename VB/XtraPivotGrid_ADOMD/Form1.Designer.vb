Namespace XtraPivotGrid_ADOMD

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim pivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
            Dim dataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.field = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.field1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.field2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.field, Me.field1, Me.field2})
            pivotGridGroup1.Caption = "Year - Month"
            Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {pivotGridGroup1})
            Me.pivotGridControl1.Location = New System.Drawing.Point(12, 12)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemProgressBar1})
            Me.pivotGridControl1.Size = New System.Drawing.Size(389, 321)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' field
            ' 
            Me.field.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.field.AreaIndex = 0
            Me.field.Caption = "Internet Sales Amount"
            dataSourceColumnBinding1.ColumnName = "[Measures].[Internet Sales Amount]"
            Me.field.DataBinding = dataSourceColumnBinding1
            Me.field.Name = "field"
            ' 
            ' field1
            ' 
            Me.field1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.field1.AreaIndex = 0
            Me.field1.Caption = "Country"
            dataSourceColumnBinding2.ColumnName = "[Customer].[Country].[Country]"
            Me.field1.DataBinding = dataSourceColumnBinding2
            Me.field1.Name = "field1"
            ' 
            ' field2
            ' 
            Me.field2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.field2.AreaIndex = 0
            Me.field2.Caption = "Fiscal Year"
            dataSourceColumnBinding3.ColumnName = "[Date].[Fiscal].[Fiscal Year]"
            Me.field2.DataBinding = dataSourceColumnBinding3
            Me.field2.Name = "field2"
            ' 
            ' repositoryItemProgressBar1
            ' 
            Me.repositoryItemProgressBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemProgressBar1.DisplayFormat.FormatString = "{0}%"
            Me.repositoryItemProgressBar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
            Me.repositoryItemProgressBar1.ShowTitle = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(413, 345)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar

        Private field As DevExpress.XtraPivotGrid.PivotGridField

        Private field1 As DevExpress.XtraPivotGrid.PivotGridField

        Private field2 As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace
