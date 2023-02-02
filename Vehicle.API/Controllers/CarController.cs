using Microsoft.AspNetCore.Mvc;
using Vehicle.Models;
using Vehicle.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vehicle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IScopedService _scopedService;

        public CarController(IScopedService scopedService)
        {

            this._scopedService = scopedService;
        }

        // GET: api/<CarController>
        [HttpGet]
        [Route("GetCar")]
        public IEnumerable<Car> Get()
        {
            return _scopedService.GetCarList();
        }
        [HttpGet]
        [Route("GetCarByColor")]
        public IEnumerable<Car> GetByColor(string color)
        {
            return (IEnumerable<Car>)_scopedService.GetCarListByColor(color);
        }

        

        // POST api/<CarController>
        [HttpPost]
        [Route("ChangeHeadLight")]

        public IEnumerable<string> Post([FromBody] int id)
        {
            return _scopedService.ChangeCarHeadLight(id);
        }

        

        // DELETE api/<CarController>/5
        [HttpDelete]
        [Route("DeleteCar")]

        public IEnumerable<string> Delete(int id)
        {
            return _scopedService.DeleteCar(id);
        }
    }
}
