using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Clases
{
    public class Producto:Persistente<Producto>
    {


        public int Id { get; set; }

        public int Codigo { get; set; }

        public string Nombre { get; set; }

        public decimal Peso { get; set; }

        public Producto(int id, int codigo, string nombre, decimal peso)
        {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
            Peso = peso;
        }

        public Producto()
        {

        }


        public override List<Producto> TraerTodo()
        {
            throw new NotImplementedException();
        }

        public override Producto BuscarPorId()
        {
            throw new NotImplementedException();
        }

        public override bool Modificar()
        {
            throw new NotImplementedException();
        }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public override bool Leer()
        {
            throw new NotImplementedException();
        }

        public override bool Guardar()
        {
            throw new NotImplementedException();
        }

        public override bool Validar(Producto obj)
        {
            throw new NotImplementedException();
        }
    }
}
