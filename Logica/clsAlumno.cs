using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;
using System.Data.Common;

namespace Logica
{
    class clsAlumno
    {
        public string nombre { get; set; }
        public int rut { get; set; }
        public int codigoAsistencia { get; set; }

        // Constructor
        public clsAlumno(string _nombre, int _rut, int _codigoAsistencia)
        {
            nombre = _nombre;
            rut = _rut;
            codigoAsistencia = _codigoAsistencia;
        }

        
    }
}
