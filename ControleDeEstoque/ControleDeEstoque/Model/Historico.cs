using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Model
{
    [Table("Historico")]
    class Historico
    {
        [Key]
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public Usuario Usuario { get; set; }

        public TipoDeRegistro TipoDeRegistro { get; set; }

        public Lote Lote { get; set; }
    }
}
