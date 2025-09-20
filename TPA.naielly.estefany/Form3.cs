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
    public partial class frmacrescimo : Form
    {
        public frmacrescimo()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            string Sexo;
            double Idade, Acrescimo, Salario, Total;

            Salario = Convert.ToDouble(txtsalario.Text);
            Idade = Convert.ToDouble(txtidade.Text);
            Sexo = txtsexo.Text;


            Acrescimo = 0;

            if (Sexo != "F" && Sexo != "M")
            {
                txttotal.Text = "Gênero inválido! Digite apenas F ou M.";
            }

            else
            {
                if (Idade >= 30)
                {
                    if (Sexo == "F")

                        Acrescimo = 250;

                    else
                        Acrescimo = 100;
                }

                else
                {
                    if (Sexo == "F")
                        Acrescimo = 150;

                    else
                        Acrescimo = 50;
                }

                Total = Salario + Acrescimo;

                txttotal.Text = "Olá, " + txtnome.Text + "." + "O seu novo salário é: R$" + Total.ToString();


            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txttotal.Clear();
            txtidade.Clear();
            txtsexo.Clear();
            txtnome.Clear();
            txtsalario.Clear();
            txtnome.Focus();
           
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmacrescimo_Load(object sender, EventArgs e)
        {

        }

        private void lblnome_Click(object sender, EventArgs e)
        {

        }
    }
}
