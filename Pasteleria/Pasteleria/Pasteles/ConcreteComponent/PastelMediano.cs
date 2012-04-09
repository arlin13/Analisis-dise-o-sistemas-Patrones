using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pasteleria
{
    class PastelMediano : Pastel
    {
        public PastelMediano()
        {
            Descripcion = "Pastel mediano";
        }
        public override string ObtieneDescripcion()
        {
            return Descripcion;
        }

        public override double CalculaPrecio()
        {
            return 200.00;
        }
    }
}
