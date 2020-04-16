using Dominio.Clases;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositorio
{
    public class RepositorioUsuario : Persistente<Usuario>
    {
        public override Usuario BuscarPorId()
        {
            throw new NotImplementedException();
        }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public override bool Guardar()
        {
            throw new NotImplementedException();
        }

        public override bool Leer()
        {
            throw new NotImplementedException();
        }

        public override bool Modificar()
        {
            throw new NotImplementedException();
        }

        public override List<Usuario> TraerTodo()
        {
            throw new NotImplementedException();
        }

        public override Usuario Validar(Usuario obj)
        {
            Usuario usuario = new Usuario();


            SqlConnection con = null;
            SqlDataReader reader = null;

            try
            {
                con = this.ObtenerConexion();
                SqlCommand comando = new SqlCommand("select * from USUARIO where ci=@ci and pass=@pass", con);
                comando.Parameters.Add(new SqlParameter("@ci", obj.CI));
                comando.Parameters.Add(new SqlParameter("@pass", obj.Password));

                reader = this.EjecutarQuery(con, comando, CommandType.Text, null);

                while (reader.Read())
                {

                    usuario.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    usuario.CI = reader["ci"].ToString();
                    usuario.Password = reader["pass"].ToString();
                    usuario.Rol = reader["rol"].ToString();




                }

            }
            catch
            {
                throw;
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open) con.Close();
                if (reader != null) reader.Close();
            }

            return usuario;
        }
    }
}
