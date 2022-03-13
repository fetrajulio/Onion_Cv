using System;
using System.Collections.Generic;
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
    }
}
