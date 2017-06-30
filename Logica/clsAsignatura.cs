using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;

namespace Logica
{
    class clsAsignatura
    {
        public string nombre { get; set; }
        public int seccion { get; set; }
        public int cantidadAlumnos { get; set; }
        public string ubicacion { get; set; }
        public string sede { get; set; }
        public int horas { get; set; }
        public int porcentajeAsistencia { get; set; }
        public int codigo { get; set; }
        public int docente { get; set; }

        // Constructor
        
        public clsAsignatura(string _nombre, int _seccion, int _cantidadAlumnos, string _ubicacion, string _sede, int _horas, int _porcentajeAsistencia, int _codigo, int _docente)
        {
            nombre = _nombre;
            seccion = _seccion;
            cantidadAlumnos = _cantidadAlumnos;
            ubicacion = _ubicacion;
            sede = _sede;
            horas = _horas;
            porcentajeAsistencia = _porcentajeAsistencia;
            codigo = _codigo;
            docente = _docente;
        }


    }
}
