using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoEcole
{
    public class MLecon
    {
        private DateTime dateDebut;
        public DateTime DateDebut
        {
            get { return this.dateDebut; }
            set { this.dateDebut = value; }
        }
        private DateTime dateFin;
        public DateTime DateFin
        {
            get { return this.dateFin; }
            set { this.dateFin = value; }
        }
        static List<MLecon> Lecons = new List<MLecon>();
        public MLecon(DateTime uneDateDebut, DateTime uneDateFin, MEleve unEleve, MMoniteur unMoniteur, MModele unModele, MVehicule unVehicule)
        {
            this.DateDebut = uneDateDebut;
            this.DateFin = uneDateFin;
            Lecons.Add(this);
        }
    }
}
