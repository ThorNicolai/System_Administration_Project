using System;
using System.Linq;
using Bierhalle.Models.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bierhalle.Tests.Models
{
    [TestClass]
    public class BrouwerTest
    {
        Brouwer bockor;

        [TestInitialize()]
        public void MyTestInitialize()
        {
            bockor = new Brouwer("Bockor");
            bockor.AddBier("Omer");
            bockor.AddBier("Bellegems Bruin");
        }
      
        [TestMethod]
        public void ConstructorMetParameterNaam()
        {
            Brouwer brouwer = new Brouwer("Rodenbach");
            Assert.AreEqual("Rodenbach", brouwer.Naam);
            Assert.IsNull(brouwer.Omzet);
            Assert.AreEqual(0, brouwer.AantalBieren);
            Assert.IsNull(brouwer.Gemeente);
            Assert.IsNull(brouwer.Straat);
            Assert.AreEqual(0, brouwer.BrouwerId);
        }

        [TestMethod]
        public void ConstructorMetParameterAdres()
        {
            Gemeente veurne = new Gemeente { Naam = "Veurne", Postcode = "8630" };
            Brouwer brouwer = new Brouwer("Bachten de Kupe", veurne, "Kerkstraat 20") { Omzet = 20000 };
            Assert.AreEqual("Bachten de Kupe", brouwer.Naam);
            Assert.AreEqual("Veurne", brouwer.Gemeente.Naam);
            Assert.AreEqual("Kerkstraat 20", brouwer.Straat);
            Assert.AreEqual(20000, brouwer.Omzet);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegatieveOmzetNietToegelaten()
        {
            Brouwer brouwer = new Brouwer("Rodenbach") { Omzet = -2000};
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LangeBrouwerNaamNietToegelaten()
        {
            Brouwer brouwer = new Brouwer(String.Empty.PadRight(51, '*'));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BrouwerNaamMagNietNullZijn()
        {
            Brouwer brouwer = new Brouwer(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BrouwerNaamMagNietLeeglZijn()
        {
            Brouwer brouwer = new Brouwer("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BrouwerNaamMagNietUitLegeKaraktersBestaan()
        {
            Brouwer brouwer = new Brouwer(" \t \n \r \t   ");
        }
        
        [TestMethod]
        public void AddBierVoegtNieuwBierToe()
        {
            int aantalVoor = bockor.AantalBieren;
            Bier hoGent = bockor.AddBier("HoGent bier", 55.0D);
            Assert.AreEqual(aantalVoor + 1, bockor.AantalBieren);
            Assert.AreEqual("HoGent bier", hoGent.Naam);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddBierVoegtBierMetZelfdeNaamAlsBestaandBierNietToe()
        {
            Bier omer = bockor.AddBier("Omer");
        }

        [TestMethod]
        public void DeleteBierVerwijdertBestaandBier()
        {
            int aantalVoor = bockor.AantalBieren;
            Bier eenBier = bockor.Bieren.First();
            bockor.DeleteBier(eenBier);
            Assert.AreEqual(aantalVoor - 1, bockor.AantalBieren);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteBierVanOnbestaandBierFaalt()
        {
            Bier eenBier = new Bier("Zomaar een bier");
            bockor.DeleteBier(eenBier);
        }
    }
}
