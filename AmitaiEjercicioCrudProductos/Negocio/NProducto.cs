using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProducto
    {
        DProducto dProducto = new DProducto();

        public List<Producto> Consultar()
        {
            return dProducto.Consultar();
        }
        public Producto Consultar(int id)
        {
            return dProducto.Consultar(id);
        }
        public void Agregar(Producto prod)
        {
            dProducto.Agregar(prod);
        }
        public void Actualizar(Producto prod)
        {
            dProducto.Actualizar(prod);
        }
        public void Eliminar(int id)
        {
            dProducto.Eliminar(id);
        }
    }
}
