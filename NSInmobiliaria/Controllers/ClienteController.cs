using NSInmobiliaria.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NSInmobiliaria.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }

        // GET: Prueba/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Prueba/Create
        public ActionResult Create()
        {
            using (NSInmobiliariaEntities context = new NSInmobiliariaEntities())
            {
                CLIENTES cliente = new CLIENTES
                {
                    ID = 1,
                    NOMBRE = "Evaristo",
                    APELLIDO = "Marro",
                    CELULAR = "1153436573",
                    DIRECCION = "Anchorena 1267 1ºC",
                    MAIL = "jose.evaristo.marro@gmail.com"
                };
                context.CLIENTES.Add(cliente);
                context.SaveChanges();
            }
            return View("Cliente");
        }

        // POST: Prueba/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Prueba/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Prueba/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Prueba/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Prueba/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
