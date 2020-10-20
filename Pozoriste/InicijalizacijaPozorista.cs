using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozoriste
{
  public  class InicijalizacijaPozorista
    {
         Random random = new Random();

        public Pozoriste Init()
        {
            Pozoriste p = new Pozoriste("Narodno Pozoriste", 10);

            Dogadjaj dogadjaj;


            for (int i = 0; i <= 3; i++)
            {
                if (i % 2 == 0)
                {
                    dogadjaj = new Dogadjaj($"Predstava ", random.Next(1000));
                }
                else if (i % 3 == 0)
                {
                    dogadjaj = new Dogadjaj($"Balet ", random.Next(1000));
                }
                else
                {
                    dogadjaj = new Dogadjaj($"Mjuzikl ", random.Next(1000));
                }
                p.listaDogadjaja.Add(dogadjaj);



            }
            return p;
        

         
        }
        DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }



    }
 
}
