using System.Collections.Generic;
using System.Linq;
using Bierhalle.Models.Domain;

namespace Bierhalle.Tests.Controllers
{
    public  class DummyDataContext
    {
        //bevat alle testgevallen : 
        //Brouwer Bavik - alle gegevens zijn ingevuld
        //Brouwer Moortgat - sommige gegevens zijn nog null
        //Brouwer DeLeeuw bevat geen bieren.
        public  IQueryable<Gemeente> GemeenteLijst {get ; private set;}
        public  IQueryable<Brouwer> BrouwerLijst { get; private set; }
        public Brouwer Bavik { get; private set; }
        public Brouwer Moortgat { get; private set; }
        public Brouwer DeLeeuw { get; private set; }

         public  DummyDataContext()
        {
            int bierId = 1;
            int brouwerId = 1;
            Gemeente bavikhove = new Gemeente { Naam = "Bavikhove", Postcode = "8531" };
            Gemeente puurs = new Gemeente { Naam = "Puurs", Postcode = "2870" };
            Gemeente leuven = new Gemeente { Naam = "Leuven", Postcode = "3000" };
          
             GemeenteLijst =
                 (new Gemeente[] {bavikhove,  puurs, leuven}).ToList().AsQueryable();

            Bavik = new Brouwer("Bavik", bavikhove, "Rijksweg 33"){BrouwerId = brouwerId++};
            Bavik.AddBier("Bavik Pils", 5.2).BierId = bierId++;
            Bavik.AddBier("Wittekerke", 5.0).BierId = bierId++;
            Bavik.Omzet = 20000000;

            Moortgat = new Brouwer("Duvel Moortgat", puurs, "Breendonkdorp 28") { BrouwerId = brouwerId++ };
            Moortgat.AddBier("Duvel", 8.5).BierId = bierId++;
 
            DeLeeuw = new Brouwer("De Leeuw") { BrouwerId = brouwerId++ };
            DeLeeuw.Omzet = 50000;

            BrouwerLijst =
              (new Brouwer[] { DeLeeuw, Moortgat, Bavik }).ToList().AsQueryable();
        }

        public Brouwer GetBrouwer(int id)
        {
            return BrouwerLijst.FirstOrDefault(b=>b.BrouwerId==id);
        }
    }
}