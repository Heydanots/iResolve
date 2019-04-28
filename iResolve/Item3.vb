Public Class Item3
    Function EstCeUnChiffre() As Boolean
        Dim Vrai As Boolean = True
        If Me.TextBox1.Text Is Nothing Or Not IsNumeric(Me.TextBox1.Text) Then
            Vrai = False
        End If
        Return Vrai
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EstCeUnChiffre() Then
            Dim Sin As Double
            'Activation
            Me.Label1.Visible = True
            Me.Label2.Visible = True
            Me.Label3.Visible = True
            Me.Label4.Visible = True

            Me.Label1.Text = "Sin : " & Math.Sin(Me.TextBox1.Text)
            Me.Label2.Text = "Cos : " & Math.Cos(Me.TextBox1.Text)
            Me.Label3.Text = "Tan : " & Math.Tan(Me.TextBox1.Text)
            Me.Label4.Text = "Cotang : " & Math.Atan(Me.TextBox1.Text)
        End If
    End Sub
End Class