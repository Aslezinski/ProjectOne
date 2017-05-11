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
    public partial class ListarSaidaDeLote : Form
    {
        DateTime DataVencimento;
        DateTime DataSaida;
        string Produto;
        string Usuario;

        public ListarSaidaDeLote(DateTime DataVencimento, DateTime DataSaida, string Produto, string Usuario)
        {
            InitializeComponent();

            this.DataVencimento = DataVencimento;
            this.DataSaida = DataSaida;
            this.Produto = Produto;
            this.Usuario = Usuario;
        }

        private void ListarSaidaDeLote_Load(object sender, EventArgs e)
        {
            this.listarSaidaDeLotesTableAdapter.Fill(this.controleDeEstoqueDataSet.ListarSaidaDeLotes, DataVencimento, Produto, DataSaida, Usuario);
            this.reportViewer1.RefreshReport();
        }
    }
}
