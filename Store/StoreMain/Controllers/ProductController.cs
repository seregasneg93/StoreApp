using Microsoft.AspNetCore.Mvc;
using StoreData.Entyties;
using StoreServices.Interface;

namespace StoreMain.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ReceiveAllProduct()
        {
            List<Product> collecionsEmp = await _productRepository.ReceiveAllProductReposutoryAsync();

            return Ok(collecionsEmp);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            string resAddProduct = await _productRepository.AddProductAsync(product);

            return Ok(resAddProduct);
        }

        [HttpPut]
        public async Task<IActionResult> ChangeProduct(Product product)
        {

            string resAddProduct = await _productRepository.ChangeProductAsync(product);

            return Ok(resAddProduct);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> ChangeProduct(int id)
        {

            string resAddProduct = await _productRepository.DeleteProductAsync(id);

            return Ok(resAddProduct);
        }
    }
}
