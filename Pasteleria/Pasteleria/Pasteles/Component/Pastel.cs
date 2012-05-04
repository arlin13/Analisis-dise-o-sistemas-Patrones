using System;

namespace Pasteleria
{
    public abstract class Pastel
    {
        public string Descripcion { get; set; }
        public Sabor Sabor { get; set; }
        public Forma Forma { get; set; }

        public abstract string ObtieneDescripcion();
        public abstract double CalculaPrecio();
    }

    public enum Sabor
    { 
        Chocolate,
        TresLeches,
        Vainilla
    }

    public enum Forma
    { 
        Circular,
        Cuadrado,
        Corazon
    }
}
