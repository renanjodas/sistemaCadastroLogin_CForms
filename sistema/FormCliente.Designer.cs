namespace sistema
{
	partial class FormCliente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
			this.lblNomeCliente = new System.Windows.Forms.Label();
			this.lblTelefoneCliente = new System.Windows.Forms.Label();
			this.lblCeularCliente = new System.Windows.Forms.Label();
			this.lblCidadeCliente = new System.Windows.Forms.Label();
			this.lblEstadoCliente = new System.Windows.Forms.Label();
			this.lblEmailCliente = new System.Windows.Forms.Label();
			this.txtNomeCliente = new System.Windows.Forms.TextBox();
			this.txtEmailCliente = new System.Windows.Forms.TextBox();
			this.maskCelularCliente = new System.Windows.Forms.MaskedTextBox();
			this.maskTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
			this.comboCidadeCliente = new System.Windows.Forms.ComboBox();
			this.comboEstadoCliente = new System.Windows.Forms.ComboBox();
			this.gbxEstadoCivilCliente = new System.Windows.Forms.GroupBox();
			this.rbnCasadoCliente = new System.Windows.Forms.RadioButton();
			this.rbnSolteiroCliente = new System.Windows.Forms.RadioButton();
			this.gbxPreferenciasCliente = new System.Windows.Forms.GroupBox();
			this.cbxDiabetico = new System.Windows.Forms.CheckBox();
			this.cbxIntolerante = new System.Windows.Forms.CheckBox();
			this.cbxVegano = new System.Windows.Forms.CheckBox();
			this.cbxVegetariano = new System.Windows.Forms.CheckBox();
			this.btnCadastrarCliente = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.gbxEstadoCivilCliente.SuspendLayout();
			this.gbxPreferenciasCliente.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblNomeCliente
			// 
			this.lblNomeCliente.AutoSize = true;
			this.lblNomeCliente.Location = new System.Drawing.Point(26, 51);
			this.lblNomeCliente.Name = "lblNomeCliente";
			this.lblNomeCliente.Size = new System.Drawing.Size(38, 13);
			this.lblNomeCliente.TabIndex = 0;
			this.lblNomeCliente.Text = "Nome:";
			// 
			// lblTelefoneCliente
			// 
			this.lblTelefoneCliente.AutoSize = true;
			this.lblTelefoneCliente.Location = new System.Drawing.Point(26, 103);
			this.lblTelefoneCliente.Name = "lblTelefoneCliente";
			this.lblTelefoneCliente.Size = new System.Drawing.Size(52, 13);
			this.lblTelefoneCliente.TabIndex = 1;
			this.lblTelefoneCliente.Text = "Telefone:";
			// 
			// lblCeularCliente
			// 
			this.lblCeularCliente.AutoSize = true;
			this.lblCeularCliente.Location = new System.Drawing.Point(135, 102);
			this.lblCeularCliente.Name = "lblCeularCliente";
			this.lblCeularCliente.Size = new System.Drawing.Size(42, 13);
			this.lblCeularCliente.TabIndex = 2;
			this.lblCeularCliente.Text = "Celular:";
			// 
			// lblCidadeCliente
			// 
			this.lblCidadeCliente.AutoSize = true;
			this.lblCidadeCliente.Location = new System.Drawing.Point(26, 157);
			this.lblCidadeCliente.Name = "lblCidadeCliente";
			this.lblCidadeCliente.Size = new System.Drawing.Size(43, 13);
			this.lblCidadeCliente.TabIndex = 3;
			this.lblCidadeCliente.Text = "Cidade:";
			// 
			// lblEstadoCliente
			// 
			this.lblEstadoCliente.AutoSize = true;
			this.lblEstadoCliente.Location = new System.Drawing.Point(149, 157);
			this.lblEstadoCliente.Name = "lblEstadoCliente";
			this.lblEstadoCliente.Size = new System.Drawing.Size(43, 13);
			this.lblEstadoCliente.TabIndex = 4;
			this.lblEstadoCliente.Text = "Estado:";
			// 
			// lblEmailCliente
			// 
			this.lblEmailCliente.AutoSize = true;
			this.lblEmailCliente.Location = new System.Drawing.Point(266, 51);
			this.lblEmailCliente.Name = "lblEmailCliente";
			this.lblEmailCliente.Size = new System.Drawing.Size(38, 13);
			this.lblEmailCliente.TabIndex = 5;
			this.lblEmailCliente.Text = "E-mail:";
			// 
			// txtNomeCliente
			// 
			this.txtNomeCliente.Location = new System.Drawing.Point(29, 67);
			this.txtNomeCliente.Name = "txtNomeCliente";
			this.txtNomeCliente.Size = new System.Drawing.Size(209, 20);
			this.txtNomeCliente.TabIndex = 6;
			// 
			// txtEmailCliente
			// 
			this.txtEmailCliente.Location = new System.Drawing.Point(269, 67);
			this.txtEmailCliente.Name = "txtEmailCliente";
			this.txtEmailCliente.Size = new System.Drawing.Size(209, 20);
			this.txtEmailCliente.TabIndex = 7;
			// 
			// maskCelularCliente
			// 
			this.maskCelularCliente.Location = new System.Drawing.Point(138, 118);
			this.maskCelularCliente.Mask = "(99) 99999-9999";
			this.maskCelularCliente.Name = "maskCelularCliente";
			this.maskCelularCliente.Size = new System.Drawing.Size(100, 20);
			this.maskCelularCliente.TabIndex = 8;
			// 
			// maskTelefoneCliente
			// 
			this.maskTelefoneCliente.Location = new System.Drawing.Point(29, 118);
			this.maskTelefoneCliente.Mask = "(99) 9999-9999";
			this.maskTelefoneCliente.Name = "maskTelefoneCliente";
			this.maskTelefoneCliente.Size = new System.Drawing.Size(100, 20);
			this.maskTelefoneCliente.TabIndex = 9;
			// 
			// comboCidadeCliente
			// 
			this.comboCidadeCliente.FormattingEnabled = true;
			this.comboCidadeCliente.Items.AddRange(new object[] {
            "Americana",
            "Santa Barbara Doeste",
            "Sumaré",
            "Limeira",
            "Campinas",
            "Curitiba"});
			this.comboCidadeCliente.Location = new System.Drawing.Point(29, 174);
			this.comboCidadeCliente.Name = "comboCidadeCliente";
			this.comboCidadeCliente.Size = new System.Drawing.Size(117, 21);
			this.comboCidadeCliente.TabIndex = 10;
			// 
			// comboEstadoCliente
			// 
			this.comboEstadoCliente.FormattingEnabled = true;
			this.comboEstadoCliente.Items.AddRange(new object[] {
            "SP",
            "PR"});
			this.comboEstadoCliente.Location = new System.Drawing.Point(152, 174);
			this.comboEstadoCliente.Name = "comboEstadoCliente";
			this.comboEstadoCliente.Size = new System.Drawing.Size(86, 21);
			this.comboEstadoCliente.TabIndex = 11;
			// 
			// gbxEstadoCivilCliente
			// 
			this.gbxEstadoCivilCliente.Controls.Add(this.rbnCasadoCliente);
			this.gbxEstadoCivilCliente.Controls.Add(this.rbnSolteiroCliente);
			this.gbxEstadoCivilCliente.Location = new System.Drawing.Point(29, 228);
			this.gbxEstadoCivilCliente.Name = "gbxEstadoCivilCliente";
			this.gbxEstadoCivilCliente.Size = new System.Drawing.Size(209, 71);
			this.gbxEstadoCivilCliente.TabIndex = 12;
			this.gbxEstadoCivilCliente.TabStop = false;
			this.gbxEstadoCivilCliente.Text = "Estado Civil";
			// 
			// rbnCasadoCliente
			// 
			this.rbnCasadoCliente.AutoSize = true;
			this.rbnCasadoCliente.Location = new System.Drawing.Point(123, 32);
			this.rbnCasadoCliente.Name = "rbnCasadoCliente";
			this.rbnCasadoCliente.Size = new System.Drawing.Size(73, 17);
			this.rbnCasadoCliente.TabIndex = 1;
			this.rbnCasadoCliente.TabStop = true;
			this.rbnCasadoCliente.Text = "Casado(a)";
			this.rbnCasadoCliente.UseVisualStyleBackColor = true;
			// 
			// rbnSolteiroCliente
			// 
			this.rbnSolteiroCliente.AutoSize = true;
			this.rbnSolteiroCliente.Location = new System.Drawing.Point(6, 32);
			this.rbnSolteiroCliente.Name = "rbnSolteiroCliente";
			this.rbnSolteiroCliente.Size = new System.Drawing.Size(72, 17);
			this.rbnSolteiroCliente.TabIndex = 0;
			this.rbnSolteiroCliente.TabStop = true;
			this.rbnSolteiroCliente.Text = "Solteiro(a)";
			this.rbnSolteiroCliente.UseVisualStyleBackColor = true;
			// 
			// gbxPreferenciasCliente
			// 
			this.gbxPreferenciasCliente.Controls.Add(this.cbxDiabetico);
			this.gbxPreferenciasCliente.Controls.Add(this.cbxIntolerante);
			this.gbxPreferenciasCliente.Controls.Add(this.cbxVegano);
			this.gbxPreferenciasCliente.Controls.Add(this.cbxVegetariano);
			this.gbxPreferenciasCliente.Location = new System.Drawing.Point(269, 103);
			this.gbxPreferenciasCliente.Name = "gbxPreferenciasCliente";
			this.gbxPreferenciasCliente.Size = new System.Drawing.Size(209, 196);
			this.gbxPreferenciasCliente.TabIndex = 13;
			this.gbxPreferenciasCliente.TabStop = false;
			this.gbxPreferenciasCliente.Text = "Preferências";
			// 
			// cbxDiabetico
			// 
			this.cbxDiabetico.AutoSize = true;
			this.cbxDiabetico.Location = new System.Drawing.Point(15, 145);
			this.cbxDiabetico.Name = "cbxDiabetico";
			this.cbxDiabetico.Size = new System.Drawing.Size(71, 17);
			this.cbxDiabetico.TabIndex = 3;
			this.cbxDiabetico.Text = "Diabético";
			this.cbxDiabetico.UseVisualStyleBackColor = true;
			// 
			// cbxIntolerante
			// 
			this.cbxIntolerante.AutoSize = true;
			this.cbxIntolerante.Location = new System.Drawing.Point(15, 110);
			this.cbxIntolerante.Name = "cbxIntolerante";
			this.cbxIntolerante.Size = new System.Drawing.Size(122, 17);
			this.cbxIntolerante.TabIndex = 2;
			this.cbxIntolerante.Text = "Intolerante a lactose";
			this.cbxIntolerante.UseVisualStyleBackColor = true;
			// 
			// cbxVegano
			// 
			this.cbxVegano.AutoSize = true;
			this.cbxVegano.Location = new System.Drawing.Point(15, 71);
			this.cbxVegano.Name = "cbxVegano";
			this.cbxVegano.Size = new System.Drawing.Size(63, 17);
			this.cbxVegano.TabIndex = 1;
			this.cbxVegano.Text = "Vegano";
			this.cbxVegano.UseVisualStyleBackColor = true;
			// 
			// cbxVegetariano
			// 
			this.cbxVegetariano.AutoSize = true;
			this.cbxVegetariano.Location = new System.Drawing.Point(15, 35);
			this.cbxVegetariano.Name = "cbxVegetariano";
			this.cbxVegetariano.Size = new System.Drawing.Size(83, 17);
			this.cbxVegetariano.TabIndex = 0;
			this.cbxVegetariano.Text = "Vegetariano";
			this.cbxVegetariano.UseVisualStyleBackColor = true;
			// 
			// btnCadastrarCliente
			// 
			this.btnCadastrarCliente.Location = new System.Drawing.Point(336, 318);
			this.btnCadastrarCliente.Name = "btnCadastrarCliente";
			this.btnCadastrarCliente.Size = new System.Drawing.Size(142, 41);
			this.btnCadastrarCliente.TabIndex = 14;
			this.btnCadastrarCliente.Text = "CADASTRAR";
			this.btnCadastrarCliente.UseVisualStyleBackColor = true;
			this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(26, 22);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(139, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "CADASTRO DE CLIENTES";
			// 
			// FormCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(508, 383);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnCadastrarCliente);
			this.Controls.Add(this.gbxPreferenciasCliente);
			this.Controls.Add(this.gbxEstadoCivilCliente);
			this.Controls.Add(this.comboEstadoCliente);
			this.Controls.Add(this.comboCidadeCliente);
			this.Controls.Add(this.maskTelefoneCliente);
			this.Controls.Add(this.maskCelularCliente);
			this.Controls.Add(this.txtEmailCliente);
			this.Controls.Add(this.txtNomeCliente);
			this.Controls.Add(this.lblEmailCliente);
			this.Controls.Add(this.lblEstadoCliente);
			this.Controls.Add(this.lblCidadeCliente);
			this.Controls.Add(this.lblCeularCliente);
			this.Controls.Add(this.lblTelefoneCliente);
			this.Controls.Add(this.lblNomeCliente);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormCliente";
			this.Text = "Cadastro de Clientes";
			this.gbxEstadoCivilCliente.ResumeLayout(false);
			this.gbxEstadoCivilCliente.PerformLayout();
			this.gbxPreferenciasCliente.ResumeLayout(false);
			this.gbxPreferenciasCliente.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNomeCliente;
		private System.Windows.Forms.Label lblTelefoneCliente;
		private System.Windows.Forms.Label lblCeularCliente;
		private System.Windows.Forms.Label lblCidadeCliente;
		private System.Windows.Forms.Label lblEstadoCliente;
		private System.Windows.Forms.Label lblEmailCliente;
		private System.Windows.Forms.TextBox txtNomeCliente;
		private System.Windows.Forms.TextBox txtEmailCliente;
		private System.Windows.Forms.MaskedTextBox maskCelularCliente;
		private System.Windows.Forms.MaskedTextBox maskTelefoneCliente;
		private System.Windows.Forms.ComboBox comboCidadeCliente;
		private System.Windows.Forms.ComboBox comboEstadoCliente;
		private System.Windows.Forms.GroupBox gbxEstadoCivilCliente;
		private System.Windows.Forms.RadioButton rbnCasadoCliente;
		private System.Windows.Forms.RadioButton rbnSolteiroCliente;
		private System.Windows.Forms.GroupBox gbxPreferenciasCliente;
		private System.Windows.Forms.CheckBox cbxDiabetico;
		private System.Windows.Forms.CheckBox cbxIntolerante;
		private System.Windows.Forms.CheckBox cbxVegano;
		private System.Windows.Forms.CheckBox cbxVegetariano;
		private System.Windows.Forms.Button btnCadastrarCliente;
		private System.Windows.Forms.Label label7;
	}
}