using Business.Abstract;
using Core.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentatition.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchListController : ControllerBase
    {
        private readonly IWatchListService _watchListService;

        public WatchListController(IWatchListService watchListService)
        {
            _watchListService = watchListService;
        }

        [HttpPost("add")]
        public IActionResult Add(WatchList watchList)
        {
            var response = _watchListService.Add(watchList);
            if (response.Success) return Ok(response);
            return BadRequest(response);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(WatchList watchList)
        {
            var response = _watchListService.Delete(watchList);
            if (response.Success) return Ok(response);
            return BadRequest(response);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var response = _watchListService.GetAll();
            if (response.Success) return Ok(response);
            return BadRequest(response);
        }
    }
}
