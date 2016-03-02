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
            Verifica_Compromisso(int.Parse(txtCompromisso.Text));
        }
        

        public void Verifica_Compromisso(int dtDia)
        {
            string strCompromisso="";
            DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dtDia);

            if (dtDia == 5)
            {
                strCompromisso = "Dia do rodizio";
            }

            if ((dt.DayOfWeek.ToString("d") == "1") || (dt.DayOfWeek.ToString("d") == "3"))
            {
                if (!string.IsNullOrEmpty(strCompromisso))
                {
                    strCompromisso += ", ";
                }
                strCompromisso += "Aula de Tae Kwon Do";
            }

            if (string.IsNullOrEmpty(strCompromisso))
            {
                strCompromisso = "Não existem agendamentos";
            }

            MessageBox.Show(strCompromisso);
        }


    }
}
