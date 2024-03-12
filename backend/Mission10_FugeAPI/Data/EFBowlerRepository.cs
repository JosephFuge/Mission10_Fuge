
namespace Mission10_FugeAPI
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlerContext _bowlerContext;
        
        public EFBowlerRepository(BowlerContext tempContext) {
            _bowlerContext = tempContext;
        }
        public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers;
    }
}