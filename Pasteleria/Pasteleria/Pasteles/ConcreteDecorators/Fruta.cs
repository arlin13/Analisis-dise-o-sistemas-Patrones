using System;

namespace Pasteleria
{
    public class Fruta : PastelDecorator
    {
        public Fruta(Pastel pastel)
            : base(pastel)
        {
            Descripcion = "Fruta";
        }

        public override string ObtieneDescripcion()
        {
            return _pastel.ObtieneDescripcion() + " , " + Descripcion;
        }

        public override double CalculaPrecio()
        {
            if (_pastel is PastelChico)
                return _pastel.CalculaPrecio() + 40.00;
            else if (_pastel is PastelMediano)
                return _pastel.CalculaPrecio() + 50;
            else
                return _pastel.CalculaPrecio() + 60;
        }
    }
}
