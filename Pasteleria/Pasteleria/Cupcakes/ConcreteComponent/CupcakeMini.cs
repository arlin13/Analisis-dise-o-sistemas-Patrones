using System;

namespace Pasteleria
{
    class CupcakeMini : Cupcake
    {
        public CupcakeMini()
        {
            Descripcion = "Cupcake tamaño mini. ";
        }

        public override string ObtieneDescripcion()
        {
            return Descripcion;
        }

        public override double CalculaPrecio()
        {
            return 7.00;
        }
    }
}
