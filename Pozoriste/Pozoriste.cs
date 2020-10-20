using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozoriste
{
  public  class Pozoriste
    {
      

        private string nazivPozorista;

        
        public string NazivPozorista
        {
            get { return nazivPozorista; }
            set { nazivPozorista = value; }
        }
        private int kapacitet;

        public int Kapacitet
        {
            get { return kapacitet; }
            set { kapacitet = value; }
        }

        public List<Dogadjaj> listaDogadjaja;

        public Pozoriste(string nazivPozorista, int kapacitet)
        {
            this.nazivPozorista = nazivPozorista;
            this.kapacitet = kapacitet;
            listaDogadjaja = new List<Dogadjaj>();
        }
    }
}
