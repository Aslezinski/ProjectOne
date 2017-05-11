using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Model
{
    [Table("Usuario")]
    class Usuario
    {
        [Key]
        public int Id { get; set; }

        public string Login{ get; set; }

        public string Senha { get; set; }

        public DateTime DataDeCadastro { get; set; }

        public string Status { get; set; }

        public TipoUsuario TipoUsuario { get; set; }
    }



}
