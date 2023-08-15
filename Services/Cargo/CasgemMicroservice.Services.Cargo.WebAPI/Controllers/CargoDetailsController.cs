using CasgemMicroservice.Services.Cargo.Business.Abstract;
using CasgemMicroservice.Services.Cargo.Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.Services.Cargo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoDetailsController : ControllerBase
    {
        private readonly ICargoDetailService _cargoDetailService;

        public CargoDetailsController(ICargoDetailService cargoDetailService)
        {
            _cargoDetailService = cargoDetailService;
        }
        [HttpGet]
        public IActionResult CargoDetailList()
        {
            var values = _cargoDetailService.TGetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult CargoDetailGet(int id)
        {
            var value = _cargoDetailService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CargoDetailCreate(CargoDetail cargoDetail)
        {
            _cargoDetailService.TInsert(cargoDetail);
            return Ok("Kargo Detayı Eklendi");
        }
        [HttpPut]
        public IActionResult CargoDetailUpdate(CargoDetail cargoDetail)
        {
            _cargoDetailService.TUpdate(cargoDetail);
            return Ok("Kargo Detayı Güncellendi");
        }
        [HttpDelete]
        public IActionResult CargoDetailDelete(CargoDetail cargoDetail)
        {
            _cargoDetailService.TDelete(cargoDetail);
            return Ok("Kargo Detayı Silindi");
        }
    }
}
