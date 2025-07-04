using ApiDay.BusinessLayer.Abstract;
using ApiDay.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDay.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _productService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _productService.TAdd(product);
            return Ok("Ekleme başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            _productService.TDelete(id);
            return Ok("Silme başarılı");
        }

        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.TUpdate(product);
            return Ok("Güncelleme başarılı");
        }

        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            return Ok(_productService.TGetById(id));
        }
    }
}
