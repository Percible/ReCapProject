using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        IBrandService _brandService;


        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _brandService.GetAll();

            if (result.IsSuccess)
            {
                return Ok(result);
            }

            return BadRequest(result);


        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _brandService.GetById(id);

            if (result.IsSuccess)
            {
                return Ok(result);
            }

            return BadRequest(result);


        }

        [HttpGet("add")]
        public IActionResult Add(Brand brand)
        {
            var result = _brandService.Add(brand);

            if (result.IsSuccess)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpGet("update")]
        public IActionResult Update(Brand brand)
        {
            var result = _brandService.Update(brand);

            if (result.IsSuccess)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpGet("delete")]
        public IActionResult Delete(Brand brand)
        {
            var result = _brandService.Delete(brand);

            if (result.IsSuccess)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }
    }
}
