using Microsoft.EntityFrameworkCore;

namespace PizzaAPI.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PizzaModel> Pizzas { get; set; }
        public DbSet<SuggestedPizzaModel> SuggestedPizzas { get; set; }
        public DbSet<Comments> Comments { get; set; }
    }
}