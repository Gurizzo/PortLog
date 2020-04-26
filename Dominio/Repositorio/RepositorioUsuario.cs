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
            Persistente persistente = new Persistente();
            bool retorno = false;
            SqlConnection con = null;

            try
            {
                con = persistente.ObtenerConexion();
                /*INSERT INTO USUARIO VALUES('1','uno','admin')*/
                SqlCommand comando = new SqlCommand("INSERT INTO USUARIO VALUES(@CI, @PASSWORD, @ROL)",con);
                List<SqlParameter> pars = new List<SqlParameter>();
                pars.Add(new SqlParameter("@CI", obj.CI));
                pars.Add(new SqlParameter("@PASSWORD", obj.Password));
                pars.Add(new SqlParameter("@ROL", obj.Rol));

                con.Open();
                int filas =persistente.EjecutarNoQuery(con, comando, CommandType.Text, pars);
                con.Close();

                if (filas == 1) return true;
                
            }
            catch
            {
                return false;
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open) con.Close();
                
            }

            return retorno;
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

