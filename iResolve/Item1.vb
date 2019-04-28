Public Class Item1
    'Toutes les fonctions utiles au fonctionnement du Premier Degré
    Function EstCeUnChiffre() As Boolean
        Dim Vrai As Boolean = True
        If Me.TextBox1.Text Is Nothing Or Not IsNumeric(Me.TextBox1.Text) Then
            Vrai = False
        End If
        If Me.TextBox2.Text Is Nothing Or Not IsNumeric(Me.TextBox2.Text) Then
            Vrai = False
        End If
        Return Vrai
    End Function
    Function PreDeg(ByVal A As Integer, ByVal B As Integer)
        Dim C As Integer
        C = (-1 * B) / A
        'Retourne la valeur de C
        Return C
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EstCeUnChiffre() Then
            Me.LabelAff.Visible = True
            Me.LabelAff.Text = "Le resultat final est : " & PreDeg(Me.TextBox1.Text, Me.TextBox2.Text)
        Else
            Me.LabelAff.Text = "Veillez entrez un nombre ou un chiffre"
        End If
    End Sub
End Class