using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_des_commerciaux
{
    internal class Servicecommercial
    {
        private string nomservice;
        private Commercial lecommercial;
        private List<Commercial> lescommerciaux = new List<Commercial>();
        

        public string Nomservice { get => nomservice; set => nomservice = value; }
        internal List<Commercial> Lescommerciaux { get => lescommerciaux; set => lescommerciaux = value; }
        internal Commercial Lecommercial { get => lecommercial; set => lecommercial = value; }

        public Servicecommercial(string noms, List<Commercial> Lescommerciaux )
        {
            nomservice = noms;
            
        }
    }
}
