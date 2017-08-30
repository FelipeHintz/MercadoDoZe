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
        
        public IEnumerable<Cliente> GetClientes()
        {
            return new List<Cliente>
            {
                new Cliente {Nome = "Zé da Farmacia", Id = 1},
                new Cliente {Nome = "Zé do Caixão", Id = 2}
            };
        }

        public ActionResult Index()
        {
            var clientes = GetClientes();

            return View(clientes);
        }

        public ActionResult Detalhes(int id)
        {
            var cliente = GetClientes().SingleOrDefault(c => c.Id == id);

            if (cliente == null)
                return HttpNotFound();

            return View(cliente);
        }

	}
}