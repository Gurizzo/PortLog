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
                  pro.NOMBRE as NombreProducto,pro.CODIGO,pro.PESO
                  from Importacion imp, Pais pa, Producto pro, CLIENTE cli
                  where imp.PaisID = pa.id and imp.PRODUCTOID = pro.id and imp.PERSONAID = cli.Id", con);
                con.Open();
                reader = persistente.EjecutarQuery(con, command, CommandType.Text, null);

                while (reader.Read())
                {
                    Importacion importacion = new Importacion()
                    {

                        Id = (int)reader["id"],
                        FchIngreso = (DateTime)reader["FCHINGRESO"],
                        FchSalida = (DateTime)reader["FCHSALIDA"],
                        Cantidad = (int)reader["Cantidad"],
                        Enviado = (bool)reader["Almacenado"],
                        
                        Pais = new Pais()
                        {
                            Id = (int)reader["PAISID"],
                            CodPais = (string)reader["CodPais"],
                            Nombre = (string)reader["NombrePais"],

                        },
                        Producto = new Producto
                        {
                            Id= (int)reader["ProductoId"],
                            Nombre = (string)reader["NombreProducto"],
                            Codigo= (int)reader["codigo"],
                            Peso= (decimal)reader["peso"],
                            Cliente  = new Cliente
                            {
                                Id = (int)reader["PERSONAID"],
                                Rut = (string)reader["RUT"],
                                Nombre = (string)reader["NOMBRE"],
                                Antiguedad = (DateTime)reader["ANTIGUEDAD"]
                            }

                        },
                        
                       
                        





                    };
                    //importacion.Descuento = importacion.Producto.Cliente.Descuento();
                    importaciones.Add(importacion);
                }

            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                con.Close();
            }

            return importaciones;

        }

        
    }
}
