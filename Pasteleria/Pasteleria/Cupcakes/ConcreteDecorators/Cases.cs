using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pasteleria
{
    class Cases : CupcakeDecorator
    {
        public Cases(Cupcake cupcake)
            : base(cupcake)
        {
            Descripcion = "Cases. ";
        }

        public override string ObtieneDescripcion()
        {
            return _cupcake.ObtieneDescripcion() + Descripcion;
        }

        public override double CalculaPrecio()
        {
            return _cupcake.CalculaPrecio() + 2.00;
        }
    }
}
