using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pasteleria//.FormaDePago.ConcreteStrategy
{
    class Efectivo : FormaDePago
    {
        public override int TotalAPagar(int total)
        {
            return 100;
        }   
    }
}
