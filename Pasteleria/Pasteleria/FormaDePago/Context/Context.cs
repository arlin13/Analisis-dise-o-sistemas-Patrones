﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pasteleria
{
    class Context
    {
        private FormaDePago _formaDePago;

        public Context(FormaDePago formaDePago)
        {
            this._formaDePago = formaDePago;
        }

        public int ContextInterface(double total, double descuento)
        {
            return _formaDePago.TotalAPagar(total - (total * descuento));
        }

    }
}
