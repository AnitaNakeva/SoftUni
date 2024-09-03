using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using ProductsApi.Data;
using ProductsApi.Services;
using System.Reflection;
using System.Text.Json;

namespace ProductsApi.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        /// <summary>
        /// Gets a list with all products.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET /api/aproducts
        ///     {
        ///     
        ///     }
        /// </remarks>
        /// <response code="200">Returns "OK" with a list of all products</response>
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return this.productService.GetAllProducts();
        }

        /// <summary>
        /// Gets a product by id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET /api/aproducts/{id}
        ///     {
        ///     
        ///     }
        /// </remarks>
        /// <response code="200">Returns "OK" with a list of all products</response>
        /// <response code="404">Returns "Not Found" when product with the given id does not exist</response>
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = this.productService.GetById(id);

            if (product == null) return NotFound();

            return product;
        }

        /// <summary>
        /// Creates a product.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/aproducts
        ///     {
        ///         "name":"Buba",
        ///         "description":"Sladka buba"
        ///     }
        /// </remarks>
        /// <response code="201">Returns "Created" with the created product</response>
        [HttpPost]
        public ActionResult<Product> PostProduct(Product product)
        {
            product = this.productService
                .CreateProduct(product.Name, product.Description);

            return CreatedAtAction(
                 nameof(GetProduct),
                 new { id = product.Id },
                 product
            );
        }

        /// <summary>
        /// Edits a product.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT /api/aproducts/{id}
        ///     {
        ///         "name":"Buba",
        ///         "description":"Sladka buba"
        ///     }
        /// </remarks>
        /// <response code="204">Returns "No Context"</response>
        /// <response code="400">Returns "Bad Request" when an invalid request is sent"</response>
        /// <response code="404">Returns "Not Found" when product with the given id does not exist</response>
        [HttpPut("{id}")]
        public IActionResult PutProduct(int id, Product product)
        {
            if (id != product.Id) return BadRequest();

            if (this.productService.GetById(id) == null) return NotFound();

            this.productService.EditProduct(id, product);

            return NoContent();
        }

        /// <summary>
        /// Edits a product partially.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PATCH /api/aproducts/{id}
        ///     {
        ///         "name":"BubaNew",
        ///     }
        /// </remarks>
        /// <response code="204">Returns "No Context"</response>
        /// <response code="404">Returns "Not Found" when product with the given id does not exist</response>
        [HttpPatch("{id}")]
        public IActionResult PatchProduct(int id, [FromBody] Product product)
        {
            if (this.productService.GetById(id) == null) return NotFound();

            this.productService.EditProductPartially(id, product);

            return NoContent();
        }

        /// <summary>
        /// Edits a product.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     DELETE /api/aproducts/{id}
        ///     {
        ///     
        ///     }
        /// </remarks>
        /// <response code="204">Returns "No Context"</response>
        /// <response code="404">Returns "Not Found" when product with the given id does not exist</response>
        [HttpDelete("{id}")]
        public ActionResult<Product> DeleteProduct(int id)
        {
            if (this.productService.GetById(id) == null) return NotFound();

            var product = this.productService.DeleteProduct(id);

            return product;
        }
    }
}
