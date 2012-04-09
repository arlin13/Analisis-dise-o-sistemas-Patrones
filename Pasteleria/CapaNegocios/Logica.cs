using System;
using System.Collections.Generic;
using CapaDatos;
using CapaComunes;

namespace CapaNegocios
{
    class Logica
    {
        BaseDatos bd = new BaseDatos();

        public Logica()
        { 
        }

        //public void CapturarPersona(Persona p)
        //{
        //    bd.CapturarPersona(p);
        //}

        //public Persona ObtenerPersona(int p)
        //{
        //    Persona obj = bd.ObtenerPersona(p);
        //    obj.Nombre = obj.Nombre.ToUpper();
        //    return obj;
        //}

        //public List<Persona> ObtenerPersonas()
        //{
        //    return bd.ObtenerPersonas();
        //}

    }
}
