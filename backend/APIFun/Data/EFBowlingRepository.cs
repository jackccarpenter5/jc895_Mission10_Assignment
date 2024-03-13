using APIFun.DTOs;
using APIFun.Models;
using Microsoft.EntityFrameworkCore;

namespace APIFun.Data
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _context;

        public EFBowlingRepository(BowlingLeagueContext temp)
        {
            _context = temp;
        }

        public IEnumerable<Bowler> Bowlers => _context.Bowlers;


        public IEnumerable<BowlerWithTeamDTO> GetAllBowlersWithTeams()
        {
            var bowlersWithTeams = _context.Bowlers
                .Include(b => b.Team)
                .Select(b => new BowlerWithTeamDTO
                {
                    Id = b.BowlerId,
                    FirstName = b.BowlerFirstName,
                    LastName = b.BowlerLastName,
                    MiddleInitial = b.BowlerMiddleInit,
                    Address = b.BowlerAddress,
                    City = b.BowlerCity,
                    State = b.BowlerState,
                    Zip = b.BowlerZip,
                    PhoneNumber = b.BowlerPhoneNumber,
                    TeamName = b.Team.TeamName
                }).ToList();

            return bowlersWithTeams;
        }


    }

}
