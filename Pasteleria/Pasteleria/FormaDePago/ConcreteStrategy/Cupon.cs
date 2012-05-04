﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pasteleria//.FormaDePago.ConcreteStrategy
{
    class Cupon : FormaDePago
    {
        public override int TotalAPagar(double total)
        {
            return (int)total;
        }
    }
}
