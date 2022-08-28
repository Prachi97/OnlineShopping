using Microsoft.EntityFrameworkCore;
using OnlineShopping.API.Model;

namespace OnlineShpping.API.Data
{
    public class OnlineShoppingDbContext :DbContext
    {
        public OnlineShoppingDbContext(DbContextOptions<OnlineShoppingDbContext> options): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }    
        public DbSet<Cart> CartList { get; set; }
    }
}
