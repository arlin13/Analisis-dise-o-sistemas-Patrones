using System;

namespace Pasteleria
{
    class PastelMediano : Pastel
    {
        public PastelMediano()
        {
            Descripcion = "Pastel de una plancha. ";
        }

        public override string ObtieneDescripcion()
        {
            return Descripcion;
        }

        public override double CalculaPrecio()
        {
            return 200.00;
        }
    }
}
