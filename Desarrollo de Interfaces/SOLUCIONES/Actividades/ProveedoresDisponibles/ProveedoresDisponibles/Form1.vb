Imports System.Configuration
Imports System.Data.Common
Public Class Form1
    Dim conexion As DbConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DataSource = DbProviderFactories.GetFactoryClasses()
        ComboBox1.ValueMember = "InvariantName"
        ComboBox1.DisplayMember = "Name"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conexion = GetConnection(ComboBox1.SelectedValue)
        Try
            conexion.Open()
            MsgBox("La Conexión se estableció con éxito a " + ComboBox1.Text)
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub

    Private Function GetConnection(iname As String) As IDbConnection
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.DataSource = conexion.GetSchema("Tables")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim filtros(3) As String
        filtros(2) = "Mensajes"
        filtros(3) = "idMensaje"
        DataGridView1.DataSource = conexion.GetSchema("Columns", filtros)
    End Sub
End Class
