using BowlersAPI.Data;
using BowlersAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BowlersAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlerController(IBowlerRepository bowlersRepository)
        {
            _bowlerRepository = bowlersRepository;
        }
        [HttpGet]
        public IEnumerable<BowlerInfo> GetInfo()
        {
            var bowlerData = _bowlerRepository.GetInfo().ToList();
            return bowlerData;
        }

        //[HttpGet]
        //public IEnumerable<BowlerInfo> Get()
        //{
        //    var bowlerData = _bowlerRepository.Bowlers.Include("Teams")
        //        .OrderBy(x => x.BowlerId).ToArray();
        //    return bowlerData;
        //}
        //[HttpGet]
        //public IEnumerable<Team> Get()
        //{
        //    var teamData = _bowlerRepository.Teams.ToArray();
        //    return teamData;
        //}
    }
}
