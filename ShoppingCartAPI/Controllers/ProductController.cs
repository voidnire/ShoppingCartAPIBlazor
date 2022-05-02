using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartAPI.Repositories.Contracts;
using ShoppingCart.Models.DTOs;
using ShoppingCartAPI.Extensions;

namespace ShoppingCartAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository; //passed via dependency injection
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()// IEnumerable =>parameter for returning requested data
        {
            try//double tab/this method return an ienumerable collection of type project assynchronously
            {
                var products = await this.productRepository.GetItems();
                var productCategories = await this.productRepository.GetCategories();

                if (products == null || productCategories == null)
                {
                    return NotFound();
                }
                else
                {
                    var productDtos = products.ConvertToDto(productCategories);
                    return Ok(productDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                          "Error retrieving data from the database 😑😑");
            }
        }
    } 

}
