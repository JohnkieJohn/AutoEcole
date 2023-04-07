using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoEcole
{
    public class MModele
    {
        protected String? modele;
        public String? Modele
        {
            get { return this.modele; }
            set { this.modele = value; }
        }
        public static List<MModele> Modeles = new List<MModele>();
        public static List<String> Modeles_ = new List<String>();

        public MModele(String unModele)
        {
            this.Modele = unModele;
            if(unModele != null)
            {
                Modeles.Add(this);
                Modeles_.Add(this.modele);
            } 
        }
    }
}
