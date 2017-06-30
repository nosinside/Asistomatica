using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;
using System.Data.Common;

namespace Logica
{
    public class clsAsignatura
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

        // metodos

            // obtener lista de asignaturas sin libros.

        public static List<clsAsignatura> getAsignatura()
        {
            List<clsAsignatura> _tmpListaAsignaturas = null;
            clsAsignatura objAsignatura = null;
            string SQL = "select * from tbo_asignatura where porcentajeAsistencia=0";
            BaseDatos bd = new BaseDatos();
            try
            {
                bd.conectar();
                bd.comenzarTransaccion();
                bd.crearComando(SQL);
                DbDataReader datosasignatura = bd.ejecutarConsulta();
                if (datosasignatura.HasRows)
                {
                    _tmpListaAsignaturas = new List<clsAsignatura>();
                    while (datosasignatura.Read())
                    {
                        objAsignatura = new clsAsignatura(datosasignatura.GetValue(0).ToString(), int.Parse(datosasignatura.GetValue(1).ToString()), int.Parse(datosasignatura.GetValue(2).ToString()), datosasignatura.GetValue(3).ToString(), datosasignatura.GetValue(4).ToString(), int.Parse(datosasignatura.GetValue(5).ToString()), int.Parse(datosasignatura.GetValue(6).ToString()), int.Parse(datosasignatura.GetValue(7).ToString()), int.Parse(datosasignatura.GetValue(8).ToString()));
                        _tmpListaAsignaturas.Add(objAsignatura);
                    }
                }
            }
            catch (Exception)
            {
                bd.desconectar();
                throw;
            }
            bd.desconectar();
            return _tmpListaAsignaturas; 
        }

        public static clsAsignatura TraerAsignatura(int id)
        {
            clsAsignatura traer = null;
            string SQL = "select * from tbo_asignatura where codigo=@id";
            BaseDatos bd = new BaseDatos();
            try
            {
                bd.conectar();
                bd.comenzarTransaccion();
                bd.crearComando(SQL);
                bd.asignarParametroEntero("@id", id);
                DbDataReader datosasignatura = bd.ejecutarConsulta();
                if (datosasignatura.Read())
                {
                    traer = new clsAsignatura(datosasignatura.GetValue(0).ToString(), int.Parse(datosasignatura.GetValue(1).ToString()), int.Parse(datosasignatura.GetValue(2).ToString()), datosasignatura.GetValue(3).ToString(), datosasignatura.GetValue(4).ToString(), int.Parse(datosasignatura.GetValue(5).ToString()), int.Parse(datosasignatura.GetValue(6).ToString()), int.Parse(datosasignatura.GetValue(7).ToString()), int.Parse(datosasignatura.GetValue(8).ToString()));
                }
            }
            catch (Exception)
            {
                bd.desconectar();
                throw;
            }
            bd.desconectar();
            return traer;
        }

        // Insertar porcentajes a asignatura
        public static void UpdateAsignatura(int hora, int codigo)
        {
            BaseDatos bd = new BaseDatos();
            try
            {
                string SQL = "update tbo_asignatura set porcentajeAsistencia=@hora where codigo=@codigo";
                bd.conectar();
                bd.comenzarTransaccion();
                bd.crearComando(SQL);
                bd.asignarParametroEntero("@hora", hora);
                bd.asignarParametroEntero("@codigo", codigo);
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
