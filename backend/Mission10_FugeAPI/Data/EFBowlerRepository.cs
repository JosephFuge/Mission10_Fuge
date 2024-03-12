
using Microsoft.EntityFrameworkCore;

namespace Mission10_FugeAPI
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlerContext _bowlerContext;
        
        public EFBowlerRepository(BowlerContext tempContext) {
            _bowlerContext = tempContext;
        }
        public IEnumerable<Bowler> Bowlers(String[] searchTeams) {
            return _bowlerContext.Bowlers.Include("Team").Where(b => searchTeams.Contains(b.Team.TeamName));
        }
    }
}