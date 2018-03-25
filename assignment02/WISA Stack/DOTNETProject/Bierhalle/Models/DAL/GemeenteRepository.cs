using System.Data.Entity;
using System.Linq;
using Bierhalle.Models.Domain;
namespace Bierhalle.Models.DAL
{
    public class GemeenteRepository : IGemeenteRepository
    {
        private BierhalleContext context;
        private DbSet<Gemeente> gemeenten;

        public GemeenteRepository(BierhalleContext context)
        {
            this.context = context;
            gemeenten = context.Gemeenten;
        }
        public Gemeente FindBy(string postcode)
        {
            return gemeenten.Find(postcode);
        }
        public IQueryable<Gemeente> FindAll()
        {
            return gemeenten;
        }
    }
}

