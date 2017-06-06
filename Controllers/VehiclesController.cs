using AutoMapper;
using dotnetcore_sql_angular.Resources;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore_sql_angular.Controllers
{
    [Route("/api/vehicles")]
    public class VehiclesController : Controller
    {
        private readonly IMapper mapper;

        public VehiclesController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        [HttpPost]
        public IActionResult CreateVehicle([FromBody]VehicleResource vehicleResource)
        {
            var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            return Ok(vehicleResource);
        }
    }
}