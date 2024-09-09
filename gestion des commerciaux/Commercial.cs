using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_des_commerciaux
{
    internal class Commercial
    {
        private int idcommercial;
        private string nomcommercial;
        private string prenomcommercial;
        private int categoriecommercial;
        private int puissancecommercial;
        private List<Note> lesnotes = new List<Note>();
        private Servicecommercial leService;

        public int Idcommerciaux { get => idcommercial; set => idcommercial = value; }
        public string Nomcommerciaux { get => nomcommercial; set => nomcommercial = value; }
        public string Prenomcommerciaux { get => prenomcommercial; set => prenomcommercial = value; }
        public int Categoriecommerciaux { get => categoriecommercial; set => categoriecommercial = value; }
        public int Puissancecommerciaux { get => puissancecommercial; set => puissancecommercial = value; }
        internal List<Note> Lesnotes { get => lesnotes; set => lesnotes = value; }
        internal Servicecommercial LeService { get => leService; set => leService = value; }

        public Commercial(int idc, string nomc, string prenomc, int categoriec, int puissancec)
        {
            idcommercial = idc;
            nomcommercial = nomc;
            prenomcommercial = prenomc;
            categoriecommercial = categoriec;
            puissancecommercial = puissancec;
        }

        public void ajouterNotesfrais(Note f)
        {
            lesnotes.Add(f);
        }
        public override string ToString()
        {
           string info=" identifiant: " + idcommercial + " nom: " + nomcommercial + " prenom: " + prenomcommercial + " categorie: "
         + categoriecommercial + " puissance: " + puissancecommercial + " note: " + lesnotes;
            foreach (Note note in Lesnotes) {
                info += note.ToString();
            }
            return info;
        }

        public double cumulnotesrembourseesparanne(int annee)
        {
            double cumul = 0;
            foreach (Note note in lesnotes) {
                if (note.Date.Year == annee)
                {
                    if (note.Rembourse == true)
                    {
                        cumul += note.Montantnote;
                    }
                }

            }
            return cumul;
        }
    } }
