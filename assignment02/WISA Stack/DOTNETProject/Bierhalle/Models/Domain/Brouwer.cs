using System;
using System.Collections.Generic;
using System.Linq;

namespace Bierhalle.Models.Domain
{
    public class Brouwer
    {
        #region Fields

        private string naam;
        private int? omzet = null;
        #endregion

        #region Constructors
        public Brouwer()
        {
            Bieren = new HashSet<Bier>();
            omzet = null;
        }

        public Brouwer(string naam):this()
        {
            Naam = naam;
        }

        public Brouwer(string naam, Gemeente gemeente, string straat)
            : this(naam)
        {
            this.Gemeente = gemeente;
            this.Straat = straat;
        }
        #endregion

        #region Properties
  
        public int BrouwerId { get; set; }
        public string Naam
        {
            get { return naam; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Een brouwer moet een naam hebben");
                if (value.Length > 50)
                    throw new ArgumentException("Brouwernaam mag maximaal 50 karakters lang zijn");
                naam = value;
            }
        }
        
        public string Straat { get; set; }        // mag null zijn
        public virtual Gemeente Gemeente { get; set; }    // mag null zijn
        public int? Omzet  
        {
            get { return omzet; }
            set
            {
                if (value.HasValue && value.Value < 0)  // pas op, eerst checken op null, pas daarna controleren of <0
                    throw new ArgumentException("Omzet mag niet kleiner zijn dan 0");
                omzet = value;
            }
        }

        public virtual ICollection<Bier> Bieren { get; private set; }
       
        public int AantalBieren
        {
            get
            {
                return Bieren.Count;
            }
        }      
        #endregion

        #region public Methods
        public Bier AddBier(string naam, double? alcoholPercentage = null)
        {
            if (naam != null && Bieren.FirstOrDefault(bier => bier.Naam == naam) != null)
                throw new ArgumentException("Deze brouwer heeft al een bier met dezelfde naam");
            Bier nieuwBier = new Bier(naam)
            {
                AlcoholPercentage = alcoholPercentage
            };
            Bieren.Add(nieuwBier);
            return nieuwBier;
        }

        public void DeleteBier(Bier bier)
        {
            if (!Bieren.Contains(bier))
                throw new ArgumentException(string.Format("{0} is geen bier van {1}", bier.Naam, this.Naam));
            Bieren.Remove(bier);
        }

        public Bier FindBy(int bierId)
        {
            return Bieren.FirstOrDefault(b => b.BierId == bierId);
        }
        #endregion
    }
}
