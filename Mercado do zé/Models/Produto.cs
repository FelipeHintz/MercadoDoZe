﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mercado_do_zé.Models
{
    [Table("dbo.Produtos")]
	public class Produto
	{

		public int Id { get; set; }
		public string Nome { get; set; }

        public string Descrição { get; set; }

        public int Quantidade { get; set; }

        public double Valor { get; set; }

        public string EnderecoImagem { get; set; }

	}
}