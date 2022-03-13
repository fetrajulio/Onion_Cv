using System;
using System.Collections.Generic;
using System.Text;
using Archi_Data;
using MySql.Data.MySqlClient;

namespace Archi_Repository
{
    public class ProduitRepo
    {
        private Produit[] produits;
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=ArchiB_BD; User id=root; Password=;");

        public Produit[] GetAll()
        {
            List<Produit> tmp = new List<Produit>();
            using (con)
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `Produit`", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Produit p = new Produit();
                    p.Id = Convert.ToInt32(reader["id"]);
                    p.PrixUnitaire = Convert.ToInt32(reader["prix"]);
                    p.QteStock = Convert.ToInt32(reader["qte"]);
                    p.Nom = reader["Nom"].ToString();
                    tmp.Add(p);
                }

                this.produits = tmp.ToArray();
                con.Close();
            }
            return this.produits;
        }
    }
}
