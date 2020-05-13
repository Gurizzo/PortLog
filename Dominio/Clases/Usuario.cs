using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dominio.Clases
{
    public class Usuario
    {
        public int Id { get; set; }

        public string CI { get; set; }

        public string Password { get; set; }

        public string Rol { get; set; }




        public Usuario()
        {
        }

        public Usuario(int id, string cI, string password, string rol)
        {
            this.Id = id;
            CI = cI;
            Password = password;
            Rol = rol;
        }

        /*
        public override List<Usuario> TraerTodo()
        {
            List<Usuario> lista = new List<Usuario>();
            SqlConnection con = new SqlConnection();
            SqlDataReader reader = null;

            try
            {
                con = ObtenerConexion();
                //reader = EjecutarQuery(con, "select * from USUARIO", CommandType.Text, null);

                while (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        CI = reader["ci"].ToString(),
                        Password = reader["pass"].ToString(),
                        Rol = reader["rol"].ToString()
                    };

                    lista.Add(usuario);
                }

            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                if(con!=null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                if (reader != null)
                {
                    reader.Close();
                }

            }
            return lista;
        }*/

        public bool Validar()
        {


            Regex pass = new Regex(@"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{6,16}$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);


            if (!string.IsNullOrEmpty(CI) && !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(Rol))
            {
                if(this.CI.Length>=7 & this.CI.Length <= 8)
                {
                    if(!this.CI.Contains("#") && !this.Password.Contains("#"))
                    {
                         if (!Regex.Match(this.CI, @"^[0 - 9] *$").Success)
                            {
                            if (pass.IsMatch(this.Password))
                            {
                                
                                
                                    return true;
                            }
                            
                        }
                        
                    }
                   
                }
                
            }
            return false;
        }

    }
}
