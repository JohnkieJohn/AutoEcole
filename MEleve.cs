using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoEcole
{
    public class MEleve
    {
        private String nom;
        public String Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }
        private string prenom;
        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }

        public MEleve(string unnNom, string unPrenom)
        {
            this.Nom = unnNom;
            this.Prenom = unPrenom;
            Eleves.Add(this);
            Eleves_.Add(this.nom + " " + this.prenom);
        }

        public static List<MEleve> Eleves = new List<MEleve>();
        public static List<String> Eleves_ = new List<String>();

    }
}
