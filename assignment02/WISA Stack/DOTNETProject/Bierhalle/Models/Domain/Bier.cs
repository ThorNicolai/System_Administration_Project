using System;

namespace Bierhalle.Models.Domain
{
    public class Bier
    {
        #region Attributes
       
        private string naam;
        #endregion

        #region Properties
        public string Naam 
        { 
            get {return naam;}
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Een bier moet een naam hebben");
                naam = value;
            }
        }
        public double? AlcoholPercentage { get; set; } // null indien het alcoholpercentage niet bekend is
        public bool AlcoholGekend { get { return AlcoholPercentage.HasValue; } }
        public int BierId { get; set; }
        #endregion

        #region Constructors
        public Bier()
        {
            AlcoholPercentage = null;
        }

        public Bier(string naam): this()
        {
            this.Naam = naam;
        }
        #endregion
    }
}
