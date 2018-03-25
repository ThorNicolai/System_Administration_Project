using System.Data.Entity;
using System.Linq;
using Bierhalle.Models.Domain;

namespace Bierhalle.Models.DAL
{
    public class BrouwerRepository : IBrouwerRepository
    {
        private BierhalleContext context;
        private DbSet<Brouwer> brouwers;

        public BrouwerRepository(BierhalleContext context)
        {
            this.context = context;
            brouwers = context.Brouwers;
        }

        public IQueryable<Brouwer> FindAll()
        {
            return brouwers;
        }
        public Brouwer FindBy(int brouwerId)
        {
            //return brouwers.Find(brouwerId);
            return brouwers.Include(b => b.Gemeente).FirstOrDefault(b=>b.BrouwerId==brouwerId);
        }
        public void Add(Brouwer brouwer)
        {
            brouwers.Add(brouwer);
        }
        public void Delete(Brouwer brouwer)
        {
            brouwers.Remove(brouwer);
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}