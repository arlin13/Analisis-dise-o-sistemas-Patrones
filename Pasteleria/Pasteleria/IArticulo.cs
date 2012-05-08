using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pasteleria
{
    interface IArticulo
    {
        string Descripcion { get; set; }
        Sabor Sabor { get; set; }
        string ObtieneDescripcion();
        double CalculaPrecio();
    }

    public enum Sabor
    {
        Chocolate,
        TresLeches,
        Vainilla
    }
}
