using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoque.View
{
    public partial class ListarLotesEmEstoque : Form
    {
        DateTime DataVencimento;
        string Produto;
        string Usuario;

        public ListarLotesEmEstoque(DateTime DataVencimento, string Produto, string Usuario)
        {
            InitializeComponent();

            this.DataVencimento = DataVencimento;
            this.Produto = Produto;
            this.Usuario = Usuario;
        }

        private void ListarLotesEmEstoque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'controleDeEstoqueDataSet.ListarLotesEmEstoque' table. You can move, or remove it, as needed.
            this.listarLotesEmEstoqueTableAdapter.Fill(this.controleDeEstoqueDataSet.ListarLotesEmEstoque, DataVencimento, Produto, Usuario);

            this.reportViewer1.RefreshReport();
        }
    }
}
