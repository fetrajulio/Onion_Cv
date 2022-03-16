using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Archi_Data;
using Archi_Repository;
using Archi_Service;
using Microsoft.AspNetCore.Mvc;

namespace Archi_Back.Controllers
{
    public class DgController : Controller
    {
        ProduitService produitService = new ProduitService();
        AchatService achatService = new AchatService();
        
        public IActionResult Index()
        {

            Vente[] ventes = achatService.getValidall();
            ViewBag.mont = produitService.montant();
            ViewBag.montvend = achatService.montantvendu();
            ViewBag.tot = produitService.montant() + achatService.montantvendu();
            ViewBag.ventes = ventes;
            return View();
        }

        public IActionResult accpt(int id,int x)
        {
            AchatVenteRepo achatVenteRepo = new AchatVenteRepo();
            achatVenteRepo.accpteref(id, 1);
            
            return Redirect("Index");
        }

        public IActionResult dcl(int id)
        {
            AchatVenteRepo achatVenteRepo = new AchatVenteRepo();
            achatVenteRepo.accpteref(id, 2);

            return Redirect("Index");
        }
    }
}