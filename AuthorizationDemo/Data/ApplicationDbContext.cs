using AuthorizationDemo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorizationDemo.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>      // <ApplicationUser> important here if using custom user class
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)       // not really sure why microsoft docs said to add this
        {
            base.OnModelCreating(builder);
        }

        public DbSet<TodoItem> Items { get; set; }  // tells Entity that you want to store TodoItem entities in a table called Items
    }
}
