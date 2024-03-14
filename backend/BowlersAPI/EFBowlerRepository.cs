using BowlersAPI.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace BowlersAPI.Data
{
    // implementation of the interface
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlerContext _bowlerContext;
        public EFBowlerRepository(BowlerContext bowlerContext)
        {
            _bowlerContext = bowlerContext;
        }

        //IQueryable<Bowler> IBowlerRepository.Bowlers => throw new NotImplementedException();

        //IQueryable<Team> IBowlerRepository.Teams => throw new NotImplementedException();

        public IQueryable<Bowler> Bowlers => _bowlerContext.Bowlers;
        public IQueryable<Team> Teams => _bowlerContext.Teams;

        public IEnumerable<BowlerInfo> GetInfo()
        {
            var query = (from bowler in _bowlerContext.Bowlers
                        join team in _bowlerContext.Teams
                        on bowler.TeamId equals team.TeamId
                        where team.TeamName == "Marlins" || team.TeamName == "Sharks"
                        select new BowlerInfo()
                        {
                            BowlerId = bowler.BowlerId,
                            BowlerFirstName = bowler.BowlerFirstName,
                            BowlerMiddleInit = bowler.BowlerMiddleInit,
                            BowlerLastName = bowler.BowlerLastName,
                            TeamId = team.TeamId,
                            TeamName = team.TeamName,
                            BowlerAddress = bowler.BowlerAddress,
                            BowlerCity = bowler.BowlerCity,
                            BowlerState = bowler.BowlerState,
                            BowlerZip = bowler.BowlerZip,
                            BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                        }).ToList();
            return query;

        }
    }
}
