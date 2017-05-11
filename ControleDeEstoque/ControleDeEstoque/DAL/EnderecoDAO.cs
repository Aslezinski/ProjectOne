using ControleDeEstoque.DAO;
using ControleDeEstoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.DAL
{
    class EnderecoDAO
    {
        private static Context Context = Singleton.Instance.Context;

        public static List<Endereco> ListarEnderecos()
        {
            return Context.Endereco.ToList();
        }

        public static Endereco GetEnderecoPorDescricao(string Descricao)
        {
            return Context.Endereco.Where(e => e.Descricao == Descricao).FirstOrDefault();
        }
    }
}
