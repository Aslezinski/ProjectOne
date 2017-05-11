using ControleDeEstoque.DAL;
using ControleDeEstoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Controller
{
    class LoteController
    {
        public static bool CadastrarEntradaDeLote(Lote lote)
        {
            try
            {
                if (LoteDAO.ValidarNumeroDeLote(lote.Id)&& LoteDAO.ValidarDataDeVencimento(lote.DataDeVencimento)
                    && LoteDAO.ValidarDataDeFabricacao(lote.DataDeFabricacao))
                {
                    LoteDAO.CadastrarLote(lote);
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

        public static bool CadastrarSaidaDeLote(Lote lote)
        {
            try
            {
                if (LoteDAO.ValidarSaidaLote(lote.Id))
                {
                    HistoricoDAO.GerarHistoricoSaidaLote(lote);
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

        public static List<Lote> ListarLotesEmEstoquePorDataDeVencimento(DateTime dataDeVencimento)
        {
            return LoteDAO.ListarLotesEmEstoquePorDataDeVencimento(dataDeVencimento);
        }

        public static List<Lote> ListarLotesEmEstoquePorProduto(Produto produto)
        {
            return LoteDAO.ListarLotesEmEstoquePorProduto(produto);
        }

        public static List<Lote> ListarLotesEmEstoquePorUsuario(Usuario usuario)
        {
            return ListarEntradasDeLotesPorUsuario(usuario);
        }

        public static List<Lote> ListarEntradasDeLotesPorDataDeVencimento(DateTime dataDeVencimento)
        {
            return ListarEntradasDeLotesPorDataDeVencimento(dataDeVencimento);
        }

        public static List<Lote> ListarEtradasDeLotesPorProduto(Produto produto)
        {
            return ListarEtradasDeLotesPorProduto(produto);
        }

        public static List<Lote> ListarEntradasDeLotesPorUsuario(Usuario usuario)
        {
            return ListarLotesEmEstoquePorUsuario(usuario);
        }

        public static List<Lote> ListarSaidasDeLotesPorDataDeVencimento(DateTime dataDeVencimento)
        {
            return ListarSaidasDeLotesPorDataDeVencimento(dataDeVencimento);
        }

        public static List<Lote> ListarSaidasDeLotesPorProduto(Produto produto)
        {
            return ListarSaidasDeLotesPorProduto(produto);
        }

        public static List<Lote> ListarSaidasDeLotesPorUsuario(Usuario usuario)
        {
            return ListarSaidasDeLotesPorUsuario(usuario);
        }
    }
}
