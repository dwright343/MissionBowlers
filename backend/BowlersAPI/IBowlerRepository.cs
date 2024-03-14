using BowlersAPI.Data;
using BowlersAPI.Models;

namespace BowlersAPI.Data
{
    // generic version of an EFRepository.
    public interface IBowlerRepository // this it the rules for the template. dictates structure of our class.
    {
        IQueryable<Bowler> Bowlers { get; } // IEnumerable is just a list rather than IQueryable
        IQueryable<Team> Teams { get; }
        IEnumerable<BowlerInfo> GetInfo();
    }
}
