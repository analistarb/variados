using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI.Windows
{
    public partial class frmDados : Form
    {
        public frmDados()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Triangulos(int.Parse(txtX.Text), int.Parse(txtY.Text), int.Parse(txtZ.Text));
        }


        public void Triangulos(int X, int Y, int Z)
        {
            if ((X < Y + Z) && (Y < X + Z) && (Z < X + Y))
            {
                if ((X==Y) && (X==Z))
                {
                    MessageBox.Show("Triângulo Equilátero");
                    ImagemTriangulo(0);
                }
                else if ((X != Y) && (X != Z) && (Y != Z))
                {
                    MessageBox.Show("Triângulo Escaleno");
                    ImagemTriangulo(1);
                }
                else
                {
                    MessageBox.Show("Triângulo Isósceles");
                    ImagemTriangulo(2);
                }
            }
            else
            {
                Limpar();
            }
        }


        public void ImagemTriangulo(int Indice)
        {
            string strDiretorio = Directory.GetParent(Application.StartupPath).Parent.FullName;

            if (Indice==0)
            {
                picBox.Image = Image.FromFile(strDiretorio + "\\equilatero.png");
                picBox.Location = new Point(336, 64);
            }
            else if (Indice == 1)
            {
                picBox.Image = Image.FromFile(strDiretorio + "\\escaleno.png");
                picBox.Location = new Point(306, 81);
            }
            else if (Indice == 2)
            {
                picBox.Image = Image.FromFile(strDiretorio + "\\isosceles.png");
                picBox.Location = new Point(375, 56);
            }
            picBox.Visible = true;
        }


        public void Limpar()
        {
            txtX.Clear();
            txtY.Clear();
            txtZ.Clear();
            picBox.Visible = false;
            MessageBox.Show("Atenção, estas medidas não formam um triângulo");
        }


    }
}
