using System;
using System.Collections.Generic;
using System.Text;

namespace Archi_Data
{
    public class Produit:BaseEntity
    {
        public string Nom { get; set; }
        public int QteStock { get; set; }
        public int PrixUnitaire { get; set; }
    }
}
