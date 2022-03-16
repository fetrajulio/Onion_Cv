using System;
using System.Collections.Generic;
using System.Text;

namespace Archi_Data
{
    public class Vente:BaseEntity
    {
        public int IdClient { get; set; }
        public int IdProduit { get; set; }
        public int Validation { get; set; }

        public int Nbr { get; set; }
        public int PrixTotal { get; set; }

        public DateTime Date { get; set; }

    }
}
