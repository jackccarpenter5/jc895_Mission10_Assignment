using APIFun.DTOs;
using APIFun.Models;

namespace APIFun.Data
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<BowlerWithTeamDTO> GetAllBowlersWithTeams();
    }
}