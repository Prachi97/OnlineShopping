using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.API.Model;
using OnlineShopping.API.Repositories;

namespace OnlineShopping.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductRepository _repo;
        public ProductController(IProductRepository repo)
        {
            _repo =     repo;
        }

        [HttpGet]
        public IActionResult GetAllProductsByCategory(string category)
        {

            //var products =  _repo.GetAll();
            //return Ok(products);
            if (!string.IsNullOrEmpty(category))
            {
                var selectProducts = _repo.GetAll(category);
                selectProducts.OrderByDescending(x => x.Price);
                return Ok(selectProducts);
            }
            return Ok();
        }
    }
}
