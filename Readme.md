<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581591/12.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3705)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/XtraPivotGrid_ADOMD/Form1.cs) (VB: [Form1.vb](./VB/XtraPivotGrid_ADOMD/Form1.vb))
<!-- default file list end -->
# How to: Bind to an OLAP Cube Using the ADOMD.NET Data Provider


<p>The following example demonstrates how to bind <strong>PivotGridControl</strong> to an OLAP cube via the ADOMD.NET data provider.<br><br>See Also:<br><a href="https://www.devexpress.com/Support/Center/p/KA18860">KA18860: OLAP - The user credentials (Name, Password) specified in the connection string are ignored and the connection is established from the name of the current application user</a></p>


<h3>Description</h3>

<p>In this example, the PivotGridControl.OLAPDataProvider property is used to specify that PivotGridControl should use the ADOMD.NET data provider to access an OLAP cube. OLAP connection parameters are specified in a connection string passed to the PivotGridControl.OLAPConnectionString property. The following parameters are provided:</p><p><strong>Data Source</strong> - a path to a data pump that was previously configured on an IIS server and will be used as a middle-ware component to access the datasource.</p><p><strong>Initial Catalog</strong> - a data catalog that contains cubes. </p><p><strong>Cube Name</strong> - the name of the cube that provides OLAP data.</p><br />


<br/>


