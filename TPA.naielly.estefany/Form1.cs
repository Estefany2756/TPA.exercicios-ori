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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void tsmilivraria_Click(object sender, EventArgs e)
        {
            Hide();
            frmlivraria frmlivraria = new frmlivraria();
            frmlivraria.Show();
        }

        private void tsmisair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiacrescimo_Click(object sender, EventArgs e)
        {
            Hide();
            frmacrescimo frmacrescimo = new frmacrescimo();
            frmacrescimo.Show();
        }
    }
}
