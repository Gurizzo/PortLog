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

            try
            {
                con = persistente.ObtenerConexion();
                SqlCommand command = new SqlCommand(@"SELECT P.CODIGO,P.NOMBRE,SUM(I.CANTIDAD)AS CANTIDAD
                FROM PRODUCTO P, IMPORTACION I 
                WHERE P.Id = I.PRODUCTOID 
                GROUP BY i.CANTIDAD,P.CODIGO,P.NOMBRE", con);
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
