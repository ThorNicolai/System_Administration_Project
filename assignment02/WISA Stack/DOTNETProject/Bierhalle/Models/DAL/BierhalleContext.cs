using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;
using Bierhalle.Models.DAL.Mapper;
using Bierhalle.Models.Domain;
using System.Data.Entity;


namespace Bierhalle.Models.DAL
{
    public class BierhalleContext : DbContext
    {
        public BierhalleContext() : base("Bierhalle")
        {
        }

        public DbSet<Brouwer> Brouwers { get; set; }
        public DbSet<Gemeente> Gemeenten { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
