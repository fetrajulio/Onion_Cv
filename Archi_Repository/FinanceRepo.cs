using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Archi_Data;
using MySql.Data.MySqlClient;

namespace Archi_Repository
{
    public class FinanceRepo
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=ArchiB_BD; User id=root; Password=;");
        public Finance[] GetAll()
        {
            List<Finance> finances = new List<Finance>();

            using (con)
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `finance`",con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Finance finance = new Finance();
                    finance.Id = int.Parse(reader["id"].ToString());
                    finance.Actif= int.Parse(reader["act"].ToString());
                    finance.Capital= int.Parse(reader["cap"].ToString());
                    finance.Depense= int.Parse(reader["dep"].ToString());
                    finance.DateF = Convert.ToDateTime(reader["date"]) ;

                    finances.Add(finance);

                }
                con.Close();
            }

            return finances.ToArray();
        }

        public void SetFinance()
        {
            AchatVenteRepo achatVenteRepo = new AchatVenteRepo();
            List<Vente> ventes = achatVenteRepo.GetAll().ToList();
            List<Finance> finances = this.GetAll().ToList();
            
            foreach(Vente v in ventes)
            {
                if(v.Date== DateTime.Today.AddDays(-1) && finances.Exists((x=>x.DateF== DateTime.Today.AddDays(-1) == false)))
                {
                    
                    int prix = +v.PrixTotal;
                    string DateF = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd HH:mm:ss.fff"); ;
                    con.Open();
                    string qr = "INSERT INTO `finance` (`dep`, `act`, `date`, `cap`, `id`) VALUES ('0', '"+prix+"', '"+DateF+"', '100000', NULL);";
                    MySqlCommand cmd = new MySqlCommand(qr, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    con.Close();
                }
            }
        }
    }
}
