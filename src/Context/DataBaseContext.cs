using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIStock.src.Entities;

namespace APIStock.src.Context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        public DbSet<Product> Products{get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().HasKey(key => key.ID);
        }
    }
}