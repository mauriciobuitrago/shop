
namespace shop.Web.Controllers.API
{
    using Microsoft.AspNetCore.Mvc;
    using shop.Web.Data;

    [Route("api/[Controller]")]

    public class ProductsController : Controller

    {
        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            // envuelve el resultado en un JSON de los productos que tenemos.
            return Ok(this.productRepository.GetAllWithUsers());
        }
    }
}
