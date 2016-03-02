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
        Me.txtHipotenusa = New System.Windows.Forms.TextBox()
        Me.txtCateto2 = New System.Windows.Forms.TextBox()
        Me.txtCateto1 = New System.Windows.Forms.TextBox()
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
        Me.panel2.Controls.Add(Me.txtHipotenusa)
        Me.panel2.Controls.Add(Me.txtCateto2)
        Me.panel2.Controls.Add(Me.txtCateto1)
        Me.panel2.Controls.Add(Me.label3)
        Me.panel2.Controls.Add(Me.label2)
        Me.panel2.Controls.Add(Me.label1)
        Me.panel2.Location = New System.Drawing.Point(-1, 183)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(225, 121)
        Me.panel2.TabIndex = 17
        '
        'txtHipotenusa
        '
        Me.txtHipotenusa.Location = New System.Drawing.Point(83, 76)
        Me.txtHipotenusa.Name = "txtHipotenusa"
        Me.txtHipotenusa.Size = New System.Drawing.Size(100, 20)
        Me.txtHipotenusa.TabIndex = 18
        Me.txtHipotenusa.Text = "10"
        '
        'txtCateto2
        '
        Me.txtCateto2.Location = New System.Drawing.Point(83, 50)
        Me.txtCateto2.Name = "txtCateto2"
        Me.txtCateto2.Size = New System.Drawing.Size(100, 20)
        Me.txtCateto2.TabIndex = 17
        Me.txtCateto2.Text = "8"
        '
        'txtCateto1
        '
        Me.txtCateto1.Location = New System.Drawing.Point(83, 24)
        Me.txtCateto1.Name = "txtCateto1"
        Me.txtCateto1.Size = New System.Drawing.Size(100, 20)
        Me.txtCateto1.TabIndex = 16
        Me.txtCateto1.Text = "6"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(16, 83)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(61, 13)
        Me.label3.TabIndex = 15
        Me.label3.Text = "Hipotenusa"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(16, 57)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(47, 13)
        Me.label2.TabIndex = 14
        Me.label2.Text = "Cateto 2"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(16, 27)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(47, 13)
        Me.label1.TabIndex = 13
        Me.label1.Text = "Cateto 1"
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
    Private WithEvents txtHipotenusa As System.Windows.Forms.TextBox
    Private WithEvents txtCateto2 As System.Windows.Forms.TextBox
    Private WithEvents txtCateto1 As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents btnCalcular As System.Windows.Forms.Button

End Class
