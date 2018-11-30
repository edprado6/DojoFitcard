using DojoFitcard.Domain.Entities;
using MySql.Data.Entity;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace DojoFitcard.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Database : DbContext
    {
        public Database()
            : base("NomeBanco") {

            Configuration.ValidateOnSaveEnabled = false;
        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Estabelecimento> Estabelecimento { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Categoria>().ToTable("categoria");
            modelBuilder.Entity<Estabelecimento>().ToTable("estabelecimento");
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Id") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("Id").CurrentValue = Guid.NewGuid().ToString();
                }
            }

            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("UltimaAtualizacao") != null))
            {                
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("UltimaAtualizacao").CurrentValue = DateTime.Now;
                   
                }
            }
                        
            return base.SaveChanges();
        }
    }
}
