using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.MODELS.Entities;

namespace WebApplication1.MODELS
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) :base(options) { }
        public DbSet<UsersEntity> UsersEntity { get; set; }
        public DbSet<IdTypeIdentity> IdTypeIdentity { get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
