namespace sistema
{
	partial class FormProdutos
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.lblProduto = new System.Windows.Forms.Label();
			this.lblQuantidade = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.lblSetor = new System.Windows.Forms.Label();
			this.lblFornecedor = new System.Windows.Forms.Label();
			this.dtpData = new System.Windows.Forms.DateTimePicker();
			this.lblData = new System.Windows.Forms.Label();
			this.lblCustoUni = new System.Windows.Forms.Label();
			this.lblPorcentagem = new System.Windows.Forms.Label();
			this.lblRev = new System.Windows.Forms.Label();
			this.lblTot = new System.Windows.Forms.Label();
			this.lblLucTot = new System.Windows.Forms.Label();
			this.lblLucro = new System.Windows.Forms.Label();
			this.txtProduto = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.txtQuantidade = new System.Windows.Forms.TextBox();
			this.txtCustoUni = new System.Windows.Forms.TextBox();
			this.txtPorcentagem = new System.Windows.Forms.TextBox();
			this.lblValorRevenda = new System.Windows.Forms.Label();
			this.lblLucroUnidade = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblLucroTotal = new System.Windows.Forms.Label();
			this.pnDescricaoProd = new System.Windows.Forms.Panel();
			this.txtFornecedor = new System.Windows.Forms.TextBox();
			this.pnValores = new System.Windows.Forms.Panel();
			this.label13 = new System.Windows.Forms.Label();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.txtSetor = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.pnDescricaoProd.SuspendLayout();
			this.pnValores.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(156, -29);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(219, 20);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "CADASTRO DE PRODUTOS";
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Location = new System.Drawing.Point(27, 19);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(40, 13);
			this.lblCodigo.TabIndex = 1;
			this.lblCodigo.Text = "Código";
			// 
			// lblProduto
			// 
			this.lblProduto.AutoSize = true;
			this.lblProduto.Location = new System.Drawing.Point(23, 58);
			this.lblProduto.Name = "lblProduto";
			this.lblProduto.Size = new System.Drawing.Size(44, 13);
			this.lblProduto.TabIndex = 2;
			this.lblProduto.Text = "Produto";
			// 
			// lblQuantidade
			// 
			this.lblQuantidade.AutoSize = true;
			this.lblQuantidade.Location = new System.Drawing.Point(252, 18);
			this.lblQuantidade.Name = "lblQuantidade";
			this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
			this.lblQuantidade.TabIndex = 3;
			this.lblQuantidade.Text = "Quantidade";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(73, 16);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(67, 20);
			this.txtCodigo.TabIndex = 4;
			// 
			// lblSetor
			// 
			this.lblSetor.AutoSize = true;
			this.lblSetor.Location = new System.Drawing.Point(35, 98);
			this.lblSetor.Name = "lblSetor";
			this.lblSetor.Size = new System.Drawing.Size(32, 13);
			this.lblSetor.TabIndex = 5;
			this.lblSetor.Text = "Setor";
			// 
			// lblFornecedor
			// 
			this.lblFornecedor.AutoSize = true;
			this.lblFornecedor.Location = new System.Drawing.Point(253, 58);
			this.lblFornecedor.Name = "lblFornecedor";
			this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
			this.lblFornecedor.TabIndex = 6;
			this.lblFornecedor.Text = "Fornecedor";
			// 
			// dtpData
			// 
			this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpData.Location = new System.Drawing.Point(320, 95);
			this.dtpData.Name = "dtpData";
			this.dtpData.Size = new System.Drawing.Size(119, 20);
			this.dtpData.TabIndex = 7;
			this.dtpData.Value = new System.DateTime(2019, 3, 27, 13, 56, 15, 0);
			// 
			// lblData
			// 
			this.lblData.AutoSize = true;
			this.lblData.Location = new System.Drawing.Point(229, 98);
			this.lblData.Name = "lblData";
			this.lblData.Size = new System.Drawing.Size(85, 13);
			this.lblData.TabIndex = 8;
			this.lblData.Text = "Data de Entrada";
			// 
			// lblCustoUni
			// 
			this.lblCustoUni.AutoSize = true;
			this.lblCustoUni.Location = new System.Drawing.Point(28, 22);
			this.lblCustoUni.Name = "lblCustoUni";
			this.lblCustoUni.Size = new System.Drawing.Size(93, 13);
			this.lblCustoUni.TabIndex = 9;
			this.lblCustoUni.Text = "Custo Unitário  R$";
			// 
			// lblPorcentagem
			// 
			this.lblPorcentagem.AutoSize = true;
			this.lblPorcentagem.Location = new System.Drawing.Point(283, 22);
			this.lblPorcentagem.Name = "lblPorcentagem";
			this.lblPorcentagem.Size = new System.Drawing.Size(117, 13);
			this.lblPorcentagem.TabIndex = 10;
			this.lblPorcentagem.Text = "Porcentagem Revenda";
			// 
			// lblRev
			// 
			this.lblRev.AutoSize = true;
			this.lblRev.Location = new System.Drawing.Point(23, 58);
			this.lblRev.Name = "lblRev";
			this.lblRev.Size = new System.Drawing.Size(98, 13);
			this.lblRev.TabIndex = 11;
			this.lblRev.Text = "Valor Revenda  R$";
			// 
			// lblTot
			// 
			this.lblTot.AutoSize = true;
			this.lblTot.Location = new System.Drawing.Point(349, 58);
			this.lblTot.Name = "lblTot";
			this.lblTot.Size = new System.Drawing.Size(51, 13);
			this.lblTot.TabIndex = 12;
			this.lblTot.Text = "Total  R$";
			// 
			// lblLucTot
			// 
			this.lblLucTot.AutoSize = true;
			this.lblLucTot.Location = new System.Drawing.Point(320, 92);
			this.lblLucTot.Name = "lblLucTot";
			this.lblLucTot.Size = new System.Drawing.Size(81, 13);
			this.lblLucTot.TabIndex = 13;
			this.lblLucTot.Text = "Lucro Total  R$";
			// 
			// lblLucro
			// 
			this.lblLucro.AutoSize = true;
			this.lblLucro.Location = new System.Drawing.Point(22, 92);
			this.lblLucro.Name = "lblLucro";
			this.lblLucro.Size = new System.Drawing.Size(99, 13);
			this.lblLucro.TabIndex = 14;
			this.lblLucro.Text = "Lucro/Unidade  R$";
			// 
			// txtProduto
			// 
			this.txtProduto.Location = new System.Drawing.Point(73, 55);
			this.txtProduto.Name = "txtProduto";
			this.txtProduto.Size = new System.Drawing.Size(123, 20);
			this.txtProduto.TabIndex = 15;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// txtQuantidade
			// 
			this.txtQuantidade.Location = new System.Drawing.Point(320, 16);
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.Size = new System.Drawing.Size(67, 20);
			this.txtQuantidade.TabIndex = 19;
			// 
			// txtCustoUni
			// 
			this.txtCustoUni.Location = new System.Drawing.Point(127, 19);
			this.txtCustoUni.Name = "txtCustoUni";
			this.txtCustoUni.Size = new System.Drawing.Size(100, 20);
			this.txtCustoUni.TabIndex = 20;
			// 
			// txtPorcentagem
			// 
			this.txtPorcentagem.Location = new System.Drawing.Point(406, 19);
			this.txtPorcentagem.Name = "txtPorcentagem";
			this.txtPorcentagem.Size = new System.Drawing.Size(30, 20);
			this.txtPorcentagem.TabIndex = 21;
			// 
			// lblValorRevenda
			// 
			this.lblValorRevenda.BackColor = System.Drawing.Color.Azure;
			this.lblValorRevenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblValorRevenda.Location = new System.Drawing.Point(127, 53);
			this.lblValorRevenda.Name = "lblValorRevenda";
			this.lblValorRevenda.Size = new System.Drawing.Size(100, 23);
			this.lblValorRevenda.TabIndex = 22;
			// 
			// lblLucroUnidade
			// 
			this.lblLucroUnidade.BackColor = System.Drawing.Color.Azure;
			this.lblLucroUnidade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblLucroUnidade.Location = new System.Drawing.Point(127, 83);
			this.lblLucroUnidade.Name = "lblLucroUnidade";
			this.lblLucroUnidade.Size = new System.Drawing.Size(100, 23);
			this.lblLucroUnidade.TabIndex = 23;
			// 
			// lblTotal
			// 
			this.lblTotal.BackColor = System.Drawing.Color.Azure;
			this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTotal.Location = new System.Drawing.Point(406, 48);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(100, 23);
			this.lblTotal.TabIndex = 24;
			// 
			// lblLucroTotal
			// 
			this.lblLucroTotal.BackColor = System.Drawing.Color.Azure;
			this.lblLucroTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblLucroTotal.Location = new System.Drawing.Point(406, 83);
			this.lblLucroTotal.Name = "lblLucroTotal";
			this.lblLucroTotal.Size = new System.Drawing.Size(100, 23);
			this.lblLucroTotal.TabIndex = 25;
			// 
			// pnDescricaoProd
			// 
			this.pnDescricaoProd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.pnDescricaoProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnDescricaoProd.Controls.Add(this.txtSetor);
			this.pnDescricaoProd.Controls.Add(this.txtFornecedor);
			this.pnDescricaoProd.Controls.Add(this.lblTitulo);
			this.pnDescricaoProd.Controls.Add(this.lblCodigo);
			this.pnDescricaoProd.Controls.Add(this.lblProduto);
			this.pnDescricaoProd.Controls.Add(this.lblQuantidade);
			this.pnDescricaoProd.Controls.Add(this.txtCodigo);
			this.pnDescricaoProd.Controls.Add(this.lblSetor);
			this.pnDescricaoProd.Controls.Add(this.txtQuantidade);
			this.pnDescricaoProd.Controls.Add(this.lblFornecedor);
			this.pnDescricaoProd.Controls.Add(this.dtpData);
			this.pnDescricaoProd.Controls.Add(this.lblData);
			this.pnDescricaoProd.Controls.Add(this.txtProduto);
			this.pnDescricaoProd.Location = new System.Drawing.Point(44, 46);
			this.pnDescricaoProd.Name = "pnDescricaoProd";
			this.pnDescricaoProd.Size = new System.Drawing.Size(475, 136);
			this.pnDescricaoProd.TabIndex = 26;
			// 
			// txtFornecedor
			// 
			this.txtFornecedor.Location = new System.Drawing.Point(321, 55);
			this.txtFornecedor.Name = "txtFornecedor";
			this.txtFornecedor.Size = new System.Drawing.Size(118, 20);
			this.txtFornecedor.TabIndex = 21;
			// 
			// pnValores
			// 
			this.pnValores.BackColor = System.Drawing.Color.LightGray;
			this.pnValores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnValores.Controls.Add(this.btnCalcular);
			this.pnValores.Controls.Add(this.txtCustoUni);
			this.pnValores.Controls.Add(this.lblLucroTotal);
			this.pnValores.Controls.Add(this.lblTot);
			this.pnValores.Controls.Add(this.lblLucTot);
			this.pnValores.Controls.Add(this.lblTotal);
			this.pnValores.Controls.Add(this.lblRev);
			this.pnValores.Controls.Add(this.lblLucro);
			this.pnValores.Controls.Add(this.lblLucroUnidade);
			this.pnValores.Controls.Add(this.lblPorcentagem);
			this.pnValores.Controls.Add(this.lblCustoUni);
			this.pnValores.Controls.Add(this.lblValorRevenda);
			this.pnValores.Controls.Add(this.txtPorcentagem);
			this.pnValores.Location = new System.Drawing.Point(12, 188);
			this.pnValores.Name = "pnValores";
			this.pnValores.Size = new System.Drawing.Size(543, 133);
			this.pnValores.TabIndex = 27;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(168, 9);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(219, 20);
			this.label13.TabIndex = 28;
			this.label13.Text = "CADASTRO DE PRODUTOS";
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(218, 327);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(139, 42);
			this.btnSalvar.TabIndex = 29;
			this.btnSalvar.Text = "SALVAR";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// txtSetor
			// 
			this.txtSetor.Location = new System.Drawing.Point(73, 95);
			this.txtSetor.Name = "txtSetor";
			this.txtSetor.Size = new System.Drawing.Size(122, 20);
			this.txtSetor.TabIndex = 22;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(442, 17);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(64, 23);
			this.btnCalcular.TabIndex = 26;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// FormProdutos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(568, 381);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.pnValores);
			this.Controls.Add(this.pnDescricaoProd);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormProdutos";
			this.Text = "Cadastro de Produtos";
			this.pnDescricaoProd.ResumeLayout(false);
			this.pnDescricaoProd.PerformLayout();
			this.pnValores.ResumeLayout(false);
			this.pnValores.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.Label lblProduto;
		private System.Windows.Forms.Label lblQuantidade;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblSetor;
		private System.Windows.Forms.Label lblFornecedor;
		private System.Windows.Forms.DateTimePicker dtpData;
		private System.Windows.Forms.Label lblData;
		private System.Windows.Forms.Label lblCustoUni;
		private System.Windows.Forms.Label lblPorcentagem;
		private System.Windows.Forms.Label lblRev;
		private System.Windows.Forms.Label lblTot;
		private System.Windows.Forms.Label lblLucTot;
		private System.Windows.Forms.Label lblLucro;
		private System.Windows.Forms.TextBox txtProduto;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.TextBox txtQuantidade;
		private System.Windows.Forms.TextBox txtCustoUni;
		private System.Windows.Forms.TextBox txtPorcentagem;
		private System.Windows.Forms.Label lblValorRevenda;
		private System.Windows.Forms.Label lblLucroUnidade;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblLucroTotal;
		private System.Windows.Forms.Panel pnDescricaoProd;
		private System.Windows.Forms.TextBox txtFornecedor;
		private System.Windows.Forms.Panel pnValores;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.TextBox txtSetor;
		private System.Windows.Forms.Button btnCalcular;
	}
}