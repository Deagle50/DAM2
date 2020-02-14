Imports Periódicos
Imports System.Xml.Serialization
Class Window1
    Dim prensa As Libreria
    Dim t() As Type = {GetType(Enlace)}
    Dim ser As New XmlSerializer(GetType(Libreria), t)
    Dim ds As System.Data.DataSet
    Dim pos As Integer
    Private Sub MenuItem_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        Dim en As Enlace = New Enlace(txtUrl.Text, TxtNombre.Text)
        CType(ComboBox1.ItemsSource, Libreria).Add(en)
    End Sub

    Private Sub Window1_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        prensa = ser.Deserialize(New System.IO.StreamReader("..\\..\\enlaces.xml"))
        ComboBox1.ItemsSource = prensa.Lista
        ComboBox1.SelectedIndex = 1
        UserControl11.DataContext = ds.Tables("item").DefaultView
    End Sub


    Private Sub ComboBox1_SelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox1.SelectionChanged
        ds = New System.Data.DataSet
        ds.ReadXml(prensa(sender.selectedindex).Source)
        If Not ds.Tables("image") Is Nothing Then
            Image1.DataContext = ds.Tables("image").DefaultView
        Else
            Image1.DataContext = Nothing
        End If

        UserControl11.DataContext = ds.Tables("item").DefaultView
        Grid1.DataContext = ds.Tables("item").DefaultView(0)
    End Sub

    Private Sub MenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        prensa.Clear()
    End Sub

    Private Sub MenuItem_Click_2(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        ser.Serialize(New System.IO.StreamWriter("enlaces.xml"), prensa)
    End Sub
   
    Private Sub UserControl11_IrInicio(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserControl11.IrInicio, UserControl11.IrFinal, UserControl11.Avanzar, UserControl11.Retroceder
        Grid1.DataContext = ds.Tables("item").DefaultView(UserControl11.Actual)
    End Sub
End Class
