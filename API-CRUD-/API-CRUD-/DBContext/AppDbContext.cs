using API_CRUD_.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API_CRUD_.DBContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<ControleVenda> ControleVenda { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Estoque> Estoque { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder.UseInMemoryDatabase("MyInMemoryDatabase"));
        //}
    }
}
