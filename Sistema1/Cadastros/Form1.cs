using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes fClientes = new Clientes();
            fClientes.ShowDialog();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionarios fFuncionarios = new frmFuncionarios();
            fFuncionarios.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
