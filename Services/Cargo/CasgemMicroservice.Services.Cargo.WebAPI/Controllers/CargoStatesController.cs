using CasgemMicroservice.Services.Cargo.Business.Abstract;
using CasgemMicroservice.Services.Cargo.Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.Services.Cargo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoStatesController : ControllerBase
    {
        private readonly ICargoStateService _cargoStateService;

        public CargoStatesController(ICargoStateService cargoStateService)
        {
            _cargoStateService = cargoStateService;
        }
        [HttpGet]
        public IActionResult CargoStateList()
        {
            var values = _cargoStateService.TGetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult CargoStateGet(int id)
        {
            var value = _cargoStateService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CargoStateCreate(CargoState cargoState)
        {
            _cargoStateService.TInsert(cargoState);
            return Ok("Kargo Durumu Eklendi");
        }
        [HttpPut]
        public IActionResult CargoStateUpdate(CargoState cargoState)
        {
            _cargoStateService.TUpdate(cargoState);
            return Ok("Kargo Durumu Güncellendi");
        }
        [HttpDelete]
        public IActionResult CargoStateDelete(CargoState cargoState)
        {
            _cargoStateService.TDelete(cargoState);
            return Ok("Kargo Durumu Silindi");
        }
    }
}
