using ControleDeEstoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.UsuarioLogado
{
    class UsuarioLogado
    {
         public int Id { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public DateTime DataDeCadastro { get; set; }

        public string Status { get; set; }

        public TipoUsuario TipoUsuario { get; set; }
    }
}
