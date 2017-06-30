using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;
using System.Data.Common;

namespace Logica
{
    public class clsAlumno
    {
        public string nombre { get; set; }
        public int rut { get; set; }
        public int codigoAsignatura { get; set; }
        public string presente = "N";

        // Constructor
        public clsAlumno(string _nombre, int _rut, int _codigoAsignatura)
        {
            nombre = _nombre;
            rut = _rut;
            codigoAsignatura = _codigoAsignatura;
        }

        public static clsAlumno traerAlumnos(int _codigoAsignatura)
        {
            clsAlumno alumno = null;
            BaseDatos bd = new BaseDatos();
            string SQL = "select * from tbo_alumnos where codigoAsignatura=@codigo";
            try
            {
                bd.conectar();
                bd.comenzarTransaccion();
                bd.crearComando(SQL);
                bd.asignarParametroEntero("@codigo", _codigoAsignatura);
                DbDataReader datoalumno = bd.ejecutarConsulta();
                if (datoalumno.Read())
                {
                    alumno = new clsAlumno(datoalumno.GetValue(0).ToString(), int.Parse(datoalumno.GetValue(1).ToString()), int.Parse(datoalumno.GetValue(2).ToString()));
                }
            }
            catch (Exception)
            {
                bd.desconectar();
                throw;
            }
            bd.desconectar();
            return alumno;
        }

        
    }
}
