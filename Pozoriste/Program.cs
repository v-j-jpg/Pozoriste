using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozoriste
{
    class Program
    {
     

        static void Main(string[] args)
        {





         InicijalizacijaPozorista ip=new InicijalizacijaPozorista();
            Pozoriste p = ip.Init();

          IspisDogadjaja isp = new IspisDogadjaja();
         int kapacitetPredstave=   isp.Ispis(p.Kapacitet, p);

            NapraviKupovinu nk=new NapraviKupovinu(kapacitetPredstave);
            nk.Napravi();
            Console.ReadKey();
                
            
        }
      
    
    }
}
