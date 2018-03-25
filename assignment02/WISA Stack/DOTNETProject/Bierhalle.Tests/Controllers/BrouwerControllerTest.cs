using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Bierhalle.Models.Domain;
using Bierhalle.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Bierhalle.Tests.Controllers
{
    [TestClass]
    public class BrouwerControllerTest
    {
        private BrouwerController controller;
        private Mock<IBrouwerRepository> mockBrouwerRepository;
        private Mock<IGemeenteRepository> mockGemeenteRepository;

        [TestInitialize]
        public void SetUpContext()
        {
            DummyDataContext context = new DummyDataContext(); ;
            mockBrouwerRepository = new Mock<IBrouwerRepository>();
            mockGemeenteRepository = new Mock<IGemeenteRepository>();
            mockBrouwerRepository.Setup(m => m.FindAll()).Returns(context.BrouwerLijst);
            controller = new BrouwerController(mockBrouwerRepository.Object, mockGemeenteRepository.Object);
        }

        ////[TestMethod]
        //public void GetBrouwersReturnsBrouwers()
        //{
        //    Brouwer[] brouwers = controller.GetBrouwers().ToArray();
        //    Assert.AreEqual(3, brouwers.Length);
        //    Assert.AreEqual(brouwers[0].Naam, "Bavik");
        //    Assert.AreEqual(brouwers[1].Naam, "De Leeuw");
        //    Assert.AreEqual(brouwers[2].Naam, "Duvel Moortgat");
        //}

     
        [TestMethod]
        public void IndexReturnsAllBrouwers()
        {
            //Act
            ViewResult result = controller.Index() as ViewResult;
            Brouwer[] brouwers = ((IEnumerable<Brouwer>)result.Model).ToArray();
            //Assert
            Assert.AreEqual(3,brouwers.Length);
            Assert.AreEqual(brouwers[0].Naam, "Bavik");
            Assert.AreEqual(brouwers[1].Naam, "De Leeuw");
            Assert.AreEqual(brouwers[2].Naam, "Duvel Moortgat");
            mockBrouwerRepository.Verify(m=>m.FindAll(), Times.Once);
        }

        [TestMethod]
        public void IndexReturnsTotaleOmzet()
        {
            ViewResult result = controller.Index() as ViewResult;
            Assert.AreEqual(20050000, result.ViewBag.TotaleOmzet);
            mockBrouwerRepository.Verify(m => m.FindAll(), Times.Once);
        }

    }
}


