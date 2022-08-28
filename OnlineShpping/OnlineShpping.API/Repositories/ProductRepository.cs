using OnlineShopping.API.Model;
using OnlineShpping.API.Data;

namespace OnlineShopping.API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly OnlineShoppingDbContext _dbConetxt;
        public ProductRepository(OnlineShoppingDbContext dbContext)
        {
            _dbConetxt = dbContext;
        }
        public IEnumerable<Product> GetAll(string category)
        {
          List<Product> products = new List<Product>();
          foreach(Product product in _dbConetxt.Products)
            {
                if(product.Category == category)
                {
                    products.Add(product);
                }
                
            }
           return  products;
        }
    }
}
