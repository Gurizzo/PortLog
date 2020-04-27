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
    public class RepositorioImportacion : IRepoImportacion
    {
        public bool Alta(Importacion obj)
        {
            throw new NotImplementedException();
        }

        public bool Baja(Importacion obj)
        {
            throw new NotImplementedException();
        }

        public Importacion BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Importacion obj)
        {
            throw new NotImplementedException();
        }

        public List<Importacion> Todos()
        {
            Persistente persistente = new Persistente();
            List<Importacion> importaciones = new List<Importacion>();
            SqlConnection con = null;
            SqlDataReader reader = null;

            try
            {
                con = persistente.ObtenerConexion();
                SqlCommand command = new SqlCommand(@"Select imp.id, imp.FCHINGRESO, imp.FCHSALIDA, imp.PRODUCTOID, imp.CANTIDAD, imp.PERSONAID, imp.PAISID, imp.ALMACENADO,
                  pa.CodPais, pa.NombrePais,
                  cli.RUT, cli.NOMBRE, cli.ANTIGUEDAD,
                  from Importacion imp, Pais pa, Producto pro, CLIENTE cli
                  where imp.PaisID = pa.id and imp.PRODUCTOID = pro.id and imp.PERSONAID = cli.Id", con);
                con.Open();
                reader = persistente.EjecutarQuery(con, command, CommandType.Text, null);

                while (reader.Read())
                {
                    Importacion importacion = new Importacion()
                    {

                        Id = (int)reader["imp.id"],
                        FchIngreso = reader.GetDateTime(3),
                        FchSalida = reader.GetDateTime(3),
                        Cantidad = (int)reader["imp.Cantidad"],
                        Enviado = (bool)reader["imp.Almacenado"],
                        Cliente = new Cliente()
                        {
                            Id = (int)reader["imp.PERSONAID"],
                            Rut = (string)reader["cli.RUT"],
                            Nombre = (string)reader["cli.NOMBRE"],
                            Antiguedad = (DateTime)reader["cli.ANTIGUEDAD"]
                        },
                        Pais = new Pais()
                        {
                            Id = (int)reader["imp.PAISID"],
                            CodPais = (string)reader["pa.CodPais"],
                            Nombre = (string)reader["pa.NombrePais"]
                        },
                        





                    };
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }


            return importaciones;
        }

        
    }
}
