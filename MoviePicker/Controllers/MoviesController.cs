using Business.Abstract;
using Core.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Presentatition.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            _service = service;
        }

        [HttpGet("all")]
        public IActionResult GetProductsWithCategory()
        {

            var response = _service.GetAll();
            if (response.Success) return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("getByCategory")]
        public IActionResult GetByCategory(int categoryId)
        {
            var response = _service.GetByCategoryId(categoryId);
            if (response.Success) return Ok(response);
            return BadRequest(response);
        }
        [HttpGet("getByImdb")]
        public IActionResult GetById(int Imdb)
        {
            var response = _service.GetByImdb(Imdb);
            if (response.Success) return Ok(response);
            return Ok(response);
        }
        [HttpPost("add")]
        public IActionResult Add(Movie movies)
        {
            var response = _service.Add(movies);
            if (response.Success) return Ok(response);
            return BadRequest(response);
        }
        [HttpPut("update")]
        public IActionResult Update(Movie movies)
        {
            var response = _service.Update(movies);
            if (response.Success) return Ok(response);
            return BadRequest(response);
        }
        [HttpDelete]
        public IActionResult Delete(Movie movies)
        {
            var response = _service.Delete(movies);
            if (response.Success) return Ok(response);
            return BadRequest(response);
        }
    }
}
