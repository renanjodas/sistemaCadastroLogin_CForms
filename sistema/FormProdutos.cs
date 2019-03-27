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
	public partial class FormProdutos : Form
	{
		public FormProdutos()
		{
			InitializeComponent();
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			double custoUnitario, porcentagemRevenda, valorRevenda, valorTotal, lucroUni, lucroTotal, quantidade;

			quantidade = double.Parse(txtQuantidade.Text);
			custoUnitario = double.Parse(txtCustoUni.Text);
			porcentagemRevenda = double.Parse(txtPorcentagem.Text);

			valorRevenda = custoUnitario + (porcentagemRevenda / 100 * custoUnitario);
			valorTotal = quantidade * valorRevenda;
			lucroUni = valorRevenda - custoUnitario;
			lucroTotal = quantidade * lucroUni;

			ApresentarResultado(valorRevenda, valorTotal, lucroUni, lucroTotal);

		}

		private void ApresentarResultado(double valorRevenda, double valorTotal, double lucroUni, double lucroTotal)
		{
			lblValorRevenda.Text = valorRevenda.ToString();
			lblTotal.Text = valorTotal.ToString();
			lblLucroUnidade.Text = lucroUni.ToString();
			lblLucroTotal.Text = lucroTotal.ToString();

		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			string valorRevenda, valorTotal, lucroUni, lucroTotal, custoUnitario, quantidade, porcentagemRevenda;
			
			quantidade = txtQuantidade.Text;
			custoUnitario = txtCustoUni.Text;
			porcentagemRevenda = txtPorcentagem.Text;
			valorRevenda = lblValorRevenda.Text;
			valorTotal = lblTotal.Text;
			lucroUni = lblLucroUnidade.Text;
			lucroTotal = lblLucroTotal.Text;


			GravarProduto(txtCodigo.Text, txtProduto.Text, txtSetor.Text, txtFornecedor.Text, dtpData.Text, custoUnitario.ToString(), porcentagemRevenda.ToString(), valorRevenda.ToString(), valorTotal.ToString(), lucroUni.ToString(), lucroTotal.ToString(), quantidade.ToString());
			LimparTela();

			MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void GravarProduto(string codigo, string produto, string setor, string fornecedor, string data, string custoUnitario, string porcentagemRevenda, string ValorRevenda, string valorTotal, string lucroUni, string lucroTotal, string quantidade)
		{
			StreamWriter arquivo;
			string caminho = "C:\\Users\\Usuario\\Documents\\Projetos\\sistemaCadastroLogin_CForms\\Produtos.txt";

			arquivo = File.AppendText(caminho);
			arquivo.WriteLine("");
			arquivo.WriteLine("------------- Cadastro de Produto -------------");
			arquivo.WriteLine("");
			arquivo.WriteLine("                     data de entrada " + data);
			arquivo.WriteLine("");
			arquivo.WriteLine("Código: " + codigo);
			arquivo.WriteLine("Produto: " + produto);
			arquivo.WriteLine("Qtde: " + quantidade);
			arquivo.WriteLine("Setor: " + setor);
			arquivo.WriteLine("Fornecedor: " + fornecedor);
			arquivo.WriteLine("");
			arquivo.WriteLine("");
			arquivo.WriteLine("Custo Unitário; " + custoUnitario);
			arquivo.WriteLine("% Revenda: " + porcentagemRevenda + "%");
			arquivo.WriteLine("Valor Revenda: " + ValorRevenda);
			arquivo.WriteLine("Valor Total: " + valorTotal);
			arquivo.WriteLine("Lucro/unidade: " + lucroUni);
			arquivo.WriteLine("Lucro Total: " + lucroTotal);
			arquivo.WriteLine("");
			arquivo.WriteLine("________________________________________________");
			arquivo.WriteLine("");
			arquivo.Close();
		}

		private void LimparTela()
		{
			txtCodigo.Clear();
			txtProduto.Clear();
			txtQuantidade.Clear();
			txtFornecedor.Clear();
			txtSetor.Clear();
			dtpData.ResetText();
			txtCustoUni.Clear();
			txtPorcentagem.Clear();
			lblLucroTotal.ResetText();
			lblLucroUnidade.ResetText();
			lblValorRevenda.ResetText();
			lblTotal.ResetText();			
		}

		
	}
}
