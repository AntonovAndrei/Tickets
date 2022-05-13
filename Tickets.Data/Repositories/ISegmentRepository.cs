using Tickets.Core.Entities;

namespace Tickets.Data.Repositories
{
    public interface ISegmentRepository
    {
        public Task<IEnumerable<Segment>> GetListAsync();
        public Task<int> CreateAsync(Segment segment);
        public Task<int> DeleteAsync(int id);
        public Task<int> RefundAsync(Segment segment);
    }
}
