using Business.Abstract;
using Core.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentatition.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpPost("add")]
        public IActionResult Add(Categories categories)
        {
            var response = _categoryService.Add(categories);
            if (response.Success) return Ok(response);
            return BadRequest(response);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Categories categories)
        {
            var response = _categoryService.Delete(categories);
            if (response.Success) return Ok(response);
            return BadRequest(response);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var response = _categoryService.GetAll();
            if (response.Success) return Ok(response);
            return BadRequest(response);
        }
    }
}
