using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Model
{
    [Table("TipoDeRegistro")]
    class TipoDeRegistro
    {
        [Key]
        public int Id { get; set; }

        public string Descricao { get; set; }
    }
}
