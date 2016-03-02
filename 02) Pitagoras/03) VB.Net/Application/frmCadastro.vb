Public Class frmCadastro

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        MessageBox.Show(Pitagoras(Integer.Parse(txtCateto1.Text), Integer.Parse(txtCateto2.Text), Integer.Parse(txtHipotenusa.Text)).ToString())
    End Sub


    Public Shared Function Pitagoras(cateto1 As Integer, cateto2 As Integer, hipotenusa As Integer) As Boolean
        Dim Valor1, Valor2 As Double

        Valor1 = Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2)
        Valor2 = Math.Pow(hipotenusa, 2)

        If Valor1 = Valor2 Then
            Return True
        Else
            Return False
        End If
    End Function


End Class
