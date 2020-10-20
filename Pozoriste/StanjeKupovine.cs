using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozoriste
{
  public abstract class StanjeKupovine
    {
       

       public  abstract void Kupi(Kupovina p);
        public abstract void Ponisti(Kupovina p);

        public void ChangeState(Kupovina p, StanjeKupovine state)
        {
            p.ChangeState(state);
            Console.WriteLine("New state of account: {0}", state);
          
        }
    }
}
