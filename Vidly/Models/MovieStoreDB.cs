﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MovieStoreDB : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}