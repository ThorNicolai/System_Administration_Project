using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Bierhalle.Models.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bierhalle.Models;

namespace Bierhalle.Tests.Models
{
    [TestClass]
    public class BierTest
    {
        //
        // Testen voor Bier klasse
        //
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BierNaamMagNietNullZijn()
        {
            Bier bier = new Bier(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BierNaamMagNietLeegZijn()
        {
            Bier bier = new Bier("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BierNaamMagNietUitLegeKarakterBestaan()
        {
            Bier bier = new Bier(" \t  \n \r  ");
        }

        [TestMethod]
        public void AlcoholGekendIsTrueAlsPercentageGekend()
        {
            double percentage = 8.5D;
            Bier bier = new Bier("Nieuw bier") { AlcoholPercentage = percentage };
            Assert.IsNotNull(bier.AlcoholPercentage);
            Assert.AreEqual(percentage, bier.AlcoholPercentage);
            Assert.IsTrue(bier.AlcoholGekend);
        }

        [TestMethod]
        public void AlcoholGekendIsFalseAlsPercentageNietGekend()
        {
            Bier bier = new Bier("Nieuw bier");
            Assert.IsFalse(bier.AlcoholGekend);
        }
    }

       
}
