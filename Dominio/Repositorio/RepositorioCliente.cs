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
                SqlCommand sqlCommand = new SqlCommand(@"SELECT * FROM IMPORTACION,CLIENTE WHERE PERSONAID=CLIENTE.Id and CLIENTE.Id=@ID", con);
                
                sqlCommand.Parameters.Add(new SqlParameter("@ID", id));
                con.Open();
                reader = persistente.EjecutarQuery(con, sqlCommand, CommandType.Text, null);

                while (reader.Read())
                {
                    Importacion importacion = new Importacion()
                    {
                        Id= (int)reader["id"],
                        FchIngreso=(DateTime)reader["FCHINGRESO"],
                        FchSalida=(DateTime)reader["FchSalida"],
                        Precio=(decimal)reader["Precio"],
                        Cantidad=(int)reader["Cantidad"],
                        Producto = new Producto()
                        {
                            Id=(int)reader["ProductoID"],
                            Cliente= new Cliente()
                            {
                                
                                Antiguedad=(DateTime)reader["Antiguedad"],
                                Rut=(string)reader["Rut"],
                                Nombre=(string)reader["Nombre"],
                                
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
