using ControleDeEstoque.DAO;
using ControleDeEstoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.DAL
{
    class LoteDAO
    {
        private static Context Context = Singleton.Instance.Context;

        public static bool CadastrarLote(Lote lote)
        {
            Context.Lote.Add(lote);
            Context.SaveChanges();

            HistoricoDAO.GerarHistoricoEntradaLote(lote);

            return true;
        }
        
        public static Lote BuscarLote(int IdLote)
        {
            return Context.Lote.Where(l => l.Id == IdLote).FirstOrDefault();
        }

        public static bool ValidarNumeroDeLote(int id)
        {
            if (Context.Lote.Where(u => u.Id == id).FirstOrDefault() == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidarDataDeFabricacao(DateTime dataDeFabricacao)
        {
            if (dataDeFabricacao <= DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidarDataDeVencimento(DateTime dataDeVencimento)
        {
            if (dataDeVencimento >= DateTime.Now.AddDays(-1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<Lote> ListarLotesEmEstoquePorDataDeVencimento(DateTime dataDeVencimento)
        {
            List<Lote> lotes = Context.Lote.Where(x => x.DataDeVencimento.Equals(dataDeVencimento)).ToList();

            List<Lote> lotesEmEstoque = new List<Lote>();

            foreach (var item in lotes)
            {
                if (ValidarSaidaLote(item.Id))
                    lotesEmEstoque.Add(item);
            }

            return lotesEmEstoque;
        }

        public static List<Lote> ListarLotesEmEstoquePorProduto(Produto produto)
        {
            List<Lote> lotes = Context.Lote.Where(x => x.Produto.Equals(produto)).ToList();

            List<Lote> lotesEmEstoque = new List<Lote>();

            foreach (var item in lotes)
            {
                if (ValidarSaidaLote(item.Id))
                    lotesEmEstoque.Add(item);
            }

            return lotesEmEstoque;
        }

        public static bool ValidarSaidaLote(int IdLote)
        {
            bool y = Context.Historico.Where(h => h.Lote.Id == IdLote && h.TipoDeRegistro.Id == 2).FirstOrDefault() == null;

            bool x = (BuscarLote(IdLote) != null);

            if (x && y )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidarGaveta(string gaveta, string corredor, string secao)
        {
            List<Historico> Entradas = Context.Historico.Where(h => h.Lote.Gaveta == gaveta
            && h.Lote.Secao == secao
            && h.Lote.Corredor == corredor
            && h.TipoDeRegistro.Id == 1).ToList();

            List<Historico> Saidas = Context.Historico.Where(h => h.Lote.Gaveta == gaveta
            && h.Lote.Secao == secao
            && h.Lote.Corredor == corredor
            && h.TipoDeRegistro.Id == 2).ToList();

            if (Entradas.Count > Saidas.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static List<Lote> ListarLotesEmEstoquePorUsuario(Usuario usuario)
        {
            List<Historico> historicos = Context.Historico.Where(x => x.Usuario.Equals(usuario) && x.TipoDeRegistro.Id == 1).ToList();
            List<Lote> lotesEmEstoque = new List<Lote>();

            foreach (var item in historicos)
            {
                if (ValidarSaidaLote(item.Lote.Id))
                    lotesEmEstoque.Add(item.Lote);
            }

            return lotesEmEstoque;
        }

        public static List<Lote> ListarEntradasDeLotesPorDataDeVencimento(DateTime dataDeVencimento)
        {
            List<Historico> historicos = Context.Historico.Where(x => x.Lote.DataDeVencimento.Equals(dataDeVencimento) && x.TipoDeRegistro.Id == 1).ToList();

            List<Lote> lotes = new List<Lote>();

            foreach (var item in historicos)
            {
                lotes.Add(item.Lote);
            }

            return lotes;
        }

        public static List<Lote> ListarEtradasDeLotesPorProduto(Produto produto)
        {
            List<Historico> historicos = Context.Historico.Where(x => x.Lote.Produto.Equals(produto) && x.TipoDeRegistro.Id == 1).ToList();

            List<Lote> lotes = new List<Lote>();

            foreach (var item in historicos)
            {
                lotes.Add(item.Lote);
            }

            return lotes;
        }

        public static List<Lote> ListarEntradasDeLotesPorUsuario(Usuario usuario)
        {
            List<Historico> historicos = Context.Historico.Where(x => x.Usuario.Equals(usuario) && x.TipoDeRegistro.Id == 1).ToList();

            List<Lote> lotes = new List<Lote>();

            foreach (var item in historicos)
            {
                lotes.Add(item.Lote);
            }

            return lotes;
        }

        public static List<Lote> ListarSaidasDeLotesPorDataDeVencimento(DateTime dataDeVencimento)
        {
            List<Historico> historicos = Context.Historico.Where(x => x.Lote.DataDeVencimento.Equals(dataDeVencimento) && x.TipoDeRegistro.Id == 2).ToList();

            List<Lote> lotes = new List<Lote>();

            foreach (var item in historicos)
            {
                lotes.Add(item.Lote);
            }

            return lotes;
        }

        public static List<Lote> ListarSaidasDeLotesPorProduto(Produto produto)
        {
            List<Historico> historicos = Context.Historico.Where(x => x.Lote.Produto.Equals(produto) && x.TipoDeRegistro.Id == 2).ToList();

            List<Lote> lotes = new List<Lote>();

            foreach (var item in historicos)
            {
                lotes.Add(item.Lote);
            }

            return lotes;
        }

        public static List<Lote> ListarSaidasDeLotesPorUsuario(Usuario usuario)
        {
            List<Historico> historicos = Context.Historico.Where(x => x.Usuario.Equals(usuario) && x.TipoDeRegistro.Id == 2).ToList();

            List<Lote> lotes = new List<Lote>();

            foreach (var item in historicos)
            {
                lotes.Add(item.Lote);
            }

            return lotes;
        }
    }
}
