//using Microsoft.AspNetCore.Mvc;


//namespace WebApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CityController : ControllerBase
//    {
//        private readonly ICityService _cityService;

//        public CityController(ICityService cityService)
//        {
//            _cityService = cityService;
//        }

//        [HttpGet]
//        public async Task<IActionResult> GetAll()
//        {
//            var cities = await _cityService.GetAllAsync();
//            return Ok(cities);
//        }

//        [HttpGet("{id}")]
//        public async Task<IActionResult> GetById(int id)
//        {
//            var city = await _cityService.GetByIdAsync(id);
//            return Ok(city);
//        }

//        [HttpPost]
//        public async Task<IActionResult> Create(CityCreateDto cityCreateDto)
//        {
//            await _cityService.CreateAsync(cityCreateDto);
//            return StatusCode(201); // Created
//        }

//        [HttpPut]
//        public async Task<IActionResult> Update(CityEditDto cityEditDto)
//        {
//            await _cityService.UpdateAsync(cityEditDto);
//            return NoContent(); // 204
//        }

//        [HttpDelete("{id}")]
//        public async Task<IActionResult> Delete(int id)
//        {
//            await _cityService.DeleteAsync(id);
//            return NoContent(); // 204
//        }
//    }
//}