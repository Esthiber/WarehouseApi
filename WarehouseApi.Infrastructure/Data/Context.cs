using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseApi.Core.Entities;

namespace WarehouseApi.Infrastructure.Data
{
    public class Contex : DbContext
    {
        public Contex(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Categorias> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Categorias>().HasData(SeedData.SeedCategorias.Get());
        }
    }
}
