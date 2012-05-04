using System;

namespace Pasteleria
{
    class CupcakeMediano : Cupcake
    {
        public CupcakeMediano()
        {
            Descripcion = "Cupcake tamaño mediano. ";
        }

        public override string ObtieneDescripcion()
        {
            return Descripcion;
        }

        public override double CalculaPrecio()
        {
            return 9.00;
        }
    }
}
