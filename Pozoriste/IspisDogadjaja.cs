using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozoriste
{
  public  class IspisDogadjaja
    {
       public int Ispis(int kapacitet,Pozoriste p)
        {

            Console.WriteLine($" {p.NazivPozorista} lista dogadjaja:");
            Console.WriteLine($"Kapacitet={kapacitet}");

            foreach (var item in p.listaDogadjaja)
            {
                Console.WriteLine($"{item}");

            }


            Console.WriteLine("\n\n (B)aletska predstava 2-(M)juzikl 3-(P)redstava \n \n Exit-Bilo koji taster");
            IStrategijaKapacitet ps;
            char c = Console.ReadKey().KeyChar;


            switch (c)
            {
                case 'B':
                    {

                        ps = new BaletStrategija();
                        kapacitet = ps.GetKapacitet(kapacitet);
                        break;

                    }

                case 'M': ps = new MjuziklStrategija(); kapacitet = ps.GetKapacitet(kapacitet); break;
                case 'P': ps = new PredstavaStrategija(); kapacitet = ps.GetKapacitet(kapacitet); break;

                default: Console.WriteLine("Los izbor"); break;
            }
            return kapacitet;
        }

    }
}
