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
        public void supp(int id)
        {
            string sql = "DELETE FROM `Produit` WHERE `Produit`.`id` = " + id;
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            con.Close();
        }
        public void mod(int id,string Nom,int qte,int prix)
        {
            string sql = "UPDATE `Produit` SET `Nom` = '"+Nom+"', `qte` = '"+qte+"', `prix` = '"+prix+"' WHERE `Produit`.`id` = "+id+";";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            con.Close();
        }
        public void ajout(string Nom,int qte,int prix)
        {
            string sql = "INSERT INTO `Produit` (`id`, `Nom`, `qte`, `prix`) VALUES (NULL, '"+Nom+"', '"+qte+"', '"+prix+"');";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            con.Close();
        }

        public void moinQt(int id,int x)
        {
            string sql = "SELECT * FROM `Produit` WHERE `Produit`.`id` =" + id + ";";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            Produit p = new Produit();
            while (reader.Read())
            {
                
                p.Id = Convert.ToInt32(reader["id"]);
                p.PrixUnitaire = Convert.ToInt32(reader["prix"]);
                p.QteStock = Convert.ToInt32(reader["qte"]);
                p.Nom = reader["Nom"].ToString();
                
            }
            con.Close();
            int nbr = p.QteStock-x;
            con.Open();
            string sql2 = "UPDATE `Produit` SET `qte` = '"+nbr+"' WHERE `Produit`.`id` = "+id+";";
            cmd = new MySqlCommand(sql2, con);
            MySqlDataReader reader2 = cmd.ExecuteReader();
            con.Close();
            
        }
    }
}
