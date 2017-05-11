using ControleDeEstoque.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.DAO
{
    class Context : DbContext
    {
        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Historico> Historico { get; set; }

        public DbSet<Lote> Lote { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<TipoDeRegistro> TipoDeRegistro { get; set; }

        public DbSet<TipoUsuario> TipoUsuario { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

    }
}
