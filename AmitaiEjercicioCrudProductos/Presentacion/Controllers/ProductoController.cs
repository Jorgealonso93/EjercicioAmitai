using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentacion.Controllers
{
    public class ProductoController : Controller
    {
        private NProducto nProducto = new NProducto();
        // GET: Producto
        public ActionResult Index()
        {
            return View(nProducto.Consultar());
        }

        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            return View(nProducto.Consultar(id));
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create(Producto prod)
        {
            try
            {
                nProducto.Agregar(prod);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            Producto prod = nProducto.Consultar(id);
            return View(prod);
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(Producto prod)
        {
            try
            {
                nProducto.Actualizar(prod);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Delete/5
        public ActionResult _Delete(int id)
        {
            return PartialView(nProducto.Consultar(id));
        }

        // POST: Producto/Delete/5
        [HttpPost]
        public ActionResult _Delete(int id, Producto prod)
        {
            try
            {
                prod = nProducto.Consultar(id);
                nProducto.Eliminar(prod.idProducto);

                return RedirectToAction("Index");
            }
            catch
            {
                return PartialView();
            }
        }
    }
}
