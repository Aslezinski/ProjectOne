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
    public partial class ListarProdutos : Form
    {
        public ListarProdutos()
        {
            InitializeComponent();
        }

        private void ListarProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'controleDeEstoqueDataSet.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.controleDeEstoqueDataSet.Produto);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
