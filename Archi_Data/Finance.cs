using System;
using System.Collections.Generic;
using System.Text;

namespace Archi_Data
{
    public class Finance:BaseEntity
    {
        public int Depense { get; set; }
        public int Actif { get; set; }
        public int Capital { get; set; }
        public DateTime DateF { get; set; }

    }
}
