using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozoriste
{
  public  class NapraviKupovinu
    {
        int kapacitet;
    
        
        public NapraviKupovinu(int k)
        {
             kapacitet=k;
        }
      public  void Napravi()
        {
            while (true)
            {
                Console.WriteLine($"Kapacitet predstave {kapacitet} mesta\n ");

                ConsoleKeyInfo key;

                do
                {
                

                    Console.WriteLine("Choose option: (B)uy ticket, (C)ancel or proceed with (P)revious step");
                    key = Console.ReadKey();
                    Console.WriteLine();


                } while (key.Key != ConsoleKey.B
                && key.Key != ConsoleKey.P
                && key.Key != ConsoleKey.C);
                Kupovina k = new Kupovina();
                

                switch (key.Key)
                {
                

                    case ConsoleKey.B:

                        if (kapacitet!=0)
                        {
                            k.Kupi();
                            kapacitet--;
                           
                        }
                        break;

                    case ConsoleKey.P:

                      
                            k.Ponisti();
                            kapacitet++;

                        
                      
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine("Buying ticket  is canceled");
                            
                        return;
                    default:
                        throw new NotSupportedException();
                }
            }
        }
    }
}
