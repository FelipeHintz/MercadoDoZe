﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mercado_do_zé.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFree { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}