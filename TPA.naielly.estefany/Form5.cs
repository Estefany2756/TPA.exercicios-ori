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
    public partial class frmimc : Form
    {
        public frmimc()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            string classe;

            peso = Convert.ToDouble(txtpeso.Text);
            altura = Convert.ToDouble(txtaltura.Text);

            imc = peso / Math.Pow(altura, 2);
            imc = Math.Round(imc, 2);


            if (imc < 17)
            {
                classe = "Magreza Severa";
            }

            else if (imc > 17 && imc < 18.5)
            {
                classe = "Magreza leve";
            }

            else if (imc > 18.5 && imc < 25)
            {
                classe = "Peso Saudável";
            }

            else if (imc > 25 && imc < 30)
            {
                classe = "Sobrepeso";
            }

            else if (imc > 20 && imc < 35)
            {
                classe = "Obesidade tipo I";
            }

            else if (imc > 35 && imc < 40)
            {
                classe = "Obesidade tipo II";
            }

            else 
            {
                classe = "Obesidade tipo III";
            }

            txtresult.Text = "O seu IMC é: " + imc + "." + " E a sua classificação é: " + classe.ToString();



        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtaltura.Clear();
            txtresult.Clear();
            txtpeso.Clear();
            txtpeso.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
