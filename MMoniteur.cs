using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoEcole
{
    public class MMoniteur
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
        public static List<MMoniteur> Moniteurs = new List<MMoniteur>();
        public static List<String> Moniteurs_ = new List<String>();
        public MMoniteur(string unNom, string unPrenom)
        {
            this.Nom = unNom;
            this.Prenom = unPrenom;
            Moniteurs.Add(this);
            Moniteurs_.Add(this.nom + " " + this.prenom);
        }

    }
}
