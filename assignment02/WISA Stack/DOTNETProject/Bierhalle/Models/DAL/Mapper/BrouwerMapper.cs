using System.Data.Entity.ModelConfiguration;
using Bierhalle.Models.Domain;

namespace Bierhalle.Models.DAL.Mapper
{
    public class BrouwerMapper : EntityTypeConfiguration<Brouwer>
    {
        public BrouwerMapper()
        {
            //properties
            Property(t => t.Naam).IsRequired().HasMaxLength(100);
            Property(t => t.Straat).HasMaxLength(100);

            //Table
            ToTable("Brouwer"); 

            //Relationships
            HasMany(t => t.Bieren)
                .WithRequired()
                .Map(m => m.MapKey("BrouwerId"))
                .WillCascadeOnDelete(false);
             HasOptional(t => t.Gemeente)
                .WithMany()
                .Map(m => m.MapKey("Postcode"))
                .WillCascadeOnDelete(false);
        }
    }
}