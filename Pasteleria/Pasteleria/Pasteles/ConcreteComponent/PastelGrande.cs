using System;

namespace Pasteleria
{
    class PastelGrande : Pastel
    {
        public PastelGrande()
        {
            Descripcion = "Pastel de dos planchas. ";
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
