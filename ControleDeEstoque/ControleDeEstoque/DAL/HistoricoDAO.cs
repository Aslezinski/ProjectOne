using ControleDeEstoque.DAO;
using ControleDeEstoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ControleDeEstoque.DAL
{
    class HistoricoDAO
    {
        private static Context Context = Singleton.Instance.Context;
        
        public static bool GerarHistoricoSaidaLote(Lote lote)
        {
            try
            {
                Historico historico = new Historico();

                historico.Data = DateTime.Now;
                historico.Lote = lote;
                historico.TipoDeRegistro = Context.TipoDeRegistro.Where(t => t.Id == 2).FirstOrDefault();
                historico.Usuario = (Usuario)Application.Current.Properties["UsuarioLogado"];

                Context.Historico.Add(historico);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool GerarHistoricoEntradaLote(Lote lote)
        {
            try
            {
                Historico historico = new Historico();

                historico.Data = DateTime.Now;
                historico.Lote = lote;
                historico.TipoDeRegistro = Context.TipoDeRegistro.Where(t => t.Id == 1).FirstOrDefault();
                historico.Usuario = (Usuario)Application.Current.Properties["UsuarioLogado"];

                Context.Historico.Add(historico);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        
    }
}
