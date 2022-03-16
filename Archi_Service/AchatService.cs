using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Archi_Data;
using Archi_Repository;

namespace Archi_Service
{

    public class AchatService
    {
        AchatVenteRepo achatVenteRepo = new AchatVenteRepo();
        public Vente[] GetAll()
        {
            return achatVenteRepo.GetAll();
        }
        public Vente GetBy(int idcl,int idprd,int nbr, int val) {
            
            List<Vente> vente1 = achatVenteRepo.GetAll().ToList().FindAll(x => x.IdClient == idcl);
            List<Vente> vente2 = vente1.FindAll(x => x.IdProduit == idprd);
            List<Vente> vent3 = vente2.FindAll(x => x.Nbr == nbr);
            List<Vente> vente4 = vent3.FindAll(x => x.Validation == val);
            return vente4.First();
        }

        public int montant()
        {
            int mont = 0;
            Vente []vente1 = achatVenteRepo.GetAll();
            foreach(Vente v in vente1)
            {
                mont += v.PrixTotal;
            }
            return mont;
        } 

        public int montantvendu()
        {
            int mont = 0;
            List<Vente> vente1 = achatVenteRepo.GetAll().ToList().FindAll(x=>x.Validation==1);
            foreach (Vente v in vente1)
            {
                mont += v.PrixTotal;
            }
            return mont;
        }

        public Vente[] getValidall()
        {
            return achatVenteRepo.GetAll().ToList().FindAll(x =>x.Validation==0).ToArray();
        }
        
    }
}
