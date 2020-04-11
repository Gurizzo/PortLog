using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Dominio
{
    public abstract class Persistente
    {
        private static string StringConexion
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            }


        }//Recordar agregar la referencia


        public abstract bool Modificar();
        public abstract bool Eliminar();
        public abstract bool Leer();
        public abstract bool Guardar();

        public SqlConnection ObtenerConexion()
        {

            return (string.IsNullOrEmpty(StringConexion) ? null : new SqlConnection(StringConexion));
        }

        public SqlDataReader EjecutarQuery(SqlConnection con,string text,CommandType tipo, List<SqlParameter> parametros)
        {
            SqlDataReader reader = null;

            try
            {
                SqlCommand comando = new SqlCommand(text, con);
                comando.CommandType = tipo;
                if (parametros != null)
                {
                    comando.Parameters.AddRange(parametros.ToArray());
                }
                if (con!=null && con.State!=ConnectionState.Open)
                {
                    con.Open();

                }
                reader = comando.ExecuteReader();
            }
            catch
            {
                throw;
            }
            return reader;
        }

        public int EjecutarNoQuery(SqlConnection con,string text,CommandType tipo, List<SqlParameter> parametros)
        {
            return this.EjecutarNoQuery(con, text, tipo, parametros, null);
        }

        public int EjecutarNoQuery(SqlConnection con,string text,CommandType tipo,List<SqlParameter>parametros,SqlTransaction trans)
        {
            int afectadas = -1;
            try
            {
                SqlCommand comando = new SqlCommand(text, con);
                if (trans != null)
                {
                    comando.Transaction = trans;
                }
                else
                {
                    if(con!=null && con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    
                }
                comando.CommandType = tipo;
                if (parametros != null)
                {
                    comando.Parameters.AddRange(parametros.ToArray());
                }
                afectadas = comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            return afectadas;
        }

    }
}
