using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mercado_do_zé.Models;
using Mercado_do_zé.ViewModels;
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
			var clientes = _context.Clientes.ToList();

			return View(clientes);
		}

		public ActionResult Detalhes(int id)
		{
			var cliente = _context.Clientes.SingleOrDefault(c => c.Id == id);

			if (cliente == null)
				return HttpNotFound();

			return View(cliente);
		}

        public ActionResult Editar(int id)
        {
            var cliente = _context.Clientes.SingleOrDefault(c => c.Id == id);

            if (cliente == null)
                return HttpNotFound();

            var viewModel = new ClienteEditarViewModel
            {
                Cliente = cliente
            };
            
            return View("Editar", viewModel);
        }

        public ActionResult Deletar(int id)
        {
            var cliente = _context.Clientes.SingleOrDefault(c => c.Id == id);

            if (cliente == null)
                return HttpNotFound();


            _context.Clientes.Remove(cliente);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult Salvar(Cliente cliente) // recebemos um cliente
        {
            if (cliente.Id == 0)
            {
                // armazena o cliente em memória
                _context.Clientes.Add(cliente);
            }
            else
            {
                var customerInDb = _context.Clientes.Single(c => c.Id == cliente.Id);

                customerInDb.Nome = cliente.Nome;
                customerInDb.EnderecoImagem = cliente.EnderecoImagem;
                customerInDb.Descricao = cliente.Descricao;
            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }

        public ActionResult Novo()
        {

            var viewModel = new ClienteEditarViewModel {
            

            };
            return View("Editar", viewModel);

        }


	}
}