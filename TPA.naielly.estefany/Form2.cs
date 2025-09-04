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
    public partial class frmlivraria : Form
    {
        public frmlivraria()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double livros, total;

            livros = Convert.ToDouble(txtlivros.Text);

            if (livros <= 10)
            {
                total = livros * 12;
            }

            else
            {
                total = livros * 8;

            }
            txtvalor.Text = total.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtlivros.Clear();      
            txtvalor.Clear();
            txtlivros.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();

        }
    }
}
