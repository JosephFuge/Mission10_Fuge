namespace Mission10_FugeAPI
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> Bowlers(String[] searchTeams);
    }
}