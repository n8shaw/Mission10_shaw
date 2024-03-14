using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10_shaw.Data;

namespace Mission10_shaw.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlersController : ControllerBase
    {
        private IBowlingLeagueRepository _bowlingLeagueRepository;

        public BowlersController(IBowlingLeagueRepository temp)
        {
            _bowlingLeagueRepository = temp;
        }
       
        [HttpGet("marlins-sharks")]
        public IActionResult GetBowlersForMarlinsAndSharks()
        {
            var bowlers = _bowlingLeagueRepository.GetBowlersForMarlinsAndSharks();
            return Ok(bowlers);
        }



    }
}
