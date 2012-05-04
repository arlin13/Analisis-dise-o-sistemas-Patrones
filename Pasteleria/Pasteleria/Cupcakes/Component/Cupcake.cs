using System;

namespace Pasteleria
{
    public abstract class Cupcake
    {
        public string Descripcion { get; set; }
        public SaborCupcake SaborCupcake { get; set; }

        public abstract string ObtieneDescripcion();
        public abstract double CalculaPrecio();
    }

    public enum SaborCupcake
    {
        Chocolate,
        TresLeches,
        Vainilla
    }

}
