using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;
using System.Data.Common;

namespace Logica
{
    public class clsEncargado
    {
        public string nombre { get; set; }
        public int rut { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public char tipoUsuario { get; set; }

        // Constructor
        public clsEncargado(string _nombre, int _rut, string _usuario, string _contraseña, char _tipoUsuario)
        {
            nombre = _nombre;
            rut = _rut;
            usuario = _usuario;
            contraseña = _contraseña;
            tipoUsuario = _tipoUsuario;
        }
        public static clsEncargado inicioSesion(string usuario, string contraseña)
        {
            clsEncargado objUsuario = null;
            BaseDatos bd = new BaseDatos();
            string SQL = "select * from tbo_docentes where usuario=@usuario and contraseña=@contraseña";
            try
            {
                bd.conectar();
                bd.comenzarTransaccion();
                bd.crearComando(SQL);
                bd.asignarParametroCadena("@usuario", usuario);
                bd.asignarParametroCadena("@contaseña", contraseña);
                DbDataReader datosUsuario = bd.ejecutarConsulta();
                if (datosUsuario.Read())
                {
                    objUsuario = new clsEncargado(datosUsuario.GetValue(0).ToString(), int.Parse(datosUsuario.GetValue(1).ToString()), datosUsuario.GetValue(2).ToString(), datosUsuario.GetValue(3).ToString(), datosUsuario.GetChar(4));
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
