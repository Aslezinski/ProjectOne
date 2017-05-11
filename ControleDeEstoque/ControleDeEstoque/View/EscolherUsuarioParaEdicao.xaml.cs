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
    /// Interaction logic for EscolherUsuarioParaEdicao.xaml
    /// </summary>
    public partial class EscolherUsuarioParaEdicao : Window
    {
        public EscolherUsuarioParaEdicao()
        {
            InitializeComponent();

            List<string> Usuarios = new List<string>();
            List<Usuario> ListProdutos = UsuarioDAO.ListarUsuarios();

            foreach (var item in ListProdutos)
            {
                Usuarios.Add(item.Login);
            }

            ListaDeUsuarios.ItemsSource = Usuarios;
        }

        private void EditarUsuario(object sender, RoutedEventArgs e)
        {
            string UsuarioEdicao = ListaDeUsuarios.SelectionBoxItem.ToString();

            Application.Current.Properties["UsuarioEdicao"] = UsuarioEdicao;

            CadastrarUsuario CadastrarUsuario = new CadastrarUsuario();
            CadastrarUsuario.ShowDialog();
            this.Close();
        }
    }
}
