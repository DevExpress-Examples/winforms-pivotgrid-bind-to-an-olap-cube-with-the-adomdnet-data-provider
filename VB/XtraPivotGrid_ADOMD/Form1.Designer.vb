Imports Microsoft.VisualBasic
Imports System
Namespace XtraPivotGrid_ADOMD
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim pivotGridGroup1 As New DevExpress.XtraPivotGrid.PivotGridGroup()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldInternetSalesAmount = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldFiscalYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldInternetSalesAmount, Me.fieldCountry, Me.fieldFiscalYear})
			pivotGridGroup1.Caption = "Year - Month"
			pivotGridGroup1.Hierarchy = Nothing
			pivotGridGroup1.ShowNewValues = True
			Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() { pivotGridGroup1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(12, 12)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemProgressBar1})
			Me.pivotGridControl1.Size = New System.Drawing.Size(389, 321)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' fieldInternetSalesAmount
			' 
			Me.fieldInternetSalesAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldInternetSalesAmount.AreaIndex = 0
			Me.fieldInternetSalesAmount.Caption = "Internet Sales Amount"
			Me.fieldInternetSalesAmount.FieldName = "[Measures].[Internet Sales Amount]"
			Me.fieldInternetSalesAmount.Name = "fieldInternetSalesAmount"
			' 
			' fieldCountry
			' 
			Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCountry.AreaIndex = 0
			Me.fieldCountry.Caption = "Country"
			Me.fieldCountry.FieldName = "[Customer].[Country].[Country]"
			Me.fieldCountry.Name = "fieldCountry"
			' 
			' fieldFiscalYear
			' 
			Me.fieldFiscalYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldFiscalYear.AreaIndex = 0
			Me.fieldFiscalYear.Caption = "Fiscal Year"
			Me.fieldFiscalYear.FieldName = "[Date].[Fiscal].[Fiscal Year]"
			Me.fieldFiscalYear.Name = "fieldFiscalYear"
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
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
		Private fieldInternetSalesAmount As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCountry As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldFiscalYear As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

