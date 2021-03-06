using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Archi_Data;
using Archi_Repository;

namespace Archi_Service
{
    public class ProduitService
    {
        ProduitRepo prrepo = new ProduitRepo();
        public Produit [] GetAll()
        {
            return prrepo.GetAll();
        } 
        public Produit getById(int id)
        {
            List<Produit> produits = prrepo.GetAll().ToList();
            return produits.First(x => x.Id == id);
        }

        public int montant()
        {
            int mont = 0;
            List<Produit> produits = prrepo.GetAll().ToList();
            foreach(Produit p in produits)
            {
                mont += p.PrixUnitaire *p.QteStock;
            }
            return mont;
        }
    }
}
