using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebExamenFinal.DataAccess;
using WebExamenFinal.Model;

namespace WebExamenFinal.Areas.Biblioteca.Controllers
{
    public class AutorController : Controller
    {
        // GET: Biblioteca/Autor
        public AutorRepositorio _autor = new AutorRepositorio();
        public ActionResult Index()
        {
            return View(_autor.ObtenerLista());
        }

        public ActionResult Crear()
        {
            return View(new Autores());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Autores autor)
        {
            if (ModelState.IsValid)
            {
                _autor.Agregar(autor);
                RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Actualizar(int id)
        {
            var libro = _autor.ObtenerAutorPorID(id);
            if (libro == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            return View(libro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Actualizar(Autores autores)
        {
            if (!ModelState.IsValid) return View();
            _autor.Actualizar(autores);
            return RedirectToRoute("Index");
        }

        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            var autor = _autor.ObtenerAutorPorID(id);
            if (autor == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return View(autor);
        }

        [HttpPost]
        public ActionResult Eliminar(Autores autor)
        {
            _autor.Eliminar(autor);
            return RedirectToAction("Index");
        }

    }
}