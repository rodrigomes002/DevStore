using DevStore.API.Models;
using DevStore.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DevStore.API.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ApiProducts : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ApiProducts(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }


        [HttpGet]
        public ActionResult<List<Product>> List()
        {
            try
            {
                var products = this._productRepository.List();
                return Ok(products);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
