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
            String[] array1 = txtNomeLados.Text.Split(',');
            String[] array2 = txtTamanhoLados.Text.Split(',');


            if (array1.Count() == array2.Count())
            {
                string strMensagem = "";
                Poligono meuPoligono = new Poligono();
                meuPoligono.Nome = txtPoligono.Text;

                for (int i = 0; i < array1.Length; i++)
                {
                    Lado lado = new Lado();
                    lado.Nome = array1[i];
                    lado.Tamanho = int.Parse(array2[i]);
                    meuPoligono.Lados.Add(lado);
                }


                foreach (var c in meuPoligono.Lados)
                {
                    strMensagem += "\n (Lado: " + c.Nome + ", tamanho: " + c.Tamanho.ToString() + ")";
                }

                strMensagem = "Poligono: " + meuPoligono.Nome + "\n" + strMensagem.ToString() + "";
                strMensagem += "\n\nQuantidade de Lados: " + meuPoligono.GetQtdLados().ToString();
                MessageBox.Show(strMensagem);

            }
            else
            {
                MessageBox.Show("Atenção, favor preencher as duas listas com a mesma quantidade de itens");
            }

        }
    }
}
