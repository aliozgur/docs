Imports System
Imports System.Xml
Imports System.Data
Imports System.Data.OracleClient
Imports System.Data.Common
Imports System.Windows.Forms



Public Class Form1
    Inherits Form
    Protected DataSet1 As DataSet
    Protected dataGrid1 As DataGrid
    
    
    
    ' <Snippet1>
Public Sub CreateOracleDbParameter()
    Dim parameter As New OracleParameter()
    parameter.ParameterName = "pDName"
    parameter.DbType = DbType.String
    parameter.Value = "ENGINEERING"
    parameter.SourceColumn = "DName"
End Sub 

    ' </Snippet1>
End Class 'Form1 