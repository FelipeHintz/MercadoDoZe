using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mercado_do_zé.Models;

namespace Mercado_do_zé.Controllers
{
    public class ClientesController : Controller
    {
        //
        // GET: /Clientes/
        public ActionResult Random()
        {
            var cliente = new Cliente() { nome = "Zé" };
            return View(cliente);
        }
	}
}