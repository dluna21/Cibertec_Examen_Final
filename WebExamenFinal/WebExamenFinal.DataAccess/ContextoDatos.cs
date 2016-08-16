using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebExamenFinal.Model;

namespace WebExamenFinal.DataAccess
{
    public class ContextoDatos : DbContext
    {
        public ContextoDatos() : base("name=WebDeveloperConnectionString")
        {
        }

        public virtual DbSet<AutorLibro> AutorLibro { get; set; }
        public virtual DbSet<Autores> Autor { get; set; }
        public virtual DbSet<Libros> Libro { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Autores>()
           .HasKey(e => e.au_id);
             
            modelBuilder.Entity<Libros>()
           .HasKey(e => e.titulo_id);

            modelBuilder.Entity<AutorLibro>()
           .HasKey(e => e.au_id)
           .HasKey(e => e.titulo_id);

        }
    }
}
