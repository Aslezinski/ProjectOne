using ControleDeEstoque.DAO;
using ControleDeEstoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.DAL
{
    class ProdutoDAO
    {
        private static Context Context = Singleton.Instance.Context;

        public static bool CadastrarProduto(Produto produto)
        {
            produto.DataDeCadastro = DateTime.Now;
            Context.Produto.Add(produto);
            Context.SaveChanges();
            return true;
        }

        public static bool ValidarProduto(string nome)
        {
            if (Context.Produto.Where(u => u.Nome == nome).FirstOrDefault() == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool EditarProduto(Produto produto, Produto produtoEditado)
        {
            Context.Entry(produto).CurrentValues.SetValues(produtoEditado);
            Context.SaveChanges();
            return true;
        }

        public static List<Produto> ListarProdutos()
        {
            List<Produto> produtos = new List<Produto>();

            produtos = Context.Produto.ToList();

            return produtos;
        }

        public static List<Produto> ListarProdutosAtivos()
        {
            List<Produto> produtos = new List<Produto>();

            produtos = Context.Produto.Where(p => p.Status == "Ativo").ToList();

            return produtos;
        }

        public static Produto GetProdutoPorNome(string Nome)
        {
            return Context.Produto.Where(p => p.Nome == Nome).FirstOrDefault();
        }
    }
}
