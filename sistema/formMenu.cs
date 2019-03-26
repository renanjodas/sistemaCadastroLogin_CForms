using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema
{
	public partial class formMenu : Form
	{
		public formMenu()
		{
			InitializeComponent();
			sistema.FormLogin.ActiveForm.Visible = false;
		}

		private void btnClientes_Click(object sender, EventArgs e)
		{
			FormCliente fCliente = new FormCliente();
			fCliente.ShowDialog();
		}

		private void btnFuncionarios_Click(object sender, EventArgs e)
		{
			FormFuncionario fFuncionario = new FormFuncionario();
			fFuncionario.ShowDialog();
		}

		private void btnProdutos_Click(object sender, EventArgs e)
		{
			FormProdutos fProdutos = new FormProdutos();
			fProdutos.ShowDialog();
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
