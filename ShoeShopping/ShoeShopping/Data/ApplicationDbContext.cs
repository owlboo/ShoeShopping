using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoeShopping.Models;

namespace ShoeShopping.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CategoryProduct> CategoryProducts { get; set; }
        public DbSet<ProductTags> ProductTags { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
