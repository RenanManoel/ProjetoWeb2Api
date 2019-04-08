using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWeb.Models
{
	public class ModelTrocarSenha
	{
		public string Email { get; set; }
		public string SenhaAntiga { get; set; }
		public string SenhaNova { get; set; }
	}
}
