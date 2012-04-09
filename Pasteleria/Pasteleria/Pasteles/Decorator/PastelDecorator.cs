using System;

namespace Pasteleria
{
    public class PastelDecorator:Pastel
    {
        protected Pastel _pastel;

        public PastelDecorator(Pastel pastel)
        {
            _pastel = pastel;
        }

        public override string ObtieneDescripcion()
        {
            return _pastel.Descripcion;
        }

        public override double CalculaPrecio()
        {
            return _pastel.CalculaPrecio();
        }
    }
}
