using NSInmobiliaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace NSInmobiliaria.Controllers
{
    public class PropiedadController : Controller
    {
        // GET: Propiedad
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PropiedadViewModel model)
        {
            var propiedad = new PropiedadViewModel(model.Direccion, model.Precio);
            return View();
        }
    }
}