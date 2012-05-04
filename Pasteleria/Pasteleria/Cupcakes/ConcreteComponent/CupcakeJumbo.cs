using System;

namespace Pasteleria
{
    class CupcakeJumbo : Cupcake
    {
        public CupcakeJumbo()
        {
            Descripcion = "Cupcake tamaño jumbo. ";
        }

        public override string ObtieneDescripcion()
        {
            return Descripcion;
        }

        public override double CalculaPrecio()
        {
            return 11.00;
        }
    }
}
