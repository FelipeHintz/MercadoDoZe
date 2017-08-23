using Mercado_do_zé.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mercado_do_zé.ViewModels
{
	public class RandomMovieViewModel
	{
		public Produto Produto { get; set; }

		public List<Cliente> Clientes { get; set; }
	}
}