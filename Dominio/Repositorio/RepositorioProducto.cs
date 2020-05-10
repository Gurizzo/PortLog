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
    public class RepositorioProducto : IRepoProducto
    {
        public bool Alta(Producto obj)
        {
            throw new NotImplementedException();
        }

        public bool Baja(Producto obj)
        {
            throw new NotImplementedException();
        }

        public Producto BuscarPorCodigo(int Codigo)
        {
            Persistente persistente = new Persistente();
            Producto producto = new Producto();
            SqlConnection con = null;
            SqlDataReader reader = null;
            try
            {
                con = persistente.ObtenerConexion();
                SqlCommand command = new SqlCommand(@"select p.Id as idProducto,p.NOMBRE as NombrePreoducto,p.PESO,p.PRECIO,
                c.Id as idCliente,c.NOMBRE as NombreCliente 
                from Producto p,CLIENTE c 
                where p.CODIGO=@Codigo",con);
                command.Parameters.Add(new SqlParameter("@Codigo", Codigo));

                con.Open();
                reader = persistente.EjecutarQuery(con, command, CommandType.Text,null);

                while (reader.Read())
                {
                    Producto p = new Producto
                    {
                         Id=(int)reader["idProducto"],
                         Nombre=(string)reader["NombrePreoducto"],
                         Peso=(Decimal)reader["Peso"],
                         Precio=(Decimal)reader["Precio"],
                         Cliente = new Cliente()
                         {
                             Nombre=(string)reader["NombreCliente"],
                             Id=(int)reader["idCliente"]
                         }
                    };
                    producto = p;
                }

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            return producto;
            
        }

        public Producto BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Producto obj)
        {
            throw new NotImplementedException();
        }

        public List<Producto> Todos()
        {
            Persistente persistente = new Persistente();
            List<Producto> productos = new List<Producto>();
            SqlConnection con = null;
            SqlDataReader reader = null;
            /*SqlCommand command = new SqlCommand(@"SELECT P.CODIGO,P.NOMBRE,SUM(I.CANTIDAD)AS CANTIDAD
                FROM PRODUCTO P, IMPORTACION I 
                WHERE P.Id = I.PRODUCTOID 
                GROUP BY P.CODIGO,P.NOMBRE", con);*/
            try
            {
                con = persistente.ObtenerConexion();
                SqlCommand command = new SqlCommand(@"  select  P.CODIGO, P.NOMBRE,SUM(i.CANTIDAD) AS CANTIDAD 
                from PRODUCTO p, IMPORTACION i, CLIENTE c 
                where   P.CLIENTEID = c.Id  GROUP BY P.CODIGO,P.NOMBRE", con);/*ES HORRIBLE*/
                con.Open();
                reader = persistente.EjecutarQuery(con, command, CommandType.Text, null);

                while (reader.Read())
                {
                    List<Importacion> importacions = new List<Importacion>();
                    Importacion importacion = new Importacion()
                    {
                        Cantidad= (int)reader["Cantidad"]
                    };
                    importacions.Add(importacion);

                    Producto p = new Producto()
                    {
                        Codigo = (int)reader["codigo"],
                        Nombre = (string)reader["Nombre"],
                        Importaciones = importacions
                    };
                    productos.Add(p);
                }

            }
            catch
            {

            }

            return productos;
        }

        public bool Validar(Producto obj)
        {
            throw new NotImplementedException();
        }
    }
}
