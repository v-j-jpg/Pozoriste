using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozoriste
{
   public class Dogadjaj
    {
        private string naziv;

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        private float cena;

        public float Cena
        {
            get { return cena; }
            set { cena = value; }
        }

   

        public override string ToString()
        {
            return $"{Naziv} : {cena}$";
        }

        public Dogadjaj(string naziv, float cena)
        {
            this.naziv = naziv;
            this.cena = cena;
        }
    }
}
