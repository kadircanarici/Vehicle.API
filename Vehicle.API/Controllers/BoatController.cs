using Microsoft.AspNetCore.Mvc;
using Vehicle.Models;
using Vehicle.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vehicle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        private readonly IScopedService _scopedService;

        public BoatController(IScopedService scopedService)
        {
            this._scopedService = scopedService;
        }

        // GET: api/<CarController>
        [HttpGet]
        [Route("GetBoat")]
        public IEnumerable<Boat> Get()
        {
            return _scopedService.GetBoatList();
        }
        [HttpGet]
        [Route("GetBusByColor")]
        public IEnumerable<Boat> GetByColor(string color)
        {
            return (IEnumerable<Boat>)_scopedService.GetBoatListByColor(color);
        }
    }
}
