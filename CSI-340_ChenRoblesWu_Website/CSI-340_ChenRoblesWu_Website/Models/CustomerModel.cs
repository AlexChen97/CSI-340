﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSI_340_ChenRoblesWu_Website.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

    }
}
