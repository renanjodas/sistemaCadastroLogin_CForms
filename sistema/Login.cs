using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema
{
	class Login
	{
		private string usuario, senha;

		public void setUsuario(string u)
		{
			this.usuario = u;
		}

		public void setSenha(string s)
		{
			this.senha = s;
		}

		public string getUsuario()
		{
			return this.usuario;
		}
		public string getSenha()
		{
			return this.senha;
		}

		public Boolean verificarLogin()
		{
			if (this.getUsuario() == "Aluno" && this.getSenha() == "aluno123")
			{
				return true;
			}
			else
			{
				return false;
			}
		}

	}
}
