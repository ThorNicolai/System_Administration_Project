using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Bierhalle.Models.Domain;
using Bierhalle.Models.DAL;
using System.Data.Entity;
using Bierhalle.ViewModels;

namespace Bierhalle.Controllers
{
    public class BrouwerController : Controller
    {
        private IBrouwerRepository brouwerRepository;
        private IGemeenteRepository gemeenteRepository;

        public BrouwerController()
        {
            BierhalleContext context = new BierhalleContext();
            context.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            this.brouwerRepository = new BrouwerRepository(context);
            this.gemeenteRepository = new GemeenteRepository(context);
        }

        public BrouwerController(IBrouwerRepository brouwerRepository, IGemeenteRepository gemeenteRepository)
        {
            this.brouwerRepository = brouwerRepository;
            this.gemeenteRepository = gemeenteRepository;
        }


        public ActionResult Index()
        {
            IEnumerable<Brouwer> brouwers =
                brouwerRepository.FindAll().Include(b => b.Gemeente).Include(b => b.Bieren).OrderBy(b => b.Naam).ToList();
            ViewBag.TotaleOmzet = brouwers.Sum(b => b.Omzet);
            return View(brouwers);
        }

        public ActionResult Detail(int id)
        {
            Brouwer brouwer = brouwerRepository.FindBy(id);
            return View(brouwer);
        }

        public ActionResult Edit(int id)
        {
            Brouwer brouwer = brouwerRepository.FindBy(id);
            if (brouwer == null)
                return HttpNotFound();
            ViewBag.Gemeenten = GetGemeentenSelectList(brouwer);
            return View(new BrouwerViewModel(brouwer));
        }

        //[HttpPost]
        //public ActionResult Edit(int id, string naam, string straat, string postcode, int omzet)
        //{
        //    Brouwer brouwer = brouwerRepository.FindBy(id);
        //    if (brouwer == null)
        //        return HttpNotFound();
        //    brouwer.Naam = naam;
        //    brouwer.Straat = straat;
        //    brouwer.Gemeente = String.IsNullOrEmpty(postcode) ? null : gemeenteRepository.FindBy(postcode);
        //    brouwer.Omzet = omzet;
        //    brouwerRepository.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        [HttpPost]
        public ActionResult Edit(int id, BrouwerViewModel brouwerViewModel)
        {
            Brouwer brouwer = brouwerRepository.FindBy(id);
            //Foutafhandeling zie later Validatie
            MapToBrouwer(brouwerViewModel, brouwer);
            brouwerRepository.SaveChanges();
            TempData["message"] = $"Brouwer {brouwer.Naam} werd aangepast";
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            Brouwer brouwer = new Brouwer();
            ViewBag.Gemeenten = GetGemeentenSelectList(brouwer);
            return View("Edit", new BrouwerViewModel(brouwer));
        }

        [HttpPost]
        public ActionResult Create(BrouwerViewModel brouwerViewModel)
        {
            Brouwer brouwer = new Brouwer();
            //Voeg eerst brouwer toe aan context, zo worden de wijzigingen getracked
            brouwerRepository.Add(brouwer);
            MapToBrouwer(brouwerViewModel, brouwer);
            brouwerRepository.SaveChanges();
            TempData["message"] = $"Brouwer {brouwer.Naam} werd  gecreëerd";
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Brouwer brouwer = brouwerRepository.FindBy(id);
            if (brouwer == null)
                return HttpNotFound();
            return View(brouwer);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Brouwer brouwer = brouwerRepository.FindBy(id);
                if (brouwer == null)
                    return HttpNotFound();
                brouwerRepository.Delete(brouwer);
                brouwerRepository.SaveChanges();
                TempData["message"] = $"Brouwer {brouwer.Naam} werd verwijderd";
            }
            catch (Exception ex)
            {
                TempData["error"] = "Verwijderen brouwer mislukt. Probeer opnieuw. " +
                           "Als de problemen zich blijven voordoen, contacteer de  administrator.";
            }
            return RedirectToAction("Index");
        }

        private SelectList GetGemeentenSelectList(Brouwer brouwer)
        {
            return new SelectList(gemeenteRepository.FindAll().OrderBy(g => g.Naam),
                "Postcode", "Naam", brouwer.Gemeente == null ? "" : brouwer.Gemeente.Postcode);
        }

        private void MapToBrouwer(BrouwerViewModel brouwerViewModel, Brouwer brouwer)
        {
            brouwer.Naam = brouwerViewModel.Naam;
            brouwer.Straat = brouwerViewModel.Straat;
            if (String.IsNullOrEmpty(brouwerViewModel.Postcode))
                brouwer.Gemeente = null;
            else if (brouwer.Gemeente == null || brouwerViewModel.Postcode != brouwer.Gemeente.Postcode)
                brouwer.Gemeente = gemeenteRepository.FindBy(brouwerViewModel.Postcode);
            brouwer.Omzet = brouwerViewModel.Omzet;
        }

    }
}

