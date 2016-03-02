Imports System.IO

Public Class frmCadastro

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Verifica_Compromisso(Integer.Parse(txtCompromisso.Text))
    End Sub



    Public Sub Verifica_Compromisso(dtDia As Integer)
        Dim strCompromisso As String = ""
        Dim dt As New DateTime(DateTime.Now.Year, DateTime.Now.Month, dtDia)

        If dtDia = 5 Then
            strCompromisso = "Dia do rodizio"
        End If

        If (dt.DayOfWeek.ToString("d") = "1") Or (dt.DayOfWeek.ToString("d") = "3") Then
            If Not String.IsNullOrEmpty(strCompromisso) Then
                strCompromisso += ", "
            End If
            strCompromisso += "Aula de Tae Kwon Do"
        End If

        If String.IsNullOrEmpty(strCompromisso) Then
            strCompromisso = "Não existem agendamentos"
        End If

        MessageBox.Show(strCompromisso)
    End Sub

End Class
