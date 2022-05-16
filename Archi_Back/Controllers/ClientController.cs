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
    public class ClientController : Controller
    {
        ClientService clientService = new ClientService();
        ProduitService produitService = new ProduitService();
        AchatVenteRepo achatVenteRepo = new AchatVenteRepo();
        AchatService achatService = new AchatService();
        ClientRepo CR = new ClientRepo();
        
        public Produit paner=new Produit();
        public IActionResult Index()
        {
            return View();
        }
        public  IActionResult Izy(string user)
        {
            Client client = clientService.GetClientByUser(user);
            Produit[] produits = produitService.GetAll();
            ViewBag.nbr = 0;
            ViewBag.panier = this.paner;
            ViewBag.produits = produits;
            ViewBag.client = client;
            return View("Index");
        }

        public IActionResult Acheter(string user,int idProd)
        {
            Client client = clientService.GetClientByUser(user);
            Produit[] produits = produitService.GetAll();
            this.paner=produitService.getById(idProd);
            ViewBag.nbr = 0;
            ViewBag.panier = this.paner;
            ViewBag.produits = produits;
            ViewBag.client = client;
            return View("Index");

        }
        public IActionResult valAchat(int idprod,int idclient)
        {
            int nbr= int.Parse(Request.Form["nbr"]);
            Produit p = produitService.getById(idprod);
            achatVenteRepo.achat(idclient, idprod, nbr,p.PrixUnitaire*nbr);
            ViewBag.achat=achatService.GetBy(idclient, idprod, nbr, 0);
            return View("Facturation");
        }

        public IActionResult validerInsc()
        {
            string nom= Request.Form["Nom"];
            string email = Request.Form["Email"];
            string tel = Request.Form["Tel"];
            string mdp= Request.Form["Mdp"];
            CR.Inscr(nom, email, mdp, tel);
            return Redirect("https://localhost:5001/home");
        }
    }
}