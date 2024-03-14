namespace Mission10_shaw.Data
{
    public interface IBowlingLeagueRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }

        IEnumerable<Bowler> GetBowlersForMarlinsAndSharks();
        
    }
}
