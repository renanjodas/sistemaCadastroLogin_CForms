namespace sistema
{
	partial class formMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
			this.btnSair = new System.Windows.Forms.Button();
			this.btnProdutos = new System.Windows.Forms.Button();
			this.btnFuncionarios = new System.Windows.Forms.Button();
			this.btnClientes = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSair
			// 
			this.btnSair.Image = global::sistema.Properties.Resources.iconfinder_logout_63128;
			this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSair.Location = new System.Drawing.Point(328, 147);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(93, 59);
			this.btnSair.TabIndex = 3;
			this.btnSair.Text = "Sair";
			this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnProdutos
			// 
			this.btnProdutos.Image = global::sistema.Properties.Resources.iconfinder_inventory_maintenance_49590;
			this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProdutos.Location = new System.Drawing.Point(36, 147);
			this.btnProdutos.Name = "btnProdutos";
			this.btnProdutos.Size = new System.Drawing.Size(184, 59);
			this.btnProdutos.TabIndex = 2;
			this.btnProdutos.Text = "Cadastro de Produtos";
			this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnProdutos.UseVisualStyleBackColor = true;
			this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
			// 
			// btnFuncionarios
			// 
			this.btnFuncionarios.Image = global::sistema.Properties.Resources.iconfinder_user_group_new_23632;
			this.btnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFuncionarios.Location = new System.Drawing.Point(237, 51);
			this.btnFuncionarios.Name = "btnFuncionarios";
			this.btnFuncionarios.Size = new System.Drawing.Size(184, 59);
			this.btnFuncionarios.TabIndex = 1;
			this.btnFuncionarios.Text = "Cadastro de Funcionários";
			this.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFuncionarios.UseVisualStyleBackColor = true;
			this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
			// 
			// btnClientes
			// 
			this.btnClientes.Image = global::sistema.Properties.Resources.iconfinder_Add_Male_User_49576;
			this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClientes.Location = new System.Drawing.Point(36, 51);
			this.btnClientes.Name = "btnClientes";
			this.btnClientes.Size = new System.Drawing.Size(184, 59);
			this.btnClientes.TabIndex = 0;
			this.btnClientes.Text = "Cadastro de Clientes";
			this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClientes.UseVisualStyleBackColor = true;
			this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
			// 
			// formMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(458, 280);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnProdutos);
			this.Controls.Add(this.btnFuncionarios);
			this.Controls.Add(this.btnClientes);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "formMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnClientes;
		private System.Windows.Forms.Button btnFuncionarios;
		private System.Windows.Forms.Button btnProdutos;
		private System.Windows.Forms.Button btnSair;
	}
}