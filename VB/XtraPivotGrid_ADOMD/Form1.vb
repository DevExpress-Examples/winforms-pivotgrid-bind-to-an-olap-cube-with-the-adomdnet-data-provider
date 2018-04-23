Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace XtraPivotGrid_ADOMD
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			' Creates an ADOMD.NET datasource object that will be used
			' to access OLAP data.
			Dim ds As New PivotGridAdomdDataSource()

			' Configures a data connection.
			' Specifies a string that encapsulates connection parameters 
			' required to access the desired OLAP cube.
			' The DataHelper.GetCubePath static method returns the path to a local cube file
			' that will serve as a datasource.
			ds.ConnectionString = "Provider=msolap;Data Source=" & DataHelper.GetCubePath() & _
                ";Initial Catalog=Northwind;Cube Name=Northwind"

			' Assigns the configured ADOMD.NET datasource object to the pivot grid.
			pivotGridControl1.DataSource = ds
		End Sub
	End Class
End Namespace