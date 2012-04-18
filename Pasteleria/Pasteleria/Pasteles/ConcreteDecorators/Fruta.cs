using System;

namespace Pasteleria
{
    public class Fruta : PastelDecorator
    {
        public Fruta(Pastel pastel)
            : base(pastel)
        {
            Descripcion = "Fruta. ";
        }

        public override string ObtieneDescripcion()
        {
            return _pastel.ObtieneDescripcion() + Descripcion;
        }

        public override double CalculaPrecio()
        {
            return _pastel.CalculaPrecio() + 30.00;
        }
    }
}
