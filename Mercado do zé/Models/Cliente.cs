using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mercado_do_zé.Models
{
    public class Cliente
    {

        public int Id { get; set; }
        public string Nome { get; set;}
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}