using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Archi_Back.Models;
using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;
using Archi_Data;
using Archi_Repository;
using Archi_Service;

namespace Archi_Back.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ClientService ClientService = new ClientService();
        ProduitService produitService = new ProduitService();
        public ActionResult Login()
        {
            string util = Request.Form["Utilisateur"];
            string mdp = Request.Form["Mdp"];

            if (ClientService.AuthLogin(util, mdp))
            {
                
                return Redirect("https://localhost:5001/client/izy?user="+util);
            }
                

            return Redirect("https://localhost:5001/home"); ;

        }
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            ViewBag.produits = produitService.GetAll();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
