using System;

namespace Pasteleria
{
    public abstract class Cupcake : IArticulo
    {
        public string Descripcion { get; set; }
        public Sabor Sabor { get; set; }

        public abstract string ObtieneDescripcion();
        public abstract double CalculaPrecio();
    }

    //    public string Descripcion { get; set; }
    //    public SaborCupcake SaborCupcake { get; set; }

    //    public abstract string ObtieneDescripcion();
    //    public abstract double CalculaPrecio();
    //}

    //public enum SaborCupcake
    //{
    //    Chocolate,
    //    TresLeches,
    //    Vainilla
    //}

}
