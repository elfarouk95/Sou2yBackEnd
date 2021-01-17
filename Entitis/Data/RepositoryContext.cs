using System;
using System.Collections.Generic;
using Entitis.Models;
using Microsoft.EntityFrameworkCore;

namespace Entitis.Data
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options ) : base (options)
        {
        }

        public DbSet<Product> products { get; set; }

        public DbSet<Category> categories { get; set; }

        public DbSet<Customer> customers { get; set; }

        public DbSet<Order> orders { get; set; }

        public DbSet<OrderItem> orderItems { get; set; }



    }
}
