using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DProducto
    {
        private AmitaiBDEntities dbContext = new AmitaiBDEntities();
        public List<Producto> Consultar()
        {
            List<Producto> listalum = dbContext.Producto.ToList();

            return listalum;
        }
        public Producto Consultar(int id)
        {
            Producto prod = dbContext.Producto.Find(id);
 
            return prod;
        }
        public void Agregar(Producto prod)
        {
            dbContext.Producto.Add(prod);
            dbContext.SaveChanges();
        }
        public void Actualizar(Producto prod)
        {
            Producto pro = dbContext.Producto.Find(prod.idProducto);
            dbContext.Entry(pro).CurrentValues.SetValues(prod);
            dbContext.SaveChanges();
        }
        public void Eliminar(int id)
        {
            Producto prod = dbContext.Producto.Find(id);
            dbContext.Producto.Remove(prod);
            dbContext.SaveChanges();
        }
    }
}
