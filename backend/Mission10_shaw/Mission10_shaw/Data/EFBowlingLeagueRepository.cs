using Microsoft.EntityFrameworkCore;


namespace Mission10_shaw.Data
{
    public class EFBowlingLeagueRepository : IBowlingLeagueRepository
    {
        private BowlingLeagueContext _bowlerContext;

        public EFBowlingLeagueRepository(BowlingLeagueContext temp)
        {
            _bowlerContext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers;
        public IEnumerable<Team> Teams => _bowlerContext.Teams;

        public IEnumerable<Bowler> GetBowlersForMarlinsAndSharks()
        {
            return _bowlerContext.Bowlers
                .Include(b => b.Team) // Include the Team navigation property
                .Where(b => b.Team != null && (b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks"))
                .ToArray(); // Execute query and return as list
        }
    }
}
