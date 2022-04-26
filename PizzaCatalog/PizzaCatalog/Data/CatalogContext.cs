using Microsoft.EntityFrameworkCore;
using PizzaCatalog.Controllers;

namespace PizzaCatalog.Data
{
    public class CatalogContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
        public CatalogContext(DbContextOptions opt) : base(opt)
        {
            
        }
    }
}
