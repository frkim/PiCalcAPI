using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using Utils;

namespace PiCalcAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstimatePiController : ControllerBase
    {
        
        private readonly ILogger<EstimatePiController> _logger;

        public EstimatePiController(ILogger<EstimatePiController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetEstimatePi")]
        public double Get(int iterations = 1000000)
        {
            double pi = MathUtils.EstimatePi();
            return pi;
        }
    }
}
