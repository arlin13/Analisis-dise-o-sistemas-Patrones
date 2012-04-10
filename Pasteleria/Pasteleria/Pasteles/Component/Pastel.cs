using System;

namespace Pasteleria
{
    public abstract class Pastel
    {
        public string Descripcion { get; set; }
        public Sabor Sabor { get; set; }
        public Forma Forma { get; set; }

        //public Pastel(string descripcion, Sabor sabor, Forma forma)
        //{
        //    this.Descripcion = descripcion;
        //    this.Sabor = sabor;
        //    this.Forma = forma;
        //}

        public abstract string ObtieneDescripcion();
        public abstract double CalculaPrecio();
    }

    public enum Sabor
    { 
        Chocolate,
        TresLeches,
        Vainilla,
        Zanahoria
    }

    public enum Forma
    { 
        Circular,
        Rectangular
    }
}
