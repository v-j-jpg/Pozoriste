﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Pozoriste
{
    class MjuziklStrategija : IStrategijaKapacitet
    {
        public int GetKapacitet(int kapacitet)
        {
            return kapacitet;
        }
    }
}
