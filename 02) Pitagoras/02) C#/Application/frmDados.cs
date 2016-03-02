using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            MessageBox.Show(Pitagoras(int.Parse(txtCateto1.Text), int.Parse(txtCateto2.Text), int.Parse(txtHipotenusa.Text)).ToString());
        }


        public static bool Pitagoras(int cateto1, int cateto2, int hipotenusa)
        {
            double Valor1, Valor2;

            Valor1 = Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2);
            Valor2 = Math.Pow(hipotenusa, 2);

            if (Valor1 == Valor2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
