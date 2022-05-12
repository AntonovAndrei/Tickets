using Tickets.Core.Entities;

namespace Tickets.Data.Repositories
{
    public class SegmentRepository : ISegmentRepository
    {
        private readonly TicketsDbContext _db;
        public SegmentRepository(TicketsDbContext db)
        {
            _db = db;
        }

        public int Create(Segment segment)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Segment> GetList()
        {
            throw new NotImplementedException();
        }

        public int Refund(Segment segment)
        {
            throw new NotImplementedException();
        }
    }
}
