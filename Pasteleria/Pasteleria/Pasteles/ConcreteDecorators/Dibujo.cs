using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pasteleria
{
    class Dibujo : PastelDecorator
    {
        public Dibujo(Pastel pastel)
            : base(pastel)
        {
            Descripcion = "Dibujo personalizado";
        }

        public override string ObtieneDescripcion()
        {
            return _pastel.ObtieneDescripcion() + " , " + Descripcion;
        }

        public override double CalculaPrecio()
        {
            return _pastel.CalculaPrecio() + 150.00;
        }
    }
}
