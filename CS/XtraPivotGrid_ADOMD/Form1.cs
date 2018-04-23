using System;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace XtraPivotGrid_ADOMD {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        void Form1_Load(object sender, EventArgs e) {

            // Creates an ADOMD.NET datasource object that will be used
            // to access OLAP data.
            PivotGridAdomdDataSource ds = new PivotGridAdomdDataSource();

            // Configures a data connection.
            // Specifies a string that encapsulates connection parameters 
            // required to access the desired OLAP cube.
            // The DataHelper.GetCubePath static method returns the path to a local cube file
            // that will serve as a datasource.
            ds.ConnectionString = "Provider=msolap;Data Source=" + DataHelper.GetCubePath() +
                                  ";Initial Catalog=Northwind;Cube Name=Northwind";

            // Assigns the configured ADOMD.NET datasource object to the pivot grid.
            pivotGridControl1.DataSource = ds;
        }
    }
}