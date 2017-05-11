using ControleDeEstoque.Controller;
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
    /// Interaction logic for TelaLogin.xaml
    /// </summary>
    public partial class TelaLogin : Window
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin(object sender, RoutedEventArgs e)
        {
            Usuario usuario = new Usuario();

            if (string.IsNullOrWhiteSpace(Login.Text) && string.IsNullOrWhiteSpace(Senha.Password))
            {
                MessageBox.Show("Favor informar um login e uma senha", "Login");
            }
            else
            {
                usuario.Login = Login.Text;
                usuario.Senha = Senha.Password;

                usuario = UsuarioController.Login(usuario);

                if (usuario != null)
                {
                    Application.Current.Properties["UsuarioLogado"] = usuario;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos", "Login");
                }
            }
        }
    }
}
