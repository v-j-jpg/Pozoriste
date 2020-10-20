using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozoriste
{
    class PredstavaStrategija : IStrategijaKapacitet
    {
        public int GetKapacitet(int kapacitet)
        {
            int predstavaKapacitet = kapacitet - Int32.Parse((kapacitet * 0.2).ToString());

            if (kapacitet>predstavaKapacitet)
            {
                return predstavaKapacitet;
            }else
            {
                return 0;
            }
          
        }
    }
}
