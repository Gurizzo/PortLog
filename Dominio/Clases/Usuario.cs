﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
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

        public bool validar()
        {
            if (!string.IsNullOrEmpty(CI) && !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(Rol))
            {
                return true;
            }
            return false;
        }

    }
}
