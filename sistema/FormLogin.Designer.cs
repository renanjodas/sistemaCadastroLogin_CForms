namespace sistema
{
	partial class FormLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.lblUsuario = new System.Windows.Forms.Label();
			this.lblSenha = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.pnlAreaAcesso = new System.Windows.Forms.Panel();
			this.btnEntrar = new System.Windows.Forms.Button();
			this.pnlAreaAcesso.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Location = new System.Drawing.Point(22, 49);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(56, 13);
			this.lblUsuario.TabIndex = 0;
			this.lblUsuario.Text = "USUARIO";
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Location = new System.Drawing.Point(34, 91);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(44, 13);
			this.lblSenha.TabIndex = 1;
			this.lblSenha.Text = "SENHA";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(84, 46);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(100, 20);
			this.txtUsuario.TabIndex = 2;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(84, 88);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(100, 20);
			this.txtSenha.TabIndex = 3;
			// 
			// pnlAreaAcesso
			// 
			this.pnlAreaAcesso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlAreaAcesso.Controls.Add(this.btnEntrar);
			this.pnlAreaAcesso.Controls.Add(this.txtSenha);
			this.pnlAreaAcesso.Controls.Add(this.lblSenha);
			this.pnlAreaAcesso.Controls.Add(this.txtUsuario);
			this.pnlAreaAcesso.Controls.Add(this.lblUsuario);
			this.pnlAreaAcesso.Location = new System.Drawing.Point(24, 26);
			this.pnlAreaAcesso.Name = "pnlAreaAcesso";
			this.pnlAreaAcesso.Size = new System.Drawing.Size(305, 148);
			this.pnlAreaAcesso.TabIndex = 5;
			// 
			// btnEntrar
			// 
			this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEntrar.Image = global::sistema.Properties.Resources.iconfinder_application_pgp_signature_24736;
			this.btnEntrar.Location = new System.Drawing.Point(202, 29);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(88, 91);
			this.btnEntrar.TabIndex = 4;
			this.btnEntrar.Text = "ENTRAR";
			this.btnEntrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEntrar.UseVisualStyleBackColor = true;
			this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(353, 199);
			this.Controls.Add(this.pnlAreaAcesso);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormLogin";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.pnlAreaAcesso.ResumeLayout(false);
			this.pnlAreaAcesso.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Button btnEntrar;
		private System.Windows.Forms.Panel pnlAreaAcesso;
	}
}