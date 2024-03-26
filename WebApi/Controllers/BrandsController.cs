using Businees.Abstracts;
using Businees.Dtos.Request;
using Businees.Dtos.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {

        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]
        public IActionResult Get(CreateBrandRequest createBrandRequest) {
            CreatedBrandResponse response  = 
                _brandService.Get(createBrandRequest);
            return Ok(response);
        
        }
        [HttpGet]
        public IActionResult Get() {
            return Ok(_brandService.GetAll());
        }
    }
}
