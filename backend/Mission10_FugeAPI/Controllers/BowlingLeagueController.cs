using Microsoft.AspNetCore.Mvc;

namespace Mission10_FugeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BowlingLeagueController : ControllerBase
    {

        IBowlerRepository _bowlerRepo;

        public BowlingLeagueController(IBowlerRepository tempBowlerRepo)
        {
            _bowlerRepo = tempBowlerRepo;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            return _bowlerRepo.Bowlers(["Marlins", "Sharks"]).ToArray();
        }
    }
}
