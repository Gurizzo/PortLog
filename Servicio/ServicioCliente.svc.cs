using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Dominio.Clases;
using Dominio.Interfaces;
using Dominio.Repositorio;
using Servicio.DTO;

namespace Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCliente" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioCliente.svc o ServicioCliente.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioCliente : IServicioCliente
    {
        RepositorioCliente Repo = new RepositorioCliente();

        public bool AltaCliente(ClienteDTO cliente)
        {
            throw new NotImplementedException();
        }

        public bool BajaCliente(int clienteId)
        {
            throw new NotImplementedException();
        }

        public ClienteDTO BuscarCliente(int clienteId)
        {
            throw new NotImplementedException();
        }


        public decimal CalcularGanancia(int id)
        {
                decimal ganancia = 0;

                decimal descuento = 0;

                var importaciones = Repo.Ganancia(id);



                foreach (Importacion i in importaciones)
                {
                    if (!i.Almacenado)
                    {//Esta en deposito
                        if (i.FchSalida >= DateTime.Today)
                        {//Si la fecha de salida es mayor a hoy
                            ganancia += i.Precio * i.Cantidad * i.CalcularDias();
                        }
                        else
                        {//La fecha es menor a hoy y no se importo
                            ganancia += i.Precio * i.Cantidad * ( DateTime.Today- i.FchIngreso).Days;
                        }

                    }
                    else
                    {//si ya se envio
                        ganancia += i.Precio * i.Cantidad * i.CalcularDias();
                    }

                }
                if (importaciones[0].Producto.Cliente.Descuento())
                {//Mejor asegurar 
                    descuento = 10 / 100 * ganancia;
                }







                return (ganancia - descuento) * 2 / 100;
        }
        

        public bool ModificarCliente(ClienteDTO cliente)
        {
            throw new NotImplementedException();
        }

        public List<ClienteDTO> TraerTodos()
        {
            List<ClienteDTO> dTOs = new List<ClienteDTO>();
            var clientes = Repo.Todos();

            foreach (Cliente c in clientes)
            {
                ClienteDTO dTO = new ClienteDTO()
                {
                    Id= c.Id,
                    Rut = c.Rut,
                    Nombre = c.Nombre,
                    Antiguedad= c.Antiguedad
                    
                };
                dTOs.Add(dTO);
            }



            return dTOs;
        }
    }
}
