using System;

namespace Pasteleria
{
    class Cupon : FormaDePago
    {
        public override int TotalAPagar(double total)
        {
            return (int)total;
        }
    }
}
