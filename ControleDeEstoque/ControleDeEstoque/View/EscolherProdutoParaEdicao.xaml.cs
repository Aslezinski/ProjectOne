using ControleDeEstoque.DAL;
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
    /// Interaction logic for EscolherProdutoParaEdicao.xaml
    /// </summary>
    public partial class EscolherProdutoParaEdicao : Window
    {
        public EscolherProdutoParaEdicao()
        {
            InitializeComponent();

            List<string> Usuarios = new List<string>();
            List<Produto> ListProdutos = ProdutoDAO.ListarProdutos();

            foreach (var item in ListProdutos)
            {
                Usuarios.Add(item.Nome);
            }

            ListaDeProdutos.ItemsSource = Usuarios;
        }

        private void EditarProduto(object sender, RoutedEventArgs e)
        {
            string ProdutoEdicao = ListaDeProdutos.SelectionBoxItem.ToString();

            Application.Current.Properties["ProdutoEdicao"] = ProdutoEdicao;

            CadastrarProduto CadastrarProduto = new CadastrarProduto();
            CadastrarProduto.ShowDialog();
            this.Close();
        }
    }
}
