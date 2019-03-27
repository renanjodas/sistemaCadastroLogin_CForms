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

namespace sistema
{
	public partial class FormCliente : Form
	{
		public FormCliente()
		{
			InitializeComponent();
		}

		private void btnCadastrarCliente_Click(object sender, EventArgs e)
		{
			string vegetariano, vegano, lactose, estadoCivil, diabetico;
			if(cbxVegetariano.Checked == true)
			{
				vegetariano = "Sim";
			}
			else
			{
				vegetariano = "Não";
			}
			if (cbxVegano.Checked == true)
			{
				vegano = "Sim";
			}
			else
			{
				vegano = "Não";
			}
			if (cbxIntolerante.Checked == true)
			{
				lactose = "Sim";
			}
			else
			{
				lactose = "Não";
			}

			if (cbxDiabetico.Checked == true)
			{
				diabetico = "Sim";
			}
			else
			{
				diabetico = "Não";
			}

			if(rbnCasadoCliente.Checked == true)
			{
				estadoCivil = "Casado";

			} else 
			{
				estadoCivil = "Solteiro";
			}

			GravarCliente(txtNomeCliente.Text, txtEmailCliente.Text, maskTelefoneCliente.Text, maskCelularCliente.Text, comboCidadeCliente.Items[comboCidadeCliente.SelectedIndex].ToString(), comboEstadoCliente.Items[comboEstadoCliente.SelectedIndex].ToString(), estadoCivil, vegetariano, vegano, lactose, diabetico);
			LimparCliente();

			MessageBox.Show("Cliente gravado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void GravarCliente(string nome, string email, string telefone, string celular, string cidade, string estado, string estadoCivil, string vegetariano, string vegano, string lactose, string diabetico)
		{
			StreamWriter arquivo;
			string caminho = "C:\\Users\\Usuario\\Documents\\Projetos\\sistemaCadastroLogin_CForms\\Clientes.txt";

			arquivo = File.AppendText(caminho);
			arquivo.WriteLine("");
			arquivo.WriteLine("------------- Cadastro de Cliente -------------");
			arquivo.WriteLine("");
			arquivo.WriteLine("Nome: " + nome);
			arquivo.WriteLine("");
			arquivo.WriteLine("E-mail: " + email);
			arquivo.WriteLine("");
			arquivo.WriteLine("Telefone: " + telefone);
			arquivo.WriteLine("");
			arquivo.WriteLine("Celular: " + celular);
			arquivo.WriteLine("");
			arquivo.WriteLine("Cidade: " + cidade + "/" + estado);
			arquivo.WriteLine("");
			arquivo.WriteLine("Estado Civil: " + estadoCivil);
			arquivo.WriteLine("");
			arquivo.WriteLine("Vegetariano? " + vegetariano);
			arquivo.WriteLine("Vegano? " + vegano);
			arquivo.WriteLine("Intolerante a lactose? " + lactose);
			arquivo.WriteLine("Diabético? " + diabetico);
			arquivo.WriteLine("");
			arquivo.WriteLine("________________________________________________");
			arquivo.WriteLine("");
			arquivo.Close();
		}

		private void LimparCliente()
		{
			txtNomeCliente.Clear();
			txtEmailCliente.Clear();
			maskTelefoneCliente.Clear();
			maskCelularCliente.Clear();
			comboCidadeCliente.ResetText();
			comboEstadoCliente.ResetText();
			rbnCasadoCliente.Checked = false;
			rbnSolteiroCliente.Checked = false;
			cbxDiabetico.Checked = false;
			cbxIntolerante.Checked = false;
			cbxVegano.Checked = false;
			cbxVegetariano.Checked = false;
		}
	}
}
