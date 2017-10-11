using Mercado_do_zé.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mercado_do_zé.ViewModels
{
    public class ClienteEditarViewModel
    {
        public Cliente Cliente { get; set; }

        public String Titulo
        {
            get
            {
                if (Cliente != null && Cliente.Id != 0) 
                {
                    return "Editar cliente";
                }
                else {
                    return "Cadastrar novo cliente";
                }
            }
        }
	}
}