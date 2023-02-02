using Microsoft.AspNetCore.Mvc;
using Vehicle.Models;
using Vehicle.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vehicle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IScopedService _scopedService;

        public BusController(IScopedService scopedService)
        {
            this._scopedService = scopedService;
        }

        // GET: api/<CarController>
        [HttpGet]
        [Route("GetBus")]
        public IEnumerable<Bus> Get()
        {
            return _scopedService.GetBusList();
        }
        [HttpGet]
        [Route("GetBusByColor")]
        public IEnumerable<Bus> GetByColor(string color)
        {
            return (IEnumerable<Bus>)_scopedService.GetBusListByColor(color);
        }
    }
}
