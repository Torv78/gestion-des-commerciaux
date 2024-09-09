using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_des_commerciaux
{
    internal class Note
    {
        private int idnote;
        private DateTime datenote;
        private double montantnote;
        private string typenote;
        private bool remboursenote;
        private Commercial lecommercial ;

        public int Idnote { get => idnote; set => idnote = value; }
        public DateTime Date { get => datenote; set => datenote = value; }
        public double Montantnote { get => montantnote; set => montantnote = value; }
        public string Type { get => typenote; set => typenote = value; }
        public bool Rembourse { get => remboursenote; set => remboursenote = value; }
        internal Commercial Lecommercial { get => lecommercial; set => lecommercial = value; }

        public Note(int idn, DateTime daten, double montantn, string typen, bool remboursen)
        {
            idnote = idn;
            datenote = daten;
            montantnote = montantn;
            typenote = typen;
            remboursenote = remboursen;
     

        }

        public override string ToString()
        {
            string infofrais = "date dépense:"+datenote+"montant a rembourser"+montantnote+"type de note"+typenote+"nom"+Lecommercial.Nomcommerciaux+"prenom"+Lecommercial.Prenomcommerciaux

            {
               
            }
            return infofrais;
          
        }

    }
}
