using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;

namespace Logica
{
    public class clsLibro
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
        public int horas { get; set; }

        // Constructores

        public clsLibro(int _identificador, int _rutDocente, int _codigoAsignatura, DateTime _fechaInicio, DateTime _fechaTermino, 
                        string _descripcionAsignatura, int _porcentajeAsistencia, string _sede, int _cantidadAlumnos, ArrayList _rutAlumnos, int _horas)
        {
            identificador = _identificador;
            rutDocente = _rutDocente;
            codigoAsignatura = _codigoAsignatura;
            fechaInicio = _fechaInicio;
            fechaTermino = _fechaTermino;
            descripcionAsignatura = _descripcionAsignatura;
            porcentajeAsistencia = _porcentajeAsistencia;
            sede = _sede;
            cantidadAlumnos = _cantidadAlumnos;
            rutAlumnos = _rutAlumnos;
            horas = _horas;
        }

        // GeneraLibro

        public static void NuevoLibro(clsLibro nuevoLibro)
        {
            BaseDatos bd = new BaseDatos();
            try
            {
                string SQL = "insert into tbo_libro values (@rutDocente, @codigoAsignatura,@fechainicio,@fechatermino,@descripcion,@porcentajeAsistencia,@sede,@cantidadAlumnos,@horas)";
                bd.conectar();
                bd.comenzarTransaccion();
                bd.crearComando(SQL);
                bd.asignarParametroEntero("@rutDocente", nuevoLibro.rutDocente);
                bd.asignarParametroEntero("@codigoAsignatura", nuevoLibro.codigoAsignatura);
                bd.asignarParametroFecha("@fechainicio", nuevoLibro.fechaInicio);
                bd.asignarParametroFecha("@fechatermino", nuevoLibro.fechaTermino);
                bd.asignarParametroCadena("@descripcion", nuevoLibro.descripcionAsignatura);
                bd.asignarParametroEntero("@porcentajeAsistencia", nuevoLibro.porcentajeAsistencia);
                bd.asignarParametroCadena("@sede", nuevoLibro.sede);
                bd.asignarParametroEntero("@cantidadAlumnos", nuevoLibro.cantidadAlumnos);
                bd.asignarParametroEntero("@horas", nuevoLibro.horas);
                bd.ejecutaComando();
                bd.confirmarTransaccion();
            }
            catch (Exception)
            {
                bd.desconectar();
                throw;
            }
            bd.desconectar();
        }

    }
}
