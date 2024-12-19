﻿using CSharpEducation301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEducation301.DataAccessLayer.Context
{
    public class CampContext:DbContext
    {
        // Tablo ismi: Categories (çoğul olsun)
        // Sınıf: Category (tekil olsun)
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
