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
    /// Interaction logic for RegistrarEntradaLote.xaml
    /// </summary>
    public partial class RegistrarEntradaLote : Window
    {
        public RegistrarEntradaLote()
        {
            InitializeComponent();

            List<string> Produtos = new List<string>();
            List<string> Enderecos = new List<string>();
            List<Produto> ListProdutos = ProdutoController.ListarProdutosAtivos();
            List<Endereco> ListEnderecos = EnderecoDAO.ListarEnderecos();

            foreach (var item in ListProdutos)
            {
                Produtos.Add(item.Nome);
            }

            foreach (var item in ListEnderecos)
            {
                Enderecos.Add(item.Descricao);
            }

            Produto.ItemsSource = Produtos;
            Endereco.ItemsSource = Enderecos;
        }

        private void Registrar(object sender, RoutedEventArgs e)
        {         
            try
            {
                Lote Lote = new Lote();
                Lote.DataDeFabricacao = DataDeFabricacao.SelectedDate.Value;
                Lote.DataDeVencimento = DataDeVencimento.SelectedDate.Value;
                Lote.Corredor = Corredor.SelectionBoxItem.ToString();
                Lote.Secao = Secao.SelectionBoxItem.ToString();
                Lote.Gaveta = Gaveta.SelectionBoxItem.ToString();

                Lote.Endereco = EnderecoDAO.GetEnderecoPorDescricao(Endereco.SelectionBoxItem.ToString());
                Lote.Produto = ProdutoDAO.GetProdutoPorNome(Produto.SelectionBoxItem.ToString());  
                
                Lote.QuantidadeDeProdutos = Convert.ToInt32(QuantidadeDeProdutos.Text);

                if(LoteDAO.ValidarGaveta(Lote.Gaveta, Lote.Corredor, Lote.Secao))
                {
                    MessageBox.Show("Esta gaveta já esta ocupada.", "Registrar entrada de lote");
                }
                else if (LoteController.CadastrarEntradaDeLote(Lote))
                {
                    MessageBox.Show("Lote Cadastrado com sucesso!", "Registrar saída de lote");
                }
                else
                {
                    MessageBox.Show("Por favor informe valores válidos", "Registrar entrada de lote");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor informe valores válidos", "Registrar entrada de lote");
            }
        }
    }
}
