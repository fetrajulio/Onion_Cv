using System;
using System.Collections.Generic;
using System.Text;
using Archi_Data;
using MySql.Data.MySqlClient;

namespace Archi_Repository
{
    public class ClientRepo
    {
        private Client[] clients;
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=ArchiB_BD; User id=root; Password=;");

        public void Inscr(string nom,string email,string mdp,string tel)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `Client` (`Id`, `Nom`, `Tel`, `Utilisateur`, `Mdp`)" +
                " VALUES (NULL, '"+nom+"', '"+tel+"', '"+email+"', '"+mdp+"');", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            con.Close();
        }

        public Client[] GetAll()
        {
            List<Client> tmp = new List<Client>();
            using (con)
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `Client`", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Client cl = new Client();
                    cl.Id = Convert.ToInt32(reader["Id"]);
                    cl.Mdp = reader["Mdp"].ToString();
                    cl.Nom = reader["Nom"].ToString();
                    cl.Tel = reader["Tel"].ToString();
                    cl.Utilisateur = reader["Utilisateur"].ToString();

                    tmp.Add(cl);
                }
                con.Close();
            }
            this.clients = tmp.ToArray();
            return this.clients;
        }

        
        
    }
}
