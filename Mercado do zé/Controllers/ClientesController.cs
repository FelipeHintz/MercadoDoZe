using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mercado_do_zé.Models;
using System.Data.Entity;

namespace Mercado_do_zé.Controllers
{
    public class ClientesController : Controller
    {
        private ApplicationDbContext _context;

        public ClientesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var clientes = _context.Clientes.Include(c => c.MembershipType).ToList();

            return View(clientes);
        }

        public ActionResult Detalhes(int id)
        {
            var cliente = _context.Clientes.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (cliente == null)
                return HttpNotFound();

            return View(cliente);
        }

	}
}