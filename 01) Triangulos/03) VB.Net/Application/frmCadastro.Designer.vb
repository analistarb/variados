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
        Me.txtZ = New System.Windows.Forms.TextBox()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.picBox = New System.Windows.Forms.PictureBox()
        Me.panel2.SuspendLayout()
        Me.panel1.SuspendLayout()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel2
        '
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.Controls.Add(Me.txtZ)
        Me.panel2.Controls.Add(Me.txtY)
        Me.panel2.Controls.Add(Me.txtX)
        Me.panel2.Controls.Add(Me.label3)
        Me.panel2.Controls.Add(Me.label2)
        Me.panel2.Controls.Add(Me.label1)
        Me.panel2.Location = New System.Drawing.Point(-1, 183)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(225, 121)
        Me.panel2.TabIndex = 17
        '
        'txtZ
        '
        Me.txtZ.Location = New System.Drawing.Point(83, 76)
        Me.txtZ.Name = "txtZ"
        Me.txtZ.Size = New System.Drawing.Size(100, 20)
        Me.txtZ.TabIndex = 18
        Me.txtZ.Text = "4"
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(83, 50)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(100, 20)
        Me.txtY.TabIndex = 17
        Me.txtY.Text = "4"
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(83, 24)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(100, 20)
        Me.txtX.TabIndex = 16
        Me.txtX.Text = "4"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(16, 83)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(14, 13)
        Me.label3.TabIndex = 15
        Me.label3.Text = "Z"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(16, 57)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(14, 13)
        Me.label2.TabIndex = 14
        Me.label2.Text = "Y"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(16, 27)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(14, 13)
        Me.label1.TabIndex = 13
        Me.label1.Text = "X"
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
        'picBox
        '
        Me.picBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBox.Location = New System.Drawing.Point(373, 56)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(119, 168)
        Me.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBox.TabIndex = 18
        Me.picBox.TabStop = False
        Me.picBox.Visible = False
        '
        'frmCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(504, 304)
        Me.Controls.Add(Me.picBox)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadastro"
        Me.Text = "TEx Tecnologia"
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.panel1.ResumeLayout(False)
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents txtZ As System.Windows.Forms.TextBox
    Private WithEvents txtY As System.Windows.Forms.TextBox
    Private WithEvents txtX As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents btnCalcular As System.Windows.Forms.Button
    Private WithEvents picBox As System.Windows.Forms.PictureBox

End Class
