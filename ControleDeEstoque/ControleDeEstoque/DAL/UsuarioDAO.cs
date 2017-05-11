using ControleDeEstoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.DAO
{
    class UsuarioDAO
    {
        private static Context Context = Singleton.Instance.Context;

        public static Usuario Login(Usuario usuario)
        {
            Usuario usuarioLogado = Context.Usuario.Include("TipoUsuario").Where(u => u.Login == usuario.Login && u.Senha == usuario.Senha).FirstOrDefault();
            return usuarioLogado;
        }

        public static bool CadastrarUsuario(Usuario usuario)
        {
            Context.Usuario.Add(usuario);
            Context.SaveChanges();
            return true;
        }

        public static bool ValidarLogin(string login)
        {
            if (Context.Usuario.Where(u => u.Login == login).FirstOrDefault() == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool EditarUsuario(Usuario usuario, Usuario usuarioEditado)
        {
            Context.Entry(usuario).CurrentValues.SetValues(usuarioEditado);
            Context.SaveChanges();
            return false;
        }

        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            usuarios = Context.Usuario.ToList();

            return usuarios;
        }

        public static Usuario CarregarUsuario(string loginUsuario)
        {
            return Context.Usuario.Where(x => x.Login == loginUsuario).FirstOrDefault();
        }

    }
}
