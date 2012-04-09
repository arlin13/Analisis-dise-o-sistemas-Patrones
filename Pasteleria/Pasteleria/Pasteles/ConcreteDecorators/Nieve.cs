using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pasteleria.Pasteles.ConcreteDecorators
{
    class Nieve : PastelDecorator
    {
        public Nieve(Pastel pastel)
            : base(pastel)
        {
            Descripcion = "Nieve";
        }

        public override string ObtieneDescripcion()
        {
            return _pastel.ObtieneDescripcion() + " , " + Descripcion;
        }

        public override double CalculaPrecio()
        {
            return _pastel.CalculaPrecio() + 50.00;
        }
    }
}
