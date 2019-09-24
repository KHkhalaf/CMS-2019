using System;
using System.Collections.Generic;
using System.Text;
using CMS2019.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CMS2019.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<CMS2019.Models.ApplicationUser> ApplicationUser { get; set; }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }


    }
}

