using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Model
{
    [Table("Lote")]
    class Lote
    {
        [Key]
        public int Id { get; set; }

        public DateTime DataDeFabricacao { get; set; }

        public DateTime DataDeVencimento { get; set; }

        public int QuantidadeDeProdutos { get; set; }

        public string Corredor { get; set; }

        public string Secao { get; set; }

        public string Gaveta { get; set; }

        public Endereco Endereco { get; set; }

        public Produto Produto { get; set; }

    }
}
