using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GBKingdom.Models
{
    public class GBKingdomContext : DbContext
    {
        public GBKingdomContext()
        {

        }
        public virtual DbSet<Gummi> Gummies { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GBKingdom;integrated security=True");
        }
        public GBKingdomContext(DbContextOptions<GBKingdomContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
