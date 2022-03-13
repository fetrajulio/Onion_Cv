using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Archi_Data;
using Archi_Service;
using Microsoft.AspNetCore.Mvc;

namespace Archi_Back.Controllers
{
    public class ClientController : Controller
    {
        ClientService clientService = new ClientService();
        ProduitService produitService = new ProduitService();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Izy(string user)
        {
            Client client = clientService.GetClientByUser(user);
            Produit[] produits = produitService.GetAll();
            ViewBag.produits = produits;
            ViewBag.client = client;
            return View("Index");
        }
    }
}