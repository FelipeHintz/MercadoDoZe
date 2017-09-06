using Mercado_do_zé.Models;
using Mercado_do_zé.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mercado_do_zé.Controllers
{
	public class ProdutosController : Controller
	{
		public IEnumerable<Produto> GetProdutos()
		{
			return new List<Produto>
			{
				new Produto {Nome = "Sabão", Id = 1, Descrição = "Tem cheiro", Quantidade = 100, Valor = 2.50, EnderecoImagem = "teste.gif"},
				new Produto {Nome = "Pão", Id = 2, Descrição = "Duro igual pedra", Quantidade = 50, Valor = 0.25, EnderecoImagem = "teste.gif"}
			};
		}

		public ActionResult Detalhes(int id)
		{
            var produto = GetProdutos().SingleOrDefault(c => c.Id == id);

            if (produto == null)
                return HttpNotFound();

            return View(produto);
		}

		public ActionResult Index()
		{
			var produtos = GetProdutos();

			return View(produtos);
		}

	}
}