using ControleDeEstoque.Controller;
using ControleDeEstoque.DAL;
using ControleDeEstoque.DAO;
using ControleDeEstoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ControleDeEstoque.View
{
    /// <summary>
    /// Interaction logic for CadastrarUsuario.xaml
    /// </summary>
    public partial class CadastrarUsuario : Window
    {
        public CadastrarUsuario()
        {
            InitializeComponent();

            if (Application.Current.Properties["UsuarioEdicao"] != null)
            {
                string UsuarioEdicao = (string)Application.Current.Properties["UsuarioEdicao"];
                Usuario usuario = UsuarioDAO.CarregarUsuario(UsuarioEdicao);

                Login.Text = usuario.Login;
                Senha.Password = usuario.Senha;
                RepetirSenha.Password = usuario.Senha;
                ID.Text = Convert.ToString(usuario.Id);
            }
        }

        private void CadastrarUsuarioClick(object sender, RoutedEventArgs e)
        {
            Usuario usuario = new Usuario();
            List<TipoUsuario> TiposDeUsuario = TipoUsuarioDao.TiposUsuario();

            if (Senha.Password != RepetirSenha.Password)
                MessageBox.Show("As senhas não conferem", "Cadastro de usuário");
            else if (string.IsNullOrWhiteSpace(Login.Text) || string.IsNullOrWhiteSpace(Senha.Password) || string.IsNullOrEmpty(Login.Text) || string.IsNullOrEmpty(Senha.Password))
                MessageBox.Show("Preencha todos os campos corretamente", "Cadastro de usuário");
            else
            {
                usuario.Login = Login.Text;
                usuario.Senha = Senha.Password;
                usuario.Status = (Ativo.IsChecked.Value ? "Ativo" : "Inativo");
                usuario.DataDeCadastro = DateTime.Now;
                TipoUsuario TipoUsuario;

                if (Administrador.IsChecked.Value)
                {
                    TipoUsuario = TiposDeUsuario.SingleOrDefault(t => t.Descricao == "Administrador");
                    usuario.TipoUsuario = TipoUsuario;
                }
                else if (Visualizador.IsChecked.Value)
                {
                    TipoUsuario = TiposDeUsuario.SingleOrDefault(t => t.Descricao == "Visualizador");
                    usuario.TipoUsuario = TipoUsuario;
                }
                else
                {
                    TipoUsuario = TiposDeUsuario.SingleOrDefault(t => t.Descricao == "Operacional");
                    usuario.TipoUsuario = TipoUsuario;
                }

                if (!string.IsNullOrWhiteSpace(ID.Text))
                {
                    usuario.Id = Convert.ToInt32(ID.Text);

                    string StringUsuario = (string)Application.Current.Properties["UsuarioEdicao"];
                    Usuario UsuarioAntigo = UsuarioDAO.CarregarUsuario(StringUsuario);

                    if (!UsuarioController.EditarUsuario(UsuarioAntigo, usuario))
                        MessageBox.Show("Login já esta sendo usado", "Cadastro de usuário");
                    else
                        MessageBox.Show("Edição efetuada com sucesso", "Edição de usuário");
                }
                else if (UsuarioController.CadastrarUsuario(usuario))
                {
                    MessageBox.Show("Cadastro efetuado com sucesso", "Cadastro de usuário");
                }
                else
                {
                    MessageBox.Show("Login já esta sendo usado", "Cadastro de usuário");
                }
            }
        }
    }
}
