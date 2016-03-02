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
        Me.txtCompromisso = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.panel2.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel2
        '
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.Controls.Add(Me.txtCompromisso)
        Me.panel2.Controls.Add(Me.label3)
        Me.panel2.Controls.Add(Me.label1)
        Me.panel2.Location = New System.Drawing.Point(-1, 183)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(225, 121)
        Me.panel2.TabIndex = 17
        '
        'txtCompromisso
        '
        Me.txtCompromisso.Location = New System.Drawing.Point(83, 76)
        Me.txtCompromisso.Name = "txtCompromisso"
        Me.txtCompromisso.Size = New System.Drawing.Size(100, 20)
        Me.txtCompromisso.TabIndex = 18
        Me.txtCompromisso.Text = "5"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(16, 83)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(23, 13)
        Me.label3.TabIndex = 15
        Me.label3.Text = "Dia"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.label1.Location = New System.Drawing.Point(16, 27)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(193, 16)
        Me.label1.TabIndex = 13
        Me.label1.Text = "Controle de compromissos"
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.btnVerificar)
        Me.panel1.Location = New System.Drawing.Point(-1, 232)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(505, 65)
        Me.panel1.TabIndex = 16
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(393, 12)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(101, 39)
        Me.btnVerificar.TabIndex = 14
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
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
    Private WithEvents txtCompromisso As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents btnVerificar As System.Windows.Forms.Button

End Class
