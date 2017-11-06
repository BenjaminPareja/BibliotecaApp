using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BibliotecaApp.Models;

namespace BibliotecaApp.Controllers
{
    public class LibroController : Controller
    {
        // GET: Libro
        public ActionResult Index()
        {
            List<Libro> libros = new List<Libro>();
            libros.Add(new Libro
            {
                ID = 1,
                Nombre = "Inferno",
                Autor = "Dan Brown"
            });
            libros.Add(new Libro
            {
                ID = 1,
                Nombre = "Danza de dragones",
                Autor = "George el curioso"
            });
            libros.Add(new Libro
            {
                ID = 1,
                Nombre = "La divina comedia",
                Autor = "Dante Aliguiari"  //un nuevo comit
            });
            return View(libros);
        }
    }
}