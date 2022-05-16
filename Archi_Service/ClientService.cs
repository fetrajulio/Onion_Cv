using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Archi_Data;
using Archi_Repository;

namespace Archi_Service
{
    public class ClientService
    {
        ClientRepo clrp = new ClientRepo();
        ProduitRepo produitRepo = new ProduitRepo();
        public Client[] GetAll()
        {
            return clrp.GetAll();
        }
        public Client GetClientById(int Id)
        {
            List<Client> clients = clrp.GetAll().ToList();
            Client client = clients.Find(x => x.Id == Id);
            return client;
        }
        public bool AuthLogin(string util, string mdp){
            List<Client> cls = clrp.GetAll().ToList();
            
            bool test = cls.Exists(x => x.Mdp == mdp && x.Utilisateur == util);
            if (test)
            {
                
                return true;
            }
            return false;
        }
        public Client GetClientByUserMdp(string user,string mdp)
        {
            List<Client> cls = clrp.GetAll().ToList();
            return cls.First(x => x.Mdp == mdp && x.Utilisateur == user);
        }
        public Client GetClientByUser(string user)
        {
            List<Client> cls = clrp.GetAll().ToList();
            return cls.First(x => x.Utilisateur == user);
        }
        public string getNomClient(int id)
        {
            List<Client> clients = clrp.GetAll().ToList();
            Client client = clients.Find(x => x.Id == id);
            return client.Nom;
        }
        public string getNomProduit(int id)
        {
            List<Produit> prds = produitRepo.GetAll().ToList();
            Produit p = prds.Find(x => x.Id == id);
            return p.Nom;
        }

    }
}
