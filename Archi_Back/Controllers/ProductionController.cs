using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Archi_Service;
using Microsoft.AspNetCore.Mvc;

namespace Archi_Back.Controllers
{
    public class ProductionController : Controller
    {
        ProduitService produitService = new ProduitService();
        public IActionResult Index()
        {
            ViewBag.produits = produitService.GetAll();
            return View();
        }
    }
}