﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLaptopSystem.Models
{
    public class ApplicationUser : User
    {
        public string Email { get; set; }
    }
}
