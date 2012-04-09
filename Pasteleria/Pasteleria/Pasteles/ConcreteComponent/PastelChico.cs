using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pasteleria
{
    class PastelChico : Pastel
    {
        public PastelChico()
        {
            Descripcion = "Pastel chico";
        }
        public override string ObtieneDescripcion()
        {
            return Descripcion;
        }

        public override double CalculaPrecio()
        {
            return 100.00;
        }
    }
}
