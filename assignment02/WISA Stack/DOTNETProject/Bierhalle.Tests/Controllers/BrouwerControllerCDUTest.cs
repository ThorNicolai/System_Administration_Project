using System;
using System.Linq;
using Bierhalle.Models.Domain;
using Bierhalle.Controllers;
using Bierhalle.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using Moq;

namespace Bierhalle.Tests.Controllers
{
    [TestClass]
    public class BrouwerControllerCDUTest
    {
        private Mock<IBrouwerRepository> mockBrouwerRepository;
        private Mock<IGemeenteRepository> mockGemeenteRepository;
        private BrouwerController controller;
        private DummyDataContext context;

        [TestInitialize]
        public void SetUpContext()
        {
            context = new DummyDataContext();

            mockBrouwerRepository = new Mock<IBrouwerRepository>();
            mockBrouwerRepository.Setup(m => m.FindAll()).Returns(context.BrouwerLijst);
            mockBrouwerRepository.Setup(m => m.FindBy(1)).Returns(context.Bavik);
            mockBrouwerRepository.Setup(m => m.FindBy(It.Is<int>(i => i > 3))).Returns((Brouwer)null);
            mockBrouwerRepository.Setup(m => m.FindBy(It.IsInRange<int>(4, int.MaxValue, Range.Inclusive)))
                .Returns((Brouwer)null);
            mockBrouwerRepository.Setup(m => m.Add(It.IsAny<Brouwer>()));
            mockBrouwerRepository.Setup(m => m.Delete(context.Bavik));
            mockBrouwerRepository.Setup(m => m.SaveChanges());


            mockGemeenteRepository = new Mock<IGemeenteRepository>();
            mockGemeenteRepository.Setup(m =>
                m.FindAll()).Returns(context.GemeenteLijst);
            mockGemeenteRepository.Setup(m => m.FindBy("3000")).Returns(
                        context.GemeenteLijst.SingleOrDefault(g => g.Postcode == "3000"));

            controller = new BrouwerController(mockBrouwerRepository.Object, mockGemeenteRepository.Object);
        }

        #region Edit Get
        [TestMethod]
        public void EditReturnsBrouwerViewModel()
        {
            ViewResult result = controller.Edit(1) as ViewResult;
            BrouwerViewModel brouwer = result.Model as BrouwerViewModel;
            Assert.AreEqual(context.Bavik.BrouwerId, brouwer.BrouwerId);
            Assert.AreEqual(context.Bavik.Naam, brouwer.Naam);
            mockBrouwerRepository.Verify(m=>m.FindBy(1), Times.Once);
        }

        [TestMethod]
        public void EditReturnsSelectListOfGemeentenAndSelectedValue()
        {
            ViewResult result = controller.Edit(1) as ViewResult;
            SelectListItem[] gemeenten = (result.ViewBag.Gemeenten as SelectList).ToArray();
            Assert.AreEqual(3, gemeenten.Length);
            Assert.AreEqual("Bavikhove", gemeenten[0].Text);
            Assert.AreEqual("8531", gemeenten[0].Value);
            Assert.AreEqual("8531", (result.ViewBag.Gemeenten as SelectList).SelectedValue);
            mockGemeenteRepository.Verify(m=>m.FindAll(), Times.Once);
        }

        [TestMethod]
        public void EditOfNonexistingBrouwer()
        {
            ActionResult result = controller.Edit(20);
            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));
        }
        #endregion

        #region Edit Post
        [TestMethod]
        public void EditReturnsToIndexWhenUpdateSuccessfull()
        {
            BrouwerViewModel brouwerVm = new BrouwerViewModel(context.Bavik);
            brouwerVm.Straat = "nieuwe straat 1";
            RedirectToRouteResult result = controller.Edit(1, brouwerVm) as RedirectToRouteResult;
            Assert.AreEqual("Index", result.RouteValues["action"]);
        }

        [TestMethod]
        public void EditChangesBrouwer()
        {
            BrouwerViewModel brouwerVm = new BrouwerViewModel(context.Bavik);
            brouwerVm.Straat = "nieuwe straat 1";
            ViewResult result = controller.Edit(1, brouwerVm) as ViewResult;
            Brouwer bavik = context.Bavik;
            Assert.AreEqual("Bavik", bavik.Naam);
            Assert.AreEqual("nieuwe straat 1", bavik.Straat);
            mockBrouwerRepository.Verify(m => m.SaveChanges(), Times.Once());
        }
        #endregion

        #region Create Get
        [TestMethod]
        public void CreateReturnsNewBrouwerViewModel()
        {
            ViewResult result = controller.Create() as ViewResult;
            BrouwerViewModel brouwerVm = result.Model as BrouwerViewModel;
            Assert.AreEqual(0, brouwerVm.BrouwerId);
            Assert.AreEqual(null, brouwerVm.Naam);
        }

        [TestMethod]
        public void CreateReturnsSelectListOfGemeenten()
        {
            ViewResult result = controller.Create() as ViewResult;
            SelectListItem[] gemeenten =
                (result.ViewBag.Gemeenten as SelectList).ToArray();
            Assert.AreEqual(3, gemeenten.Length);
            Assert.AreEqual("Bavikhove", gemeenten[0].Text);
            Assert.AreEqual("8531", gemeenten[0].Value);
            mockGemeenteRepository.Verify(m => m.FindAll(), Times.Once);
        }
        #endregion

        #region HttpPost create
        [TestMethod]
        public void CreatePostReturnsToIndexWhenUpdateSuccessfull()
        {
            BrouwerViewModel jan =
                new BrouwerViewModel(new Brouwer("Jan")
                {
                    Gemeente = context.GemeenteLijst.Last(),
                    Omzet = 2000
                });
            RedirectToRouteResult result = controller.Create(jan) as RedirectToRouteResult;
            Assert.AreEqual("Index", result.RouteValues["action"]);
        }

        [TestMethod]
        public void CreatePostAddsBrouwer()
        {
            Brouwer newBrouwer = new Brouwer("Jan")
            {
                Gemeente = context.GemeenteLijst.Last(),
                Straat = "TestStraat 10 ",
                Omzet = 2000
            };
            controller.Create(new BrouwerViewModel(newBrouwer));
            mockBrouwerRepository.Verify(m => m.Add(It.IsAny<Brouwer>()), Times.Once());
            mockBrouwerRepository.Verify(m => m.SaveChanges(), Times.Once());
        }
        #endregion
        
     
        #region Delete
        [TestMethod]
        public void DeleteReturnsBrouwer()
        {
            ViewResult result = controller.Delete(1) as ViewResult;
            Assert.AreEqual(context.Bavik.Naam, (result.Model as Brouwer).Naam);
        }

        [TestMethod]
        public void DeleteOfNonexistingBrouwer()
        {
            ActionResult result = controller.Delete(20);
            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));
        }
        #endregion

        #region Delete Post
        [TestMethod]
        public void DeletePostReturnsToIndexWhenDeleteSuccessfull()
        {
            RedirectToRouteResult result = controller.DeleteConfirmed(1) as RedirectToRouteResult;
            Assert.AreEqual("Index", result.RouteValues["action"]);
        }

        [TestMethod]
        public void DeleteRemovesBrouwer()
        {
            Brouwer brouwer = context.Bavik;
            mockBrouwerRepository.Setup(m => m.Delete(brouwer));
            controller.DeleteConfirmed(1);
            mockBrouwerRepository.Verify(m => m.Delete(brouwer), Times.Once());
            mockBrouwerRepository.Verify(m => m.SaveChanges(), Times.Once());
        }
        #endregion

    }
}
