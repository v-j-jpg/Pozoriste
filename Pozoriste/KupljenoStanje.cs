using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozoriste
{
    public class KupljenoStanje : StanjeKupovine
    {
        public override void Kupi(Kupovina p)
        {
            Console.WriteLine("Uspesna kupovina!");
            ChangeState(p, new KupljenoStanje());
        }

        public override void Ponisti(Kupovina p)
        {
            Console.WriteLine("");
            ChangeState(p, new PonistenoStanje());
        }
    }
}
