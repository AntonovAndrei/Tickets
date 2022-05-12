using Tickets.Core.Entities;

namespace Tickets.Data.Repositories
{
    public interface ISegmentRepository
    {
        public IEnumerable<Segment> GetList();
        public int Create(Segment segment);
        public int Delete(int id);
        public int Refund(Segment segment);
    }
}
