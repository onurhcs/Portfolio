﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}