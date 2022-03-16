using System;
using System.Collections.Generic;
using System.Text;
using Archi_Data;
using MySql.Data.MySqlClient;

namespace Archi_Repository
{
    public class AchatVenteRepo
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=ArchiB_BD; User id=root; Password=;");

        public void achat(int idcl,int idprod,int nbr, int prix) {
            
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string sql = "INSERT INTO `vente` (`id`, `idcl`, `idpr`, `date`, `valide`,`nbr`,`prixtotal`) VALUES(NULL, '" + idcl+"', '"+idprod+"', '"+ sqlFormattedDate + "', '0','"+nbr+"','"+prix+"')"; 
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            con.Close();
        }
        public Vente[] GetAll()
        {
            List<Vente> ventes = new List<Vente>();
            using (con)
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `vente`", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Vente v = new Vente();
                    v.Id= Convert.ToInt32(reader["id"]);
                    v.IdClient= Convert.ToInt32(reader["idcl"]);
                    v.IdProduit= Convert.ToInt32(reader["idpr"]);
                    v.Validation= Convert.ToInt32(reader["valide"]);
                    v.Nbr= Convert.ToInt32(reader["nbr"]);
                    v.PrixTotal= Convert.ToInt32(reader["prixtotal"]);
                    v.Date = Convert.ToDateTime(reader["date"]);
                    ventes.Add(v);
                }
                
                con.Close();
                return ventes.ToArray();
            }
        }
        public void accpteref(int id,int x)
        {
            string txt = "UPDATE `vente` SET `valide` = '"+x+"' WHERE `vente`.`id` = "+id+";";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(txt, con);
            MySqlDataReader read = cmd.ExecuteReader();
            con.Close();
        }
        
    }
}
