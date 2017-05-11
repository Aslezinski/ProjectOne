using ControleDeEstoque.DAO;
using ControleDeEstoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.DAL
{
    class TipoUsuarioDao
    {
        private static Context Context = Singleton.Instance.Context;

        public static List<TipoUsuario> TiposUsuario()
        {
            return Context.TipoUsuario.ToList();
        }
    }
}
