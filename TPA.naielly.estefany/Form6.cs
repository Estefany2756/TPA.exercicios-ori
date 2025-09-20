using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPA.naielly.estefany
{
    public partial class frmmedia : Form
    {
        public frmmedia()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            string situacao, conceito;
            double n1, n2, n3, me, ma;

            n1 = Convert.ToDouble(txtn1.Text);
            n2 = Convert.ToDouble(txtn2.Text);
            n3 = Convert.ToDouble(txtn3.Text);
            me = Convert.ToDouble(txtmedia.Text);

            ma = (n1 + n2 * 2 + n3 * 3 + me) / 7;
            ma = Math.Round(ma, 2);

            if (ma >= 90)
            {
                situacao = "Aprovado";
                conceito = "A";
            }
            else if (ma >= 75 && ma <90)
            {
                situacao = "Aprovado";
                conceito = "B";
            }
            else if (ma >= 60 && ma < 75)
            {
                situacao = "Aprovado";
                conceito = "C";
            }
            else if (ma >= 40 && ma < 60)
            {
                situacao = "Reprovado";
                conceito = "D";
            }
            else
            {
                situacao = "Reprovado";
                conceito = "E";
            }

           
            txtma.Text = Convert.ToString(ma);
            txtconceito.Text = conceito;
            txtsituacao.Text = situacao;



        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtsituacao.Clear();
            txtconceito.Clear();
            txtn1.Clear();
            txtn2.Clear();
            txtn3.Clear();
            txtma.Clear();
            txtid.Clear();
            txtmedia.Clear();
            txtid.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
