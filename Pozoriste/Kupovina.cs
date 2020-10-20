using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozoriste
{
  public  class Kupovina
    {
       public  StanjeKupovine stanje;

     
        public Kupovina()
        {
           this.stanje = new KupljenoStanje();

        }
        public void Kupi()
        {
           
            this.stanje.Kupi(this);
           
        }
        public void Ponisti()
        {
            
            this.stanje.Ponisti(this);
        }

        public void ChangeState(StanjeKupovine state)
        {
            this.stanje = state;
        }
    }
}
