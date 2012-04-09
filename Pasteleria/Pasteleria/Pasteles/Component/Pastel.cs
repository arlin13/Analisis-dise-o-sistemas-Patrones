using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pasteleria
{
    public abstract class Pastel
    {
        public string Descripcion { get; set; }
        public abstract string ObtieneDescripcion();
        public abstract double CalculaPrecio();
    }
}
