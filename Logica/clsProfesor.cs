using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;
using System.Data.Common;

namespace Logica
{
    public class clsProfesor
    {
        public string nombre { get; set; }
        public int rut { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string tipoUsuario { get; set; }

        // Constructor

        public clsProfesor(string _nombre, int _rut, string _usuario, string _contraseña, string _tipoUsuario)
        {
            nombre = _nombre;
            rut = _rut;
            usuario = _usuario;
            contraseña = _contraseña;
            tipoUsuario = _tipoUsuario;
        }

        public static clsProfesor inicioSesion(string usuario, string contraseña)
        {
            clsProfesor objUsuario = null;
            BaseDatos bd = new BaseDatos();
            string SQL = "select * from tbo_docentes where usuario=@usuario and contraseña=@contraseña";
            try
            {
                bd.conectar();
                bd.comenzarTransaccion();
                bd.crearComando(SQL);
                bd.asignarParametroCadena("@usuario", usuario);
                bd.asignarParametroCadena("@contraseña", contraseña);
                DbDataReader datosUsuario = bd.ejecutarConsulta();
                if (datosUsuario.Read())
                {
                    objUsuario = new clsProfesor(datosUsuario.GetValue(0).ToString(), int.Parse(datosUsuario.GetValue(1).ToString()), datosUsuario.GetValue(2).ToString(), datosUsuario.GetValue(3).ToString(), datosUsuario.GetValue(4).ToString());
                }
            }
            catch (Exception)
            {
                bd.desconectar();
                throw;
            }
            bd.desconectar();
            return objUsuario;
        }
    }
}
