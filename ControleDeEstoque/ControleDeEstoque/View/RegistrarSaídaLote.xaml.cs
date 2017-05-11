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
    /// Interaction logic for RegistrarSaídaLote.xaml
    /// </summary>
    public partial class RegistrarSaídaLote : Window
    {
        public RegistrarSaídaLote()
        {
            InitializeComponent();
        }

        private void BtnRegistrar(object sender, RoutedEventArgs e)
        {
            int IdLote = 0;

            try
            {
                IdLote = Convert.ToInt32(NumeroLote.Text);

                if (LoteDAO.ValidarSaidaLote(IdLote))
                {
                    Lote Lote = new Lote();
                    Lote = LoteDAO.BuscarLote(IdLote);

                    LoteController.CadastrarSaidaDeLote(Lote);
                    MessageBox.Show("Lote retirado com sucesso!", "Registrar saída de lote");

                }
                else
                {
                    MessageBox.Show("Por favor informe um número de lote que esteja em estoque.", "Registrar saída de lote");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor informe um número válido", "Registrar saída de lote");
            }     
        }
    }
}
