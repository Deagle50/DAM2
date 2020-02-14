Partial Public Class UserControl1
    Public Event Avanzar As EventHandler
    Public Event Retroceder As EventHandler
    Public Event IrInicio As EventHandler
    Public Event IrFinal As EventHandler
    Private pos As Integer
    Public ReadOnly Property Actual() As Integer
        Get
            Return pos
        End Get
    End Property
    Public ReadOnly Property Total() As Integer
        Get
            If Not DataContext Is Nothing Then
                Return DataContext.count
            Else
                Return 0
            End If
        End Get
    End Property

    Private Sub Image1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs)
        pos = 0
        actualizar()
        RaiseEvent IrInicio(Me, New EventArgs)
    End Sub

    Private Sub actualizar()
        TextBlock1.Text = String.Format("{0} de {1}", Actual, Total)
    End Sub

    Private Sub Image2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs)
        If pos > 0 Then
            pos -= 1
            actualizar()
            RaiseEvent Retroceder(Me, New EventArgs)
        End If
    End Sub

    Private Sub Image3_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs)
        If pos < Total - 1 Then
            pos += 1
            actualizar()
            RaiseEvent Avanzar(Me, New EventArgs)
        End If
    End Sub

    Private Sub Image4_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs)
        pos = Total - 1
        actualizar()
        RaiseEvent IrFinal(Me, New EventArgs)
    End Sub
    Public Sub Rebobinar()
        pos = 0
    End Sub

End Class
