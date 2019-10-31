Imports System.Configuration
Imports System.Data.Common

Public Class Form1
    Dim conexion As DbConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ComboBox1.DataSource = DbProviderFactories.GetFactoryClasses()
        ComboBox1.ValueMember = "InvariantName"
        ComboBox1.DisplayMember = "Name"


    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        conexion = getConnection(ComboBox1.SelectedValue)
        Try
            conexion.Open()
            MsgBox("La conexión se estableció con éxito a " + ComboBox1.SelectedItem.ToString)
        Catch Ex As Exception
            MsgBox("Error al conectar")
        End Try
    End Sub

    Private Function getConnection(iname As String) As IDbConnection
        Dim cn As IDbConnection
        cn = DbProviderFactories.GetFactory(iname).CreateConnection
        Select Case iname
            Case "System.Data.Odbc"
                cn.ConnectionString = ConfigurationManager.ConnectionStrings("odbc").ConnectionString
            Case "System.Data.OleDb"
                cn.ConnectionString = ConfigurationManager.ConnectionStrings("oledb").ConnectionString
            Case "System.Data.SqlClient"
                cn.ConnectionString = ConfigurationManager.ConnectionStrings("sqlserver").ConnectionString
        End Select
        Return cn
    End Function

    Private Sub BtnTablas_Click(sender As Object, e As EventArgs) Handles btnTablas.Click
        DataGridView1.DataSource = conexion.GetSchema("Tables")
    End Sub
End Class
