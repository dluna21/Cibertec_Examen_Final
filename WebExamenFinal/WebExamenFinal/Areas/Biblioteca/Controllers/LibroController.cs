using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebExamenFinal.Model;
using WebExamenFinal.DataAccess;
using System.Net;

namespace WebExamenFinal.Areas.Biblioteca.Controllers
{
    [Authorize]
    public class LibroController : Controller
    {
        // GET: Biblioteca/Libro
        public LibrosRepositorio _libros = new LibrosRepositorio();
        public ActionResult Index()
        {
            return View(_libros.ObtenerLista());
        }

        public ActionResult Crear() {
            return View(new Libros());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Libros libro)
        {
            if (ModelState.IsValid) {
                _libros.Agregar(libro);
                RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Actualizar(int id)
        {
            var libro = _libros.ObtenerLibroPorID(id);
            if (libro == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            return View(libro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [OutputCache(Duration = 0)]
        public ActionResult Actualizar(Libros libro)
        {
            if (!ModelState.IsValid) return View();
            _libros.Actualizar(libro);
            return RedirectToRoute("Index");
        }

        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            var libro = _libros.ObtenerLibroPorID(id);
            if (libro == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return View(libro);
        }

        [HttpPost]
        public ActionResult Eliminar(Libros libro)
        {
            _libros.Eliminar(libro);
             return RedirectToAction("Index");
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Actualizar(Libros libro)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _libros.Actualizar(libro);
        //        RedirectToAction("Index");
        //    }
        //    return View();
        //}


    }
}