using ControleDeEstoque.DAL;
using ControleDeEstoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Controller
{
    class ProdutoController
    {
        public static bool CadastrarProduto(Produto produto)
        {
            try
            {
                if (ProdutoDAO.ValidarProduto(produto.Nome))
                {
                    ProdutoDAO.CadastrarProduto(produto);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool EditarProduto(Produto produto, Produto produtoEditado)
        {
            try
            {
                if (ProdutoDAO.ValidarProduto(produtoEditado.Nome))
                {
                    ProdutoDAO.CadastrarProduto(produto);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<Produto> ListarProdutos()
        {
            return ProdutoDAO.ListarProdutos();
        }

        public static List<Produto> ListarProdutosAtivos()
        {
            return ProdutoDAO.ListarProdutosAtivos();
        }
    }
}
