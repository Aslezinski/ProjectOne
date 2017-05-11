using ControleDeEstoque.Controller;
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
    /// Interaction logic for Cadastrar.xaml
    /// </summary>
    public partial class CadastrarProduto : Window
    {
        public CadastrarProduto()
        {
            InitializeComponent();

            if (Application.Current.Properties["ProdutoEdicao"] != null)
            {
                string ProdutoEdicao = (string)Application.Current.Properties["ProdutoEdicao"];
                Produto Produto = ProdutoDAO.GetProdutoPorNome(ProdutoEdicao);

                Nome.Text = Produto.Nome;
                ID.Text = Convert.ToString(Produto.Id);
            }
        }

        private void BtnCadastrar(object sender, RoutedEventArgs e)
        {
            Produto Produto = new Produto();

            string StringProduto = (string)Application.Current.Properties["ProdutoEdicao"];
            Produto ProdutoAntigo = ProdutoDAO.GetProdutoPorNome(StringProduto);

            if ((ProdutoAntigo.Nome == Produto.Nome || !string.IsNullOrWhiteSpace(ID.Text)) && !string.IsNullOrWhiteSpace(Nome.Text) && !string.IsNullOrEmpty(Nome.Text))
            {
                Produto.Id = Convert.ToInt32(ID.Text);

                ProdutoController.EditarProduto(ProdutoAntigo, Produto);
                MessageBox.Show("Edição efetuada com sucesso", "Edição de produto");
            }
            else if (ProdutoDAO.ValidarProduto(Nome.Text) && !string.IsNullOrWhiteSpace(Nome.Text) && !string.IsNullOrEmpty(Nome.Text))
            {
                Produto.Nome = Nome.Text;
                Produto.Status = (Ativo.IsChecked.Value ? "Ativo" : "Inativo");
                Produto.DataDeCadastro = DateTime.Now;
                Produto.Usuario = (Usuario)Application.Current.Properties["UsuarioLogado"];

                ProdutoController.CadastrarProduto(Produto);

                MessageBox.Show("Produto cadastrado com sucesso!", "Cadastro de produto");
            }
            else
            {
                if(!ProdutoDAO.ValidarProduto(Nome.Text))
                    MessageBox.Show("O nome de produto já esta sendo usado.", "Cadastro de produto");
                else
                    MessageBox.Show("Escreva o nome do produto.", "Cadastro de produto");
            }
        }
    }
}
