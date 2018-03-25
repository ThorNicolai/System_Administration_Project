using Bierhalle.Models.Domain;

namespace Bierhalle.ViewModels
{
    public class BrouwerViewModel
    {
        public int BrouwerId { get; set; }
        public string Naam { get; set; }
       public string Straat { get; set; }      
        public string Postcode { get; set; }
        public int? Omzet { get; set; }
        public BrouwerViewModel()
        {

        }
       public BrouwerViewModel(Brouwer brouwer)
        {
            this.BrouwerId = brouwer.BrouwerId;
            this.Naam = brouwer.Naam;
            this.Straat = brouwer.Straat;
            this.Postcode = brouwer.Gemeente == null ? "" : brouwer.Gemeente.Postcode;
            this.Omzet = brouwer.Omzet;
        }
    }
}