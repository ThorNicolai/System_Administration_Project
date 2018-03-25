using System.Data.Entity.ModelConfiguration;
using Bierhalle.Models.Domain;

namespace Bierhalle.Models.DAL.Mapper
{
    public class BierMapper : EntityTypeConfiguration<Bier>
    {
        public BierMapper()
        {
            //Properties
            Property(t => t .Naam).IsRequired().HasMaxLength(100);

            //Table
            ToTable("Bier");
        }
    }
}