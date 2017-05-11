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
    public partial class ListarEntradaDeLotes : Form
    {
        DateTime DataVencimento;
        DateTime DataEntrada;
        string Produto;
        string Usuario;

        public ListarEntradaDeLotes(DateTime DataVencimento, DateTime DataEntrada, string Produto, string Usuario)
        {
            InitializeComponent();

            this.DataVencimento = DataVencimento;
            this.DataEntrada = DataEntrada;
            this.Produto = Produto;
            this.Usuario = Usuario;
        }

        private void ListarEntradaDeLotes_Load(object sender, EventArgs e)
        {
            this.listarEntradaDeLotesTableAdapter.Fill(this.controleDeEstoqueDataSet.ListarEntradaDeLotes, DataVencimento, Produto, DataEntrada, Usuario);
            this.reportViewer1.RefreshReport();
        }
    }
}
