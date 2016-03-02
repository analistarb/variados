<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastro))
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.txtTamanhoLados = New System.Windows.Forms.TextBox()
        Me.txtNomeLados = New System.Windows.Forms.TextBox()
        Me.txtPoligono = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.panel2.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel2
        '
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.Controls.Add(Me.txtTamanhoLados)
        Me.panel2.Controls.Add(Me.txtNomeLados)
        Me.panel2.Controls.Add(Me.txtPoligono)
        Me.panel2.Controls.Add(Me.label3)
        Me.panel2.Controls.Add(Me.label2)
        Me.panel2.Controls.Add(Me.label1)
        Me.panel2.Location = New System.Drawing.Point(-1, 183)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(225, 121)
        Me.panel2.TabIndex = 17
        '
        'txtTamanhoLados
        '
        Me.txtTamanhoLados.Location = New System.Drawing.Point(107, 76)
        Me.txtTamanhoLados.Name = "txtTamanhoLados"
        Me.txtTamanhoLados.Size = New System.Drawing.Size(100, 20)
        Me.txtTamanhoLados.TabIndex = 18
        Me.txtTamanhoLados.Text = "2, 4, 6, 2, 8"
        '
        'txtNomeLados
        '
        Me.txtNomeLados.Location = New System.Drawing.Point(107, 50)
        Me.txtNomeLados.Name = "txtNomeLados"
        Me.txtNomeLados.Size = New System.Drawing.Size(100, 20)
        Me.txtNomeLados.TabIndex = 17
        Me.txtNomeLados.Text = "A, B, C, D, E"
        '
        'txtPoligono
        '
        Me.txtPoligono.Location = New System.Drawing.Point(107, 24)
        Me.txtPoligono.Name = "txtPoligono"
        Me.txtPoligono.Size = New System.Drawing.Size(100, 20)
        Me.txtPoligono.TabIndex = 16
        Me.txtPoligono.Text = "Pentagono"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(16, 83)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(87, 13)
        Me.label3.TabIndex = 15
        Me.label3.Text = "Tamanho(Lados)"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(16, 57)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(70, 13)
        Me.label2.TabIndex = 14
        Me.label2.Text = "Nome(Lados)"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(16, 27)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(50, 13)
        Me.label1.TabIndex = 13
        Me.label1.Text = "Polígono"
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.btnCalcular)
        Me.panel1.Location = New System.Drawing.Point(-1, 232)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(505, 65)
        Me.panel1.TabIndex = 16
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(393, 12)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(101, 39)
        Me.btnCalcular.TabIndex = 14
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'frmCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(504, 304)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadastro"
        Me.Text = "TEx Tecnologia"
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents txtTamanhoLados As System.Windows.Forms.TextBox
    Private WithEvents txtNomeLados As System.Windows.Forms.TextBox
    Private WithEvents txtPoligono As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents btnCalcular As System.Windows.Forms.Button

End Class
