using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using Bierhalle.Models.Domain;

namespace Bierhalle.Models.DAL
{
    public class BierhalleInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BierhalleContext> 
    {
        protected override void Seed(BierhalleContext context)
        {
            try
            {
                Gemeente bavikhove = new Gemeente {Naam = "Bavikhove", Postcode = "8531"};
                Gemeente roeselare = new Gemeente {Naam = "Roeselare", Postcode = "8800"};
                Gemeente puurs = new Gemeente {Naam = "Puurs", Postcode = "2870"};
                Gemeente leuven = new Gemeente {Naam = "Leuven", Postcode = "3000"};
                Gemeente oudenaarde = new Gemeente {Naam = "Oudenaarde", Postcode = "9700"};
                Gemeente affligem = new Gemeente {Naam = "Affligem", Postcode = "1790"};
                Gemeente[] gemeenten =
                    new Gemeente[] {bavikhove, roeselare, puurs, leuven, oudenaarde, affligem};
                context.Gemeenten.AddRange(gemeenten);

                Brouwer bavik = new Brouwer("Bavik", bavikhove, "Rijksweg 33");
                context.Brouwers.Add(bavik);
                bavik.AddBier("Bavik Pils", 5.2);
                bavik.AddBier("Wittekerke", 5.0);
                bavik.AddBier("Wittekerke Speciale", 5.8);
                bavik.AddBier("Wittekerke Rosé", 4.3);
                bavik.AddBier("Ezel Wit", 5.8);
                bavik.AddBier("Ezel Bruin", 6.5);
                bavik.Omzet = 20000000;

                Brouwer palm = new Brouwer("Palm Breweries");
                context.Brouwers.Add(palm);
                palm.AddBier("Estimanet", 5.2);
                palm.AddBier("Steenbrugge Blond", 6.5);
                palm.AddBier("Palm", 5.4);
                palm.AddBier("Dobbel Palm", 6.0);
                palm.Omzet = 500000;

                Brouwer duvelMoortgat = new Brouwer("Duvel Moortgat", puurs, "Breendonkdorp 28");
                context.Brouwers.Add(duvelMoortgat);
                duvelMoortgat.AddBier("Duvel", 8.5);
                duvelMoortgat.AddBier("Vedett");
                duvelMoortgat.AddBier("Maredsous");
                duvelMoortgat.AddBier("Liefmans Kriekbier");
                duvelMoortgat.AddBier("La Chouffe", 8.0);
                duvelMoortgat.AddBier("De Koninck", 5.0);

                Brouwer inBev = new Brouwer("InBev", leuven, "Brouwerijplein 1");
                context.Brouwers.Add(inBev);
                inBev.AddBier("Jupiler");
                inBev.AddBier("Stella Artois");
                inBev.AddBier("Leffe");
                inBev.AddBier("Belle-Vue");
                inBev.AddBier("Hoegaarden");

                Brouwer roman = new Brouwer("Roman", oudenaarde, "Hauwaart 105");
                context.Brouwers.Add(roman);
                roman.AddBier("Sloeber", 7.5);
                roman.AddBier("Black Hole", 5.6);
                roman.AddBier("Ename", 6.5);
                roman.AddBier("Romy Pils", 5.1);

                Brouwer deGraal = new Brouwer("De Graal");
                context.Brouwers.Add(deGraal);

                Brouwer deLeeuw = new Brouwer("De Leeuw");
                context.Brouwers.Add(deLeeuw);

                context.SaveChanges();
            }

            catch (DbEntityValidationException e)
            {
                string s = "Fout creatie database ";
                foreach (var eve in e.EntityValidationErrors)
                {
                    s += String.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                         eve.Entry.Entity.GetType().Name, eve.Entry.GetValidationResult());
                    foreach (var ve in eve.ValidationErrors)
                    {
                        s += String.Format("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw new Exception(s);
            }

        }
    }
}
