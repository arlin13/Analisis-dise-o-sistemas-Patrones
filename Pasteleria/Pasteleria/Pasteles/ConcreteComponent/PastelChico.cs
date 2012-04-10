using System;

namespace Pasteleria
{
    class PastelChico : Pastel
    {
        public PastelChico()
        {
            Descripcion = "Pastel de media plancha";

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
