using ApiDay.BusinessLayer.Abstract;
using ApiDay.EntityLayer.Entities;
using ApiDay.WebApi.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDay.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _categoryService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            Category category = new Category()
            {
                CategoryName = createCategoryDto.CategoryName
            };
            _categoryService.TAdd(category);
            return Ok("Ekleme başarılı");
        }

        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            Category category = new Category()
            {
                CategoryName = updateCategoryDto.CategoryName,
                CategoryId = updateCategoryDto.CategoryId
            };
            _categoryService.TUpdate(category);
            return Ok("Güncelleme başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            _categoryService.TDelete(id);
            return Ok("Silme işlemi başarılı");
        }

        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            return Ok(value);
        }
    }
}
