using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema
{
	public partial class FormFuncionario : Form
	{
		public FormFuncionario()
		{
			InitializeComponent();
		}

		private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
		{
			string estadoCivil, escolaridade, nome, email, telefone, celular, cidade, estado;
			nome = txtNomeFuncionario.Text;
			email = txtEmailFuncionario.Text;
			telefone = maskTelefoneFuncionario.Text;
			celular = maskCelularFuncionario.Text;
			cidade = comboCidadeFuncionario.Items[comboCidadeFuncionario.SelectedIndex].ToString();
			estado = comboEstadoFuncionario.Items[comboEstadoFuncionario.SelectedIndex].ToString();
			if (rbnCasadoFuncionario.Checked == true)
			{
				estadoCivil = "Casado";
			} else
			{
				estadoCivil = "Solteiro";
			}

			if (rbnEnsinoFundamental.Checked == true)
			{
				escolaridade = "Ensino Fundamental";
			} else if(rbnEnsinoMedio.Checked == true)
			{
				escolaridade = "Ensino Médio";
			} else
			{
				escolaridade = "Ensino Superior";
			}

			GravarFuncionario(nome, email, telefone, celular, cidade, estado, estadoCivil, escolaridade);
			LimparFuncionario();
		}

		private void GravarFuncionario(string nome, string email, string telefone, string celular, string cidade, string estado, string estadoCivil, string escolaridade)
		{

			StreamWriter arquivo;
			string caminho = "C:\\Users\\Usuario\\Documents\\Projetos\\sistemaCadastroLogin_CForms\\Funcionarios.txt";

			arquivo = File.AppendText(caminho);
			arquivo.WriteLine("");
			arquivo.WriteLine("------------- Cadastro de Funcionários -------------");
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
			arquivo.WriteLine("Escolaridade: " + escolaridade);
			arquivo.WriteLine("");
			arquivo.WriteLine("____________________________________________________");
			arquivo.WriteLine("");
			arquivo.Close();
		}

		private void LimparFuncionario()
		{
			txtNomeFuncionario.Clear();
			txtEmailFuncionario.Clear();
			maskTelefoneFuncionario.Clear();
			maskCelularFuncionario.Clear();
			comboCidadeFuncionario.ResetText();
			comboEstadoFuncionario.ResetText();
			rbnCasadoFuncionario.Checked = false;
			rbnSolteiroFuncionario.Checked = false;
			rbnEnsinoFundamental.Checked = false;
			rbnEnsinoMedio.Checked = false;
			rbnEnsinoSuperior.Checked = false;
		}

	} 
}
