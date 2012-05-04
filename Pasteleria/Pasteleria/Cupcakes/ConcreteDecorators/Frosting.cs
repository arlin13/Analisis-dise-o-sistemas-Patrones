using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pasteleria
{
    class Frosting : CupcakeDecorator
    {
        public Frosting(Cupcake cupcake)
            :base(cupcake)
        {
            Descripcion = "Frosting. ";
        }

        public override string ObtieneDescripcion()
        {
            return _cupcake.ObtieneDescripcion() + Descripcion;
        }

        public override double CalculaPrecio()
        {
            return _cupcake.CalculaPrecio() + 1.00;
        }
    }
}
