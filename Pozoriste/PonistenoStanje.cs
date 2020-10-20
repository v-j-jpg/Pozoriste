using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozoriste
{
    public class PonistenoStanje : StanjeKupovine
    {
        public override void Kupi(Kupovina p)
        {
            Console.WriteLine("Uspesno kupljeno");
            ChangeState(p, new KupljenoStanje());
        }

        public override void Ponisti(Kupovina p)
        {
            Console.WriteLine("Morate prvo da kupite da bi ste ponistili!");
          //  ChangeState(p, new PonistenoStanje());
        }
    }
}
