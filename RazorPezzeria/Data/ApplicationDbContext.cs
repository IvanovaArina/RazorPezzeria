using Microsoft.EntityFrameworkCore;
using RazorPezzeria.Models;

namespace RazorPezzeria.Data
 
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders {  get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}
