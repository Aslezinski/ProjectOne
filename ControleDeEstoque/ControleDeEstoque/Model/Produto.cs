using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Model
{
    [Table("Produto")]
    class Produto
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataDeCadastro { get; set; }

        public string Status { get; set; }

        public Usuario Usuario { get; set; }
    }
}
