using ControleDeEstoque.DAO;
using ControleDeEstoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Controller
{
    class UsuarioController
    {
        public static Usuario Login(Usuario usuario)
        {
            return UsuarioDAO.Login(usuario);
        }

        public static bool CadastrarUsuario(Usuario usuario)
        {
            try
            {
                if (UsuarioDAO.ValidarLogin(usuario.Login))
                {
                    UsuarioDAO.CadastrarUsuario(usuario);
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

        public static bool EditarUsuario(Usuario usuario, Usuario usuarioEditado)
        {
            try
            {
                if ((usuario.Login == usuarioEditado.Login) || (UsuarioDAO.ValidarLogin(usuarioEditado.Login)))
                {
                    UsuarioDAO.EditarUsuario(usuario, usuarioEditado);
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

        public static Usuario CarregarUsuario(string LoginUsuario)
        {
            return UsuarioDAO.CarregarUsuario(LoginUsuario);
        }

        public static List<Usuario> ListarUsuarios()
        {
            return UsuarioDAO.ListarUsuarios();
        }
    }
}
