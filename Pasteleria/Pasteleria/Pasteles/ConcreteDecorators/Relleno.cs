using System;

namespace Pasteleria
{
    class Relleno : PastelDecorator
    {
        public Relleno(Pastel pastel)
            : base(pastel)
        {
            Descripcion = "Relleno. ";
        }

        public override string ObtieneDescripcion()
        {
            return _pastel.ObtieneDescripcion() + Descripcion;
        }

        public override double CalculaPrecio()
        {
            return _pastel.CalculaPrecio() + 40.00;
        }
    }
}
