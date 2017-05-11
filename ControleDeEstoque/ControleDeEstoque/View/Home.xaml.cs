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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
            TelaLogin TelaLogin = new TelaLogin();
            TelaLogin.ShowDialog();

            if (Application.Current.Properties["UsuarioLogado"] == null)
                this.Close();
        }

        private void ListarLotesEmEstoquePorDataVencimento(object sender, RoutedEventArgs e)
        {
            
        }

        private void Sair(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja sair?", "Controle de estoque", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    this.Close();
                    break;
                case MessageBoxResult.No:
                    break;
            }
        }

        private void CadastrarUsuario(object sender, RoutedEventArgs e)
        {
            Usuario usuarioLogado = (Usuario)Application.Current.Properties["UsuarioLogado"];
            if (usuarioLogado.TipoUsuario.Descricao == "Administrador")
            {
                CadastrarUsuario CadastrarUsuario = new CadastrarUsuario();
                CadastrarUsuario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Este usuário não tem permissão!", "Controle de estoque");
            }
        }

        private void CadastrarProduto(object sender, RoutedEventArgs e)
        {
            Usuario usuarioLogado = (Usuario)Application.Current.Properties["UsuarioLogado"];
            if (usuarioLogado.TipoUsuario.Descricao == "Administrador" || usuarioLogado.TipoUsuario.Descricao == "Operacional")
            {
                CadastrarProduto CadastrarProduto = new CadastrarProduto();
                CadastrarProduto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Este usuário não tem permissão!", "Controle de estoque");
            }
        }

        private void CadastrarEntradaLote(object sender, RoutedEventArgs e)
        {
            Usuario usuarioLogado = (Usuario)Application.Current.Properties["UsuarioLogado"];
            if (usuarioLogado.TipoUsuario.Descricao == "Administrador" || usuarioLogado.TipoUsuario.Descricao == "Operacional")
            {
                RegistrarEntradaLote RegistrarEntradaLote = new RegistrarEntradaLote();
                RegistrarEntradaLote.ShowDialog();
            }
            else
            {
                MessageBox.Show("Este usuário não tem permissão!", "Controle de estoque");
            }
        }

        private void CadastrarSaidaLote(object sender, RoutedEventArgs e)
        {
            Usuario usuarioLogado = (Usuario)Application.Current.Properties["UsuarioLogado"];
            if (usuarioLogado.TipoUsuario.Descricao == "Administrador" || usuarioLogado.TipoUsuario.Descricao == "Operacional")
            {
                RegistrarSaídaLote RegistrarSaídaLote = new RegistrarSaídaLote();
                RegistrarSaídaLote.ShowDialog();
            }
            else
            {
                MessageBox.Show("Este usuário não tem permissão!", "Controle de estoque");
            }
        }

        private void EditarUsuario(object sender, RoutedEventArgs e)
        {
            Usuario usuarioLogado = (Usuario)Application.Current.Properties["UsuarioLogado"];
            if (usuarioLogado.TipoUsuario.Descricao == "Administrador")
            {
                EscolherUsuarioParaEdicao EscolherUsuarioParaEdicao = new EscolherUsuarioParaEdicao();
                EscolherUsuarioParaEdicao.ShowDialog();
            }
            else
            {
                MessageBox.Show("Este usuário não tem permissão!", "Controle de estoque");
            }
        }

        private void EditarProduto(object sender, RoutedEventArgs e)
        {
            Usuario usuarioLogado = (Usuario)Application.Current.Properties["UsuarioLogado"];
            if (usuarioLogado.TipoUsuario.Descricao == "Administrador" || usuarioLogado.TipoUsuario.Descricao == "Operacional")
            {
                EscolherProdutoParaEdicao EscolherProdutoParaEdicao = new EscolherProdutoParaEdicao();
                EscolherProdutoParaEdicao.ShowDialog();
            }
            else
            {
                MessageBox.Show("Este usuário não tem permissão!", "Controle de estoque");
            }
        }

        private void ListarProdutos(object sender, RoutedEventArgs e)
        {
            ListarProdutos ListarProdutos = new ListarProdutos();
            ListarProdutos.ShowDialog();
        }

        private void ListarUsuarios(object sender, RoutedEventArgs e)
        {
            ListarUsuarios ListarUsuarios = new ListarUsuarios();
            ListarUsuarios.ShowDialog();
        }

        private void ListarLotesEmEstoque(object sender, RoutedEventArgs e)
        {
            FiltrosListarLotesEmEstoque FiltrosListarLotesEmEstoque = new FiltrosListarLotesEmEstoque();
            FiltrosListarLotesEmEstoque.ShowDialog();
        }

        private void ListarEntradaDeLotes(object sender, RoutedEventArgs e)
        {
            FiltroListarEntradaDeLotes FiltroListarEntradaDeLotes = new FiltroListarEntradaDeLotes();
            FiltroListarEntradaDeLotes.ShowDialog();
        }

        private void ListarSaidaDeLotes(object sender, RoutedEventArgs e)
        {
            FiltrosListarSaidaDeLotes FiltrosListarSaidaDeLotes = new FiltrosListarSaidaDeLotes();
            FiltrosListarSaidaDeLotes.ShowDialog();
        }
    }
}
