using System.Collections.Concurrent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dotNetReactWebSite.Entities;

namespace dotNetReactWebSite.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}