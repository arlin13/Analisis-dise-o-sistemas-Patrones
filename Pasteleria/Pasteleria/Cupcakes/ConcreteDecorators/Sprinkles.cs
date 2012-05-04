using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pasteleria
{
    class Sprinkles : CupcakeDecorator
    {
        public Sprinkles(Cupcake cupcake)
            : base(cupcake)
        {
            Descripcion = "Sprinkles. ";
        }

        public override string ObtieneDescripcion()
        {
            return _cupcake.ObtieneDescripcion() + Descripcion;
        }

        public override double CalculaPrecio()
        {
            return _cupcake.CalculaPrecio() + 3.00;
        }
    }
}
