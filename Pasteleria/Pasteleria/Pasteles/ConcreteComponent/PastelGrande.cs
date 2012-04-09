using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pasteleria
{
    class PastelGrande : Pastel
    {
        public PastelGrande()
        {
            Descripcion = "Pastel grande";
        }
        public override string ObtieneDescripcion()
        {
            return Descripcion;
        }

        public override double CalculaPrecio()
        {
            return 300.00;
        }
    }
}
