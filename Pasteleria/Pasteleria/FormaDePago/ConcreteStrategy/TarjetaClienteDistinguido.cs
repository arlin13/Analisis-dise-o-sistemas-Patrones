using System;

namespace Pasteleria
{
    class TarjetaClienteDistinguido : FormaDePago
    {
        public override int TotalAPagar(double total)
        {
            return (int)total;
        }
    }
}
