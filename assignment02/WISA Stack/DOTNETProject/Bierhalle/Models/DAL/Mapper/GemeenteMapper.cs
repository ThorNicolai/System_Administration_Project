using System.Data.Entity.ModelConfiguration;
using Bierhalle.Models.Domain;

namespace Bierhalle.Models.DAL.Mapper
{
    public class GemeenteMapper : EntityTypeConfiguration<Gemeente>
    {
        public GemeenteMapper()
        {
            //Primary Key
            HasKey(t => t.Postcode);

            //Properties
            Property(t => t.Naam).IsRequired().HasMaxLength(100);
            Property(t => t.Postcode).HasMaxLength(4).IsFixedLength();

            //Table
            ToTable("Gemeente");
        }
    }
}