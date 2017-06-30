using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;

namespace Logica
{
    class clsLibro
    {
        public int identificador { get; set; }
        public int rutDocente { get; set; }
        public int codigoAsignatura { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaTermino { get; set; }
        public string descripcionAsignatura { get; set; }
        public int porcentajeAsistencia { get; set; }
        public string sede { get; set; }
        public int cantidadAlumnos { get; set; }
        public ArrayList rutAlumnos = new ArrayList();
        public ArrayList nombreAlumnos = new ArrayList();
        public int horas { get; set; }


    }
}
