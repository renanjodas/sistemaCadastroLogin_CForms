namespace sistema
{
	partial class FormFuncionario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionario));
			this.lblTituloFuncionario = new System.Windows.Forms.Label();
			this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
			this.gbxPreferenciasFuncionario = new System.Windows.Forms.GroupBox();
			this.rbnEnsinoFundamental = new System.Windows.Forms.RadioButton();
			this.rbnEnsinoMedio = new System.Windows.Forms.RadioButton();
			this.rbnEnsinoSuperior = new System.Windows.Forms.RadioButton();
			this.gbxEstadoCivilFuncionario = new System.Windows.Forms.GroupBox();
			this.rbnCasadoFuncionario = new System.Windows.Forms.RadioButton();
			this.rbnSolteiroFuncionario = new System.Windows.Forms.RadioButton();
			this.comboEstadoFuncionario = new System.Windows.Forms.ComboBox();
			this.comboCidadeFuncionario = new System.Windows.Forms.ComboBox();
			this.maskTelefoneFuncionario = new System.Windows.Forms.MaskedTextBox();
			this.maskCelularFuncionario = new System.Windows.Forms.MaskedTextBox();
			this.txtEmailFuncionario = new System.Windows.Forms.TextBox();
			this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
			this.lblEmailFuncionario = new System.Windows.Forms.Label();
			this.lblEstadoFuncionario = new System.Windows.Forms.Label();
			this.lblCidadeFuncionario = new System.Windows.Forms.Label();
			this.lblCeularFuncionario = new System.Windows.Forms.Label();
			this.lblTelefoneFuncionario = new System.Windows.Forms.Label();
			this.lblNomeFuncionario = new System.Windows.Forms.Label();
			this.lblSalario = new System.Windows.Forms.Label();
			this.txtSalario = new System.Windows.Forms.TextBox();
			this.gbxPreferenciasFuncionario.SuspendLayout();
			this.gbxEstadoCivilFuncionario.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTituloFuncionario
			// 
			this.lblTituloFuncionario.AutoSize = true;
			this.lblTituloFuncionario.Location = new System.Drawing.Point(27, 26);
			this.lblTituloFuncionario.Name = "lblTituloFuncionario";
			this.lblTituloFuncionario.Size = new System.Drawing.Size(168, 13);
			this.lblTituloFuncionario.TabIndex = 31;
			this.lblTituloFuncionario.Text = "CADASTRO DE FUNCIONÁRIOS";
			// 
			// btnCadastrarFuncionario
			// 
			this.btnCadastrarFuncionario.Location = new System.Drawing.Point(337, 246);
			this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
			this.btnCadastrarFuncionario.Size = new System.Drawing.Size(142, 41);
			this.btnCadastrarFuncionario.TabIndex = 30;
			this.btnCadastrarFuncionario.Text = "CADASTRAR";
			this.btnCadastrarFuncionario.UseVisualStyleBackColor = true;
			this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
			// 
			// gbxPreferenciasFuncionario
			// 
			this.gbxPreferenciasFuncionario.Controls.Add(this.rbnEnsinoFundamental);
			this.gbxPreferenciasFuncionario.Controls.Add(this.rbnEnsinoMedio);
			this.gbxPreferenciasFuncionario.Controls.Add(this.rbnEnsinoSuperior);
			this.gbxPreferenciasFuncionario.Location = new System.Drawing.Point(270, 107);
			this.gbxPreferenciasFuncionario.Name = "gbxPreferenciasFuncionario";
			this.gbxPreferenciasFuncionario.Size = new System.Drawing.Size(209, 92);
			this.gbxPreferenciasFuncionario.TabIndex = 29;
			this.gbxPreferenciasFuncionario.TabStop = false;
			this.gbxPreferenciasFuncionario.Text = "Preferências";
			// 
			// rbnEnsinoFundamental
			// 
			this.rbnEnsinoFundamental.AutoSize = true;
			this.rbnEnsinoFundamental.Location = new System.Drawing.Point(15, 65);
			this.rbnEnsinoFundamental.Name = "rbnEnsinoFundamental";
			this.rbnEnsinoFundamental.Size = new System.Drawing.Size(121, 17);
			this.rbnEnsinoFundamental.TabIndex = 2;
			this.rbnEnsinoFundamental.TabStop = true;
			this.rbnEnsinoFundamental.Text = "Ensino Fundamental";
			this.rbnEnsinoFundamental.UseVisualStyleBackColor = true;
			// 
			// rbnEnsinoMedio
			// 
			this.rbnEnsinoMedio.AutoSize = true;
			this.rbnEnsinoMedio.Location = new System.Drawing.Point(15, 42);
			this.rbnEnsinoMedio.Name = "rbnEnsinoMedio";
			this.rbnEnsinoMedio.Size = new System.Drawing.Size(89, 17);
			this.rbnEnsinoMedio.TabIndex = 1;
			this.rbnEnsinoMedio.TabStop = true;
			this.rbnEnsinoMedio.Text = "Ensino Médio";
			this.rbnEnsinoMedio.UseVisualStyleBackColor = true;
			// 
			// rbnEnsinoSuperior
			// 
			this.rbnEnsinoSuperior.AutoSize = true;
			this.rbnEnsinoSuperior.Location = new System.Drawing.Point(15, 19);
			this.rbnEnsinoSuperior.Name = "rbnEnsinoSuperior";
			this.rbnEnsinoSuperior.Size = new System.Drawing.Size(99, 17);
			this.rbnEnsinoSuperior.TabIndex = 0;
			this.rbnEnsinoSuperior.TabStop = true;
			this.rbnEnsinoSuperior.Text = "Ensino Superior";
			this.rbnEnsinoSuperior.UseVisualStyleBackColor = true;
			// 
			// gbxEstadoCivilFuncionario
			// 
			this.gbxEstadoCivilFuncionario.Controls.Add(this.rbnCasadoFuncionario);
			this.gbxEstadoCivilFuncionario.Controls.Add(this.rbnSolteiroFuncionario);
			this.gbxEstadoCivilFuncionario.Location = new System.Drawing.Point(30, 221);
			this.gbxEstadoCivilFuncionario.Name = "gbxEstadoCivilFuncionario";
			this.gbxEstadoCivilFuncionario.Size = new System.Drawing.Size(209, 66);
			this.gbxEstadoCivilFuncionario.TabIndex = 28;
			this.gbxEstadoCivilFuncionario.TabStop = false;
			this.gbxEstadoCivilFuncionario.Text = "Estado Civil";
			// 
			// rbnCasadoFuncionario
			// 
			this.rbnCasadoFuncionario.AutoSize = true;
			this.rbnCasadoFuncionario.Location = new System.Drawing.Point(123, 25);
			this.rbnCasadoFuncionario.Name = "rbnCasadoFuncionario";
			this.rbnCasadoFuncionario.Size = new System.Drawing.Size(73, 17);
			this.rbnCasadoFuncionario.TabIndex = 1;
			this.rbnCasadoFuncionario.TabStop = true;
			this.rbnCasadoFuncionario.Text = "Casado(a)";
			this.rbnCasadoFuncionario.UseVisualStyleBackColor = true;
			// 
			// rbnSolteiroFuncionario
			// 
			this.rbnSolteiroFuncionario.AutoSize = true;
			this.rbnSolteiroFuncionario.Location = new System.Drawing.Point(6, 25);
			this.rbnSolteiroFuncionario.Name = "rbnSolteiroFuncionario";
			this.rbnSolteiroFuncionario.Size = new System.Drawing.Size(72, 17);
			this.rbnSolteiroFuncionario.TabIndex = 0;
			this.rbnSolteiroFuncionario.TabStop = true;
			this.rbnSolteiroFuncionario.Text = "Solteiro(a)";
			this.rbnSolteiroFuncionario.UseVisualStyleBackColor = true;
			// 
			// comboEstadoFuncionario
			// 
			this.comboEstadoFuncionario.FormattingEnabled = true;
			this.comboEstadoFuncionario.Location = new System.Drawing.Point(153, 178);
			this.comboEstadoFuncionario.Name = "comboEstadoFuncionario";
			this.comboEstadoFuncionario.Size = new System.Drawing.Size(86, 21);
			this.comboEstadoFuncionario.TabIndex = 27;
			// 
			// comboCidadeFuncionario
			// 
			this.comboCidadeFuncionario.FormattingEnabled = true;
			this.comboCidadeFuncionario.Location = new System.Drawing.Point(30, 178);
			this.comboCidadeFuncionario.Name = "comboCidadeFuncionario";
			this.comboCidadeFuncionario.Size = new System.Drawing.Size(117, 21);
			this.comboCidadeFuncionario.TabIndex = 26;
			// 
			// maskTelefoneFuncionario
			// 
			this.maskTelefoneFuncionario.Location = new System.Drawing.Point(30, 122);
			this.maskTelefoneFuncionario.Name = "maskTelefoneFuncionario";
			this.maskTelefoneFuncionario.Size = new System.Drawing.Size(100, 20);
			this.maskTelefoneFuncionario.TabIndex = 25;
			// 
			// maskCelularFuncionario
			// 
			this.maskCelularFuncionario.Location = new System.Drawing.Point(139, 122);
			this.maskCelularFuncionario.Name = "maskCelularFuncionario";
			this.maskCelularFuncionario.Size = new System.Drawing.Size(100, 20);
			this.maskCelularFuncionario.TabIndex = 24;
			// 
			// txtEmailFuncionario
			// 
			this.txtEmailFuncionario.Location = new System.Drawing.Point(270, 71);
			this.txtEmailFuncionario.Name = "txtEmailFuncionario";
			this.txtEmailFuncionario.Size = new System.Drawing.Size(209, 20);
			this.txtEmailFuncionario.TabIndex = 23;
			// 
			// txtNomeFuncionario
			// 
			this.txtNomeFuncionario.Location = new System.Drawing.Point(30, 71);
			this.txtNomeFuncionario.Name = "txtNomeFuncionario";
			this.txtNomeFuncionario.Size = new System.Drawing.Size(209, 20);
			this.txtNomeFuncionario.TabIndex = 22;
			// 
			// lblEmailFuncionario
			// 
			this.lblEmailFuncionario.AutoSize = true;
			this.lblEmailFuncionario.Location = new System.Drawing.Point(267, 55);
			this.lblEmailFuncionario.Name = "lblEmailFuncionario";
			this.lblEmailFuncionario.Size = new System.Drawing.Size(38, 13);
			this.lblEmailFuncionario.TabIndex = 21;
			this.lblEmailFuncionario.Text = "E-mail:";
			// 
			// lblEstadoFuncionario
			// 
			this.lblEstadoFuncionario.AutoSize = true;
			this.lblEstadoFuncionario.Location = new System.Drawing.Point(150, 161);
			this.lblEstadoFuncionario.Name = "lblEstadoFuncionario";
			this.lblEstadoFuncionario.Size = new System.Drawing.Size(43, 13);
			this.lblEstadoFuncionario.TabIndex = 20;
			this.lblEstadoFuncionario.Text = "Estado:";
			// 
			// lblCidadeFuncionario
			// 
			this.lblCidadeFuncionario.AutoSize = true;
			this.lblCidadeFuncionario.Location = new System.Drawing.Point(27, 161);
			this.lblCidadeFuncionario.Name = "lblCidadeFuncionario";
			this.lblCidadeFuncionario.Size = new System.Drawing.Size(43, 13);
			this.lblCidadeFuncionario.TabIndex = 19;
			this.lblCidadeFuncionario.Text = "Cidade:";
			// 
			// lblCeularFuncionario
			// 
			this.lblCeularFuncionario.AutoSize = true;
			this.lblCeularFuncionario.Location = new System.Drawing.Point(136, 106);
			this.lblCeularFuncionario.Name = "lblCeularFuncionario";
			this.lblCeularFuncionario.Size = new System.Drawing.Size(42, 13);
			this.lblCeularFuncionario.TabIndex = 18;
			this.lblCeularFuncionario.Text = "Celular:";
			// 
			// lblTelefoneFuncionario
			// 
			this.lblTelefoneFuncionario.AutoSize = true;
			this.lblTelefoneFuncionario.Location = new System.Drawing.Point(27, 107);
			this.lblTelefoneFuncionario.Name = "lblTelefoneFuncionario";
			this.lblTelefoneFuncionario.Size = new System.Drawing.Size(52, 13);
			this.lblTelefoneFuncionario.TabIndex = 17;
			this.lblTelefoneFuncionario.Text = "Telefone:";
			// 
			// lblNomeFuncionario
			// 
			this.lblNomeFuncionario.AutoSize = true;
			this.lblNomeFuncionario.Location = new System.Drawing.Point(27, 55);
			this.lblNomeFuncionario.Name = "lblNomeFuncionario";
			this.lblNomeFuncionario.Size = new System.Drawing.Size(38, 13);
			this.lblNomeFuncionario.TabIndex = 16;
			this.lblNomeFuncionario.Text = "Nome:";
			// 
			// lblSalario
			// 
			this.lblSalario.AutoSize = true;
			this.lblSalario.Location = new System.Drawing.Point(270, 223);
			this.lblSalario.Name = "lblSalario";
			this.lblSalario.Size = new System.Drawing.Size(62, 13);
			this.lblSalario.TabIndex = 32;
			this.lblSalario.Text = "Salário:  R$";
			// 
			// txtSalario
			// 
			this.txtSalario.Location = new System.Drawing.Point(338, 220);
			this.txtSalario.Name = "txtSalario";
			this.txtSalario.Size = new System.Drawing.Size(141, 20);
			this.txtSalario.TabIndex = 33;
			// 
			// FormFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 314);
			this.Controls.Add(this.txtSalario);
			this.Controls.Add(this.lblSalario);
			this.Controls.Add(this.lblTituloFuncionario);
			this.Controls.Add(this.btnCadastrarFuncionario);
			this.Controls.Add(this.gbxPreferenciasFuncionario);
			this.Controls.Add(this.gbxEstadoCivilFuncionario);
			this.Controls.Add(this.comboEstadoFuncionario);
			this.Controls.Add(this.comboCidadeFuncionario);
			this.Controls.Add(this.maskTelefoneFuncionario);
			this.Controls.Add(this.maskCelularFuncionario);
			this.Controls.Add(this.txtEmailFuncionario);
			this.Controls.Add(this.txtNomeFuncionario);
			this.Controls.Add(this.lblEmailFuncionario);
			this.Controls.Add(this.lblEstadoFuncionario);
			this.Controls.Add(this.lblCidadeFuncionario);
			this.Controls.Add(this.lblCeularFuncionario);
			this.Controls.Add(this.lblTelefoneFuncionario);
			this.Controls.Add(this.lblNomeFuncionario);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormFuncionario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Funcionarios";
			this.gbxPreferenciasFuncionario.ResumeLayout(false);
			this.gbxPreferenciasFuncionario.PerformLayout();
			this.gbxEstadoCivilFuncionario.ResumeLayout(false);
			this.gbxEstadoCivilFuncionario.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTituloFuncionario;
		private System.Windows.Forms.Button btnCadastrarFuncionario;
		private System.Windows.Forms.GroupBox gbxPreferenciasFuncionario;
		private System.Windows.Forms.RadioButton rbnEnsinoFundamental;
		private System.Windows.Forms.RadioButton rbnEnsinoMedio;
		private System.Windows.Forms.RadioButton rbnEnsinoSuperior;
		private System.Windows.Forms.GroupBox gbxEstadoCivilFuncionario;
		private System.Windows.Forms.RadioButton rbnCasadoFuncionario;
		private System.Windows.Forms.RadioButton rbnSolteiroFuncionario;
		private System.Windows.Forms.ComboBox comboEstadoFuncionario;
		private System.Windows.Forms.ComboBox comboCidadeFuncionario;
		private System.Windows.Forms.MaskedTextBox maskTelefoneFuncionario;
		private System.Windows.Forms.MaskedTextBox maskCelularFuncionario;
		private System.Windows.Forms.TextBox txtEmailFuncionario;
		private System.Windows.Forms.TextBox txtNomeFuncionario;
		private System.Windows.Forms.Label lblEmailFuncionario;
		private System.Windows.Forms.Label lblEstadoFuncionario;
		private System.Windows.Forms.Label lblCidadeFuncionario;
		private System.Windows.Forms.Label lblCeularFuncionario;
		private System.Windows.Forms.Label lblTelefoneFuncionario;
		private System.Windows.Forms.Label lblNomeFuncionario;
		private System.Windows.Forms.Label lblSalario;
		private System.Windows.Forms.TextBox txtSalario;
	}
}