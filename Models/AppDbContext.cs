using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TinyRobotsTools.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    Owner = "Mary",
                    CupSize = CupSize.Twenty,
                    CupStyle = CupStyle.Slim,
                    GlitterName = GlitterName.green,
                    Status = Status.Decorated
                },
                new Order
                {
                    Id = 2,
                    Owner = "John",
                    CupSize = CupSize.Thirty,
                    CupStyle = CupStyle.Standard,
                    GlitterName = GlitterName.blue,
                    Status = Status.Ordered
                },
                new Order
                {
                    Id = 3,
                    Owner = "Heather",
                    CupSize = CupSize.Fourty,
                    CupStyle = CupStyle.Bottle,
                    GlitterName = GlitterName.silver,
                    Status = Status.Epoxy1
                }

                );
        }
    }
}
