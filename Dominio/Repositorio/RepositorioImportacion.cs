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
            Persistente persistente = new Persistente();
            
            SqlConnection con = null;

            try
            {
                con = persistente.ObtenerConexion();
                SqlCommand sqlCommand = new SqlCommand(@"INSERT INTO IMPORTACION VALUES(@FCHENTRADA,@FCHSALIDA,@PRODUCTOID,@PRECIO,@CANTIDAD,@PERSONAID,@PAISID,@ALMACENADO)", con);
                List<SqlParameter> sqlParameters = new List<SqlParameter>()
                {
                    new SqlParameter("@FCHENTRADA", obj.FchIngreso),
                    new SqlParameter("@FCHSALIDA", obj.FchSalida),
                    new SqlParameter("@PRODUCTOID", obj.Producto.Id),
                    new SqlParameter("@PRECIO", obj.Producto.Precio),
                    new SqlParameter("@CANTIDAD", obj.Cantidad),
                    new SqlParameter("@PERSONAID", obj.Producto.Cliente.Id),
                    new SqlParameter("@PAISID", obj.Pais.Id),
                    new SqlParameter("@ALMACENADO", obj.Almacenado),

                };
                con.Open();
                int filas = persistente.EjecutarNoQuery(con, sqlCommand, CommandType.Text, sqlParameters);
                con.Close();



            }
            catch
            {
                return false;
            }
            finally
            {

            }


            return true;
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
                SqlCommand command = new SqlCommand(@"Select imp.id, imp.FCHINGRESO, imp.FCHSALIDA, imp.PRODUCTOID, imp.CANTIDAD, imp.PAISID, imp.ALMACENADO,
                  pa.CodPais, pa.NombrePais,
                  pro.NOMBRE as NombreProducto,pro.CODIGO,pro.PESO
                  from Importacion imp, Pais pa, Producto pro
                  where imp.PaisID = pa.id and imp.PRODUCTOID = pro.id", con);
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
                        Almacenado = (bool)reader["Almacenado"],
                        
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
