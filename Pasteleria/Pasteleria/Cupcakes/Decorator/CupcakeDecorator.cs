using System;

namespace Pasteleria
{
    public class CupcakeDecorator : Cupcake
    {
        protected Cupcake _cupcake;

        public CupcakeDecorator(Cupcake cupcake)
        {
            _cupcake = cupcake;
        }

        public override string ObtieneDescripcion()
        {
            return _cupcake.Descripcion;
        }

        public override double CalculaPrecio()
        {
            return _cupcake.CalculaPrecio();
        }
    }

   
}
