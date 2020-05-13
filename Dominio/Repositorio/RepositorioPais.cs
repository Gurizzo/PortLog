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
    public class RepositorioPais : IRepoPais
    {
        public bool Alta(Pais obj)
        {
            throw new NotImplementedException();
        }

        public bool Baja(Pais obj)
        {
            throw new NotImplementedException();
        }

        public Pais BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Pais obj)
        {
            throw new NotImplementedException();
        }

        public List<Pais> Todos()
        {
            Persistente persistente = new Persistente();
            List<Pais> paises = new List<Pais>();
            SqlConnection con = null;
            SqlDataReader reader = null;

            try
            {
                con = persistente.ObtenerConexion();
                SqlCommand command = new SqlCommand("SELECT * FROM PAIS", con);
                con.Open();
                reader = persistente.EjecutarQuery(con, command, CommandType.Text, null);
                while (reader.Read())
                {
                    Pais p = new Pais()
                    {
                        CodPais = (string)reader["CodPais"],
                        Id = (int)reader["id"],
                        Nombre = (string)reader["NombrePais"]
                    };
                    paises.Add(p);
                }

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }

            return paises;
        }

       
    }
}
