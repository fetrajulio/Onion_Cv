using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Archi_Data;
using Archi_Repository;
using MySql.Data.MySqlClient;

namespace Archi_Service
{
    public class FinanceService
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=ArchiB_BD; User id=root; Password=;");
        FinanceRepo FinanceRepo = new FinanceRepo();
        public void SetFinance()
        {
            AchatVenteRepo achatVenteRepo = new AchatVenteRepo();
            List<Vente> ventes = achatVenteRepo.GetAll().ToList();
            List<Finance> finances = FinanceRepo.GetAll().ToList();

            foreach (Vente v in ventes)
            {
                if (v.Date == DateTime.Today.AddDays(-1) && finances.Exists((x => x.DateF == DateTime.Today.AddDays(-1))))
                {

                    int prix = +v.PrixTotal;
                    string DateF = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd HH:mm:ss.fff"); ;
                    con.Open();
                    string qr = "INSERT INTO `finance` (`dep`, `act`, `date`, `cap`, `id`) VALUES ('0', '" + prix + "', '" + DateF + "', '100000', NULL);";
                    MySqlCommand cmd = new MySqlCommand(qr, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    con.Close();
                }
            }
        }
    }
}
