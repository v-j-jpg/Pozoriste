using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozoriste
{
    class BaletStrategija : IStrategijaKapacitet
    {
        public int GetKapacitet(int kapacitet)
        {
            return kapacitet - Int32.Parse((kapacitet * 0.3).ToString());
        }
    }
}
