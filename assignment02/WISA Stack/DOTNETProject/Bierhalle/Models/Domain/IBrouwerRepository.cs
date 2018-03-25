using System.Linq;

namespace Bierhalle.Models.Domain
{
    public interface IBrouwerRepository
    {
        Brouwer FindBy(int brouwerId);
        IQueryable<Brouwer> FindAll();
        void Add(Brouwer brouwer);
        void Delete(Brouwer brouwer);
        void SaveChanges();
    }
}