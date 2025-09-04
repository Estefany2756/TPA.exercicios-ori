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
    public partial class frmlanchonete : Form
    {
        public frmlanchonete()
        {
            InitializeComponent();
        }

        private void frmlanchonete_Load(object sender, EventArgs e)
        {

        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            Int32 Codigo;

            Codigo = Convert.ToInt32(txtcodigo.Text);
            switch (Codigo)
            {

                case 100:
                    txtresult.Text = "Cachorro-quente à R$25,00";
                    break;

                case 101:
                    txtresult.Text = "Bauru à R$15,00";
                    break;

                case 102:
                    txtresult.Text = "X-burguer à R$35,00";
                    break;

                case 103:
                    txtresult.Text = "Triplo X-burguer à R$47,00";
                    break;

                default:
                    txtresult.Text = "Código inválido. Digite novamente (de 100 á 103)";
                    break;


            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtresult.Clear();
            txtcodigo.Clear();
            txtcodigo.Focus();

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}