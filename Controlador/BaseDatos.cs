using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Configuration;

namespace Controlador
{
    public class BaseDatos
    {
        private DbConnection _conexion = null;
        private DbCommand _comando = null;
        private DbTransaction _transaccion = null;
        private string _cadenaConexion;

        private static DbProviderFactory _factory = null;

        public BaseDatos()
        {
            configurar();
        }

        private void configurar()
        {
            try
            {
                string proveedor = ConfigurationManager.AppSettings.Get("PROVEEDOR_ADONET");
                this._cadenaConexion = ConfigurationManager.AppSettings.Get("CADENA_Conexion");
                _factory = DbProviderFactories.GetFactory(proveedor);
            }
            catch (ConfigurationErrorsException ex)
            {
                
                throw new BaseDatosException("Error al cargar la configuraciòn del acceso a datos.", ex);
            }
        }

        public void desconectar()
        {
            if (this._conexion.State.Equals(ConnectionState.Open))
            {
                this._conexion.Close();
            }              
        }

        public void conectar()
        {
            if (this._conexion != null)
            {
                if(this._conexion.State.Equals(ConnectionState.Closed))
                {
                    throw new BaseDatosException("La conexión ya se encuentra abierta");
                }                    
            }
            try 
	        {
                	if(this._conexion == null)
                    {
                        this._conexion = _factory.CreateConnection();
                        this._conexion.ConnectionString = _cadenaConexion;                            
                    }
                this._conexion.Open();
	        }
	        catch (DataException )
	        {
		
		        throw new BaseDatosException("Error al conectarse.");
	        }
               
        }

        public void crearComando(string sentenciaSQL)
        {
            this._comando = _factory.CreateCommand();
            this._comando.Connection = this._conexion;
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = sentenciaSQL;
            if (this._transaccion != null)
            {
                this._comando.Transaction = this._transaccion;
            }              
        }

        public void asignarParametroNull(string nombre)
        {
            asignarParametro(nombre, "", "NULL");                
        }
        public void asignarParametroCadena(string nombre, string valor)
        {
            asignarParametro(nombre, "'", valor);
        }

        public void asignarParametroEntero(string nombre, int valor)
        {
            asignarParametro(nombre, "", valor.ToString());
        }

        private void asignarParametro(string nombre, string separador, string valor)
        {
            int indice = this._comando.CommandText.IndexOf(nombre);
            string prefijo = this._comando.CommandText.Substring(0, indice);
            string sufijo = this._comando.CommandText.Substring(indice + nombre.Length);
            this._comando.CommandText = prefijo + separador + valor + separador + sufijo;
        }

        public void asignarParametroFecha(string nombre, DateTime valor)
        {
            asignarParametro(nombre, "'", valor.ToString());
        }

        public DbDataReader ejecutarConsulta()
        {
            return this._comando.ExecuteReader();
        }

        public int ejecutarEscalar()
        {
            int escalar = 0;
                try 
	            {	  
                    escalar = Int32.Parse(this._comando.ExecuteScalar().ToString());		
	            }
	            catch (InvalidCastException ex)
	            {
		
		            throw new BaseDatosException("Error al ejecutar un escalar.", ex);;
	            }
            return escalar;
                
        }

        public void ejecutaComando()
        {
            this._comando.ExecuteNonQuery();
                
        }

        public void comenzarTransaccion()
        {
            if (this._transaccion != null)
            {
                this._transaccion = this._conexion.BeginTransaction();                    
            }              
        }

        public void cancelarTransaccion()
        {
            if (this._transaccion != null)
            {
                this._transaccion.Rollback();
            }
        }
        public void confirmarTransaccion()
        {
            if (this._transaccion != null)
            {
                this._transaccion.Commit();
            }
                
        }


    }
}
