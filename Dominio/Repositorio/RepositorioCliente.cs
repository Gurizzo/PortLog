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
    public class RepositorioCliente : IRepoCliente
    {
        
        
        public bool Alta(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public bool Baja(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Importacion> Ganancia(int id)
        {
            Persistente persistente = new Persistente();
            List<Importacion> importaciones = new List<Importacion>();
            SqlConnection con = null;
            SqlDataReader reader = null;
            try
            {
                con = persistente.ObtenerConexion();
                SqlCommand sqlCommand = new SqlCommand(@"select i.Id as IdImportacion,i.FCHINGRESO, i.FCHSALIDA,i.PRODUCTOID,i.PRECIO,i.CANTIDAD,i.PAISID,i.ALMACENADO,
                p.Id as ProductoID,p.CODIGO,p.CLIENTEID,p.NOMBRE,p.PESO,p.PRECIO,
                c.ANTIGUEDAD,c.NOMBRE as NombreCliente,c.RUT 
                from IMPORTACION i, PRODUCTO p,CLIENTE c 
                where i.PRODUCTOID=p.Id and p.CLIENTEID=@ID and c.Id=@ID", con);
                
                sqlCommand.Parameters.Add(new SqlParameter("@ID", id));
                con.Open();
                reader = persistente.EjecutarQuery(con, sqlCommand, CommandType.Text, null);

                while (reader.Read())
                {
                    Importacion importacion = new Importacion()
                    {
                        Id= (int)reader["IdImportacion"],
                        FchIngreso=(DateTime)reader["FCHINGRESO"],
                        FchSalida=(DateTime)reader["FCHSALIDA"],
                        Precio=(decimal)reader["PRECIO"],
                        Cantidad=(int)reader["CANTIDAD"],
                        Producto = new Producto()
                        {
                            Id=(int)reader["ProductoID"],
                            Cliente= new Cliente()
                            {
                                
                                Antiguedad=(DateTime)reader["ANTIGUEDAD"],
                                Rut=(string)reader["RUT"],
                                Nombre=(string)reader["NombreCliente"],
                                
                            }
                        },
                        
                    };
                    importaciones.Add(importacion);
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return importaciones;
        }

        public decimal PorcenGanancia()
        {
            Persistente persistente = new Persistente();

            SqlConnection con = null;
            SqlDataReader reader = null;
            con = persistente.ObtenerConexion();
            SqlCommand command = new SqlCommand("SELECT GANANCIA FROM DESCUENTO", con);
            reader = persistente.EjecutarQuery(con, command, CommandType.Text, null);
            while (reader.Read())
            {
                return (decimal)reader["GANANCIA"];
            }
            return 0;
        }

        public decimal TraerDescuento()
        {
            Persistente persistente = new Persistente();

            SqlConnection con = null;
            SqlDataReader reader = null;
            con = persistente.ObtenerConexion();
            SqlCommand command = new SqlCommand("SELECT DESCUENTO FROM DESCUENTO", con);
            reader = persistente.EjecutarQuery(con, command, CommandType.Text, null);
            while (reader.Read())
            {
                return (decimal)reader["DESCUENTO"];
            }
            return 0;
        }

        public int TraerTope()
        {
            Persistente persistente = new Persistente();
            
            SqlConnection con = null;
            SqlDataReader reader = null;
            con = persistente.ObtenerConexion();
            SqlCommand command = new SqlCommand("SELECT ANIOS FROM DESCUENTO",con);
            reader = persistente.EjecutarQuery(con, command, CommandType.Text, null);
            while (reader.Read())
            {
                return (int)reader["ANIOS"];
            }


            return 0;
        }

        public bool Modificar(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> Todos()
        {
            Persistente persistente = new Persistente();
            List<Cliente> clientes = new List<Cliente>();
            SqlConnection con = null;
            SqlDataReader reader = null;

            try
            {
                con = persistente.ObtenerConexion();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM CLIENTE", con);
                con.Open();
                reader = persistente.EjecutarQuery(con,sqlCommand,CommandType.Text,null );

                while (reader.Read())
                {
                    Cliente cliente = new Cliente()
                    {
                        Id=(int)reader["id"],
                        Antiguedad=(DateTime)reader["Antiguedad"],
                        Nombre=(string)reader["Nombre"],
                        Rut=(string)reader["Rut"]
                    };
                    clientes.Add(cliente);
                }


            }
            catch
            {

            }
            finally
            {
                con.Close();
            }


            return clientes;
        }

        public bool Validar(Cliente obj)
        {
            throw new NotImplementedException();
        }
    }
}
