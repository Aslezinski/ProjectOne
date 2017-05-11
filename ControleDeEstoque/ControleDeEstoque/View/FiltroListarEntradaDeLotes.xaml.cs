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
    /// Interaction logic for FiltroListarEntradaDeLotes.xaml
    /// </summary>
    public partial class FiltroListarEntradaDeLotes : Window
    {
        public FiltroListarEntradaDeLotes()
        {
            InitializeComponent();

            List<string> Produtos = new List<string>();
            List<string> Usuarios = new List<string>();
            List<Produto> ListProdutos = ProdutoController.ListarProdutosAtivos();
            List<Usuario> ListUsuarios = UsuarioController.ListarUsuarios();

            foreach (var item in ListProdutos)
            {
                Produtos.Add(item.Nome);
            }

            foreach (var item in ListUsuarios)
            {
                Usuarios.Add(item.Login);
            }

            Produto.ItemsSource = Produtos;
            Usuario.ItemsSource = Usuarios;
        }

        private void Filtrar(object sender, RoutedEventArgs e)
        {
            ListarEntradaDeLotes ListarEntradaDeLotes = new ListarEntradaDeLotes(DataVencimento.SelectedDate.HasValue ? DataVencimento.SelectedDate.Value : DateTime.Now, DataEntrada.SelectedDate.HasValue ? DataEntrada.SelectedDate.Value : DateTime.Now, Produto.Text, Usuario.Text);
            ListarEntradaDeLotes.ShowDialog();
        }
    }
}
