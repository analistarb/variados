Imports System.IO

Public Class frmCadastro

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim array1 As [String]() = txtNomeLados.Text.Split(","c)
        Dim array2 As [String]() = txtTamanhoLados.Text.Split(","c)


        If array1.Count() = array2.Count() Then
            Dim strMensagem As String = ""
            Dim meuPoligono As New Poligono()
            meuPoligono.Nome = txtPoligono.Text

            For i As Integer = 0 To array1.Length - 1
                Dim lado As New Lado()
                lado.Nome = array1(i)
                lado.Tamanho = Integer.Parse(array2(i))
                meuPoligono.Lados.Add(lado)
            Next


            For Each c In meuPoligono.Lados
                strMensagem += vbLf & " (Lado: " + c.Nome + ", tamanho: " + c.Tamanho.ToString() + ")"
            Next

            strMensagem = "Poligono: " + meuPoligono.Nome + vbLf + strMensagem.ToString() + ""
            strMensagem += vbLf + vbLf + "Quantidade de Lados: " + meuPoligono.GetQtdLados().ToString()

            MessageBox.Show(strMensagem)
        Else
            MessageBox.Show("Atenção, favor preencher as duas listas com a mesma quantidade de itens")
        End If
    End Sub


End Class
