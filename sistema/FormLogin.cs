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
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void btnEntrar_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.setSenha(txtSenha.Text);
			login.setUsuario(txtUsuario.Text);

			if (login.verificarLogin())
			{
				formMenu telaMenu = new formMenu();
				telaMenu.ShowDialog();
				sistema.FormLogin.ActiveForm.Visible = false;

			}
			else
			{
				MessageBox.Show("Login incorreto. Por favor, tente novamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtUsuario.Text = "";
				txtSenha.Text = "";
			}
		}
	}
}
