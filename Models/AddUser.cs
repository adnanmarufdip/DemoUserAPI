﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoUserAPI.Models
{
    public class AddUser
    {
        public string Name { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
