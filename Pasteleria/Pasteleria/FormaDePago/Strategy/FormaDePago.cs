using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pasteleria//.FormaDePago.Strategy
{
    abstract class FormaDePago
    {
        public abstract int TotalAPagar(int total);
    }
}
