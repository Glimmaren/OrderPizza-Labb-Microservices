using Microsoft.EntityFrameworkCore;
using OrderHandler.Models;

namespace OrderHandler.Data
{
    public class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public OrderContext(DbContextOptions opt) : base(opt)
        {
            
        }
    }
}
