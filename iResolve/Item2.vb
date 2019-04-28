Public Class Item2
    Function EstCeUnChiffre() As Boolean
        Dim Vrai As Boolean = True
        If Me.TextBox1.Text Is Nothing Or Not IsNumeric(Me.TextBox1.Text) Then
            Vrai = False
        End If
        If Me.TextBox2.Text Is Nothing Or Not IsNumeric(Me.TextBox2.Text) Then
            Vrai = False
        End If
        If Me.TextBox3.Text Is Nothing Or Not IsNumeric(Me.TextBox3.Text) Then
            Vrai = False
        End If
        Return Vrai
    End Function
    Function PreDeg(ByVal A As Integer, ByVal B As Integer, ByVal C As Integer)
        Dim Delta, x1, x2 As Double
        Delta = Math.Sqrt(B) - 4 * (A * C)
        Delta = Delta ^ 0.5

        If Delta = 0 Then
            Me.LabelAff.Visible = True
            x1 = x2 - B / (2 * A)
            Me.LabelAff.Text = "Delta est égale à 0,Donc il y'a 1 racine : " & x1
        ElseIf Delta > 0 Then
            Me.LabelAff.Visible = True
            Me.LabelAff.Text = "Delta est superieur à 0, Donc il y'aura 2 racines Racine 1 : " & x1 = -B + Delta / (2 * A) & " Racine 2 : " & x2 = -B - Delta / (2 * A)
        Else
            Me.LabelAff.Visible = True
            Me.LabelAff.Text = "Delta est inferieur à 0, Dans cas il n'existe aucune racine"
        End If
        'Retourne la valeur de Delta
        Return Delta
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EstCeUnChiffre() Then
            PreDeg(Me.TextBox1.Text, Me.TextBox2.Text, Me.TextBox3.Text)
        Else
            Me.LabelAff.Visible = True
            Me.LabelAff.Text = "                                                    Entrez un nombre ou un chiffre"
        End If
    End Sub
End Class