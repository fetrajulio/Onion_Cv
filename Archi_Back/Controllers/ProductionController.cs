using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Archi_Repository;
using Archi_Service;
using Microsoft.AspNetCore.Mvc;

namespace Archi_Back.Controllers
{
    public class ProductionController : Controller
    {
        ProduitRepo produitRepo = new ProduitRepo();
        ProduitService produitService = new ProduitService();
        public IActionResult Index()
        {
            ViewBag.produits = produitService.GetAll();
            return View();
        }

        public ActionResult modifier(int id)
        {
            ViewBag.Id = id;
            ViewBag.prod = produitService.getById(id);
            return View();
        }
        public ActionResult ValiderMod(int Id)
        {
            string Nom = Request.Form["Nom"];
            int qte= int.Parse(Request.Form["qte"]);
            int prix = int.Parse(Request.Form["prix"]);
            produitRepo.mod(Id, Nom, qte, prix);
            return Redirect("https://localhost:5001/Production");
        }
        public ActionResult Suprimer(int id)
        {
            produitRepo.supp(id);
            return Redirect("https://localhost:5001/Production");
        }
        public ActionResult ajout()
        {
            return View();
        }
        public ActionResult ValiderAjout()
        {
            string Nom = Request.Form["Nom"];
            int qte = int.Parse(Request.Form["qte"]);
            int prix = int.Parse(Request.Form["prix"]);
            produitRepo.ajout(Nom, qte, prix);
            return Redirect("https://localhost:5001/Production");
        }
    }
}