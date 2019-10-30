Imports System.Data.Common
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        DataGridView1.DataSource = DbProviderFactories.GetFactoryClasses()
    End Sub
End Class
