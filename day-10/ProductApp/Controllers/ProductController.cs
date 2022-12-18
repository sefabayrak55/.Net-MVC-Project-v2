using Entities.Models;
using Entities.RequestParameters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using Repositories.EFCore;
using Services.Contracts;

namespace ProductApp.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public ProductController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IActionResult Index([FromQuery] ProductRequestParameters p)
        {
            var products = _serviceManager.ProductService.GetAllProducts(p);
            return View("Index",products);
        }

        public IActionResult GetOneProduct(int id)
        {
            var product = _serviceManager.ProductService.GetOneProductById(id);
            return View("GetOneProduct", product);
        }

        public IActionResult GetAllProductsByCategoryId(int id)
        {
            var products = _serviceManager.ProductService.GetAllProductsByCategoryId(id);

            return View("Index",products);
        }
    }
}
