namespace UI.Windows
{
    partial class frmDados
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTamanhoLados = new System.Windows.Forms.TextBox();
            this.txtNomeLados = new System.Windows.Forms.TextBox();
            this.txtPoligono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Location = new System.Drawing.Point(-1, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 65);
            this.panel1.TabIndex = 14;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(393, 12);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(101, 39);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtTamanhoLados);
            this.panel2.Controls.Add(this.txtNomeLados);
            this.panel2.Controls.Add(this.txtPoligono);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 121);
            this.panel2.TabIndex = 15;
            // 
            // txtTamanhoLados
            // 
            this.txtTamanhoLados.Location = new System.Drawing.Point(107, 76);
            this.txtTamanhoLados.Name = "txtTamanhoLados";
            this.txtTamanhoLados.Size = new System.Drawing.Size(100, 20);
            this.txtTamanhoLados.TabIndex = 18;
            this.txtTamanhoLados.Text = "2, 4, 6, 2, 8";
            // 
            // txtNomeLados
            // 
            this.txtNomeLados.Location = new System.Drawing.Point(107, 50);
            this.txtNomeLados.Name = "txtNomeLados";
            this.txtNomeLados.Size = new System.Drawing.Size(100, 20);
            this.txtNomeLados.TabIndex = 17;
            this.txtNomeLados.Text = "A, B, C, D, E";
            // 
            // txtPoligono
            // 
            this.txtPoligono.Location = new System.Drawing.Point(107, 24);
            this.txtPoligono.Name = "txtPoligono";
            this.txtPoligono.Size = new System.Drawing.Size(100, 20);
            this.txtPoligono.TabIndex = 16;
            this.txtPoligono.Text = "Pentagono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tamanho(Lados)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome(Lados)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Polígono";
            // 
            // frmDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Windows.Properties.Resources.TEX_logo;
            this.ClientSize = new System.Drawing.Size(504, 304);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDados";
            this.Text = "TEx Tecnologia";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTamanhoLados;
        private System.Windows.Forms.TextBox txtNomeLados;
        private System.Windows.Forms.TextBox txtPoligono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}

