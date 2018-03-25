using System.Linq;

namespace Bierhalle.Models.Domain
{
    public interface IGemeenteRepository
    {
        Gemeente FindBy(string postcode);
        IQueryable<Gemeente> FindAll();
    }
}