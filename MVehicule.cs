using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoEcole
{
    public class MVehicule : MModele
    {
        private String vehiculeImmat;
        public String VehiculeImmat
        {
            get { return this.vehiculeImmat; }
            set { this.vehiculeImmat = value; }
        }
        public static List<MVehicule> Vehicules = new List<MVehicule>();
        public static List<String> Vehicules_ = new List<String>();
        public MVehicule(String unModele, String unVehiculeImmat) : base (unModele)
        {
            this.VehiculeImmat = unVehiculeImmat;
            Vehicules.Add(this);
            Vehicules_.Add(base.modele + " " + this.vehiculeImmat);
        }
    }
}
