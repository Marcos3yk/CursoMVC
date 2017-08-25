using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MV.CursoMvc.Domain.Entities;
using MV.CursoMvc.Infra.Data.EntityConfig;

namespace MV.CursoMvc.Infra.Data.Context
{
   public class CursoMvcContext : DbContext        
    {
        public CursoMvcContext()
            : base("CursoMvcContext")
        {

        }

        public DbSet<Cliente> Clientes{ get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new EnderecoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
