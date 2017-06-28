using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controlador
{
    public class BaseDatosException : ApplicationException
    {
        public BaseDatosException(string mensaje, Exception original)
            : base(mensaje, original)
        { }     

        public BaseDatosException(string mensaje)
            : base(mensaje)
        { }

    }
}
