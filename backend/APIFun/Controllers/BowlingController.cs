using APIFun.Data;
using APIFun.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIFun.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;
        public BowlingController(IBowlingRepository temp)
        {
            _bowlingRepository = temp;

        }
        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var bowlerData = _bowlingRepository.Bowlers.ToArray();

            return bowlerData;
        }
    }
}
