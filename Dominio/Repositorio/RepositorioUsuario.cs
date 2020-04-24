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
    public class RepositorioUsuario : IRepoUsuario
    {
        public bool Alta(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public bool Baja(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Todos()
        {
            throw new NotImplementedException();
        }

        public Usuario ValidarLogin(string ci, string password)
        {
            Usuario usuario = new Usuario();

            Persistente persistente = new Persistente();
            

            SqlConnection con = null;
            SqlDataReader reader = null;

            try
            {
                con = persistente.ObtenerConexion();
                SqlCommand comando = new SqlCommand("select * from USUARIO where ci=@ci and pass=@pass", con);
                comando.Parameters.Add(new SqlParameter("@ci", ci));
                comando.Parameters.Add(new SqlParameter("@pass", password));

                reader = persistente.EjecutarQuery(con, comando, CommandType.Text, null);

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

