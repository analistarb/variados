Imports System.IO

Public Class frmCadastro

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Triangulos(Integer.Parse(txtX.Text), Integer.Parse(txtY.Text), Integer.Parse(txtZ.Text))
    End Sub


    Public Sub Triangulos(X As Integer, Y As Integer, Z As Integer)
        If (X < Y + Z) AndAlso (Y < X + Z) AndAlso (Z < X + Y) Then
            If (X = Y) AndAlso (X = Z) Then
                MessageBox.Show("Triângulo Equilátero")
                ImagemTriangulo(0)
            ElseIf (X <> Y) AndAlso (X <> Z) AndAlso (Y <> Z) Then
                MessageBox.Show("Triângulo Escaleno")
                ImagemTriangulo(1)
            Else
                MessageBox.Show("Triângulo Isósceles")
                ImagemTriangulo(2)
            End If
        Else
            Limpar()
        End If
    End Sub


    Public Sub ImagemTriangulo(Indice As Integer)
        Dim strDiretorio As String = Directory.GetParent(System.Windows.Forms.Application.StartupPath).Parent.FullName

        If Indice = 0 Then
            picBox.Image = Image.FromFile(strDiretorio & "\equilatero.png")
            picBox.Location = New Point(336, 64)
        ElseIf Indice = 1 Then
            picBox.Image = Image.FromFile(strDiretorio & "\escaleno.png")
            picBox.Location = New Point(306, 81)
        ElseIf Indice = 2 Then
            picBox.Image = Image.FromFile(strDiretorio & "\isosceles.png")
            picBox.Location = New Point(375, 56)
        End If
        picBox.Visible = True
    End Sub


    Public Sub Limpar()
        txtX.Clear()
        txtY.Clear()
        txtZ.Clear()
        picBox.Visible = False
        MessageBox.Show("Atenção, estas medidas não formam um triângulo")
    End Sub


End Class
