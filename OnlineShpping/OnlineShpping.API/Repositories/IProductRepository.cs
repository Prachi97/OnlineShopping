using OnlineShopping.API.Model;

namespace OnlineShopping.API.Repositories
{
    public interface IProductRepository
    {
       IEnumerable<Product> GetAll(string category);
    }
}
