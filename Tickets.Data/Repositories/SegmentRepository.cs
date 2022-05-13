using Microsoft.Extensions.Configuration;
using Tickets.Core.Entities;

namespace Tickets.Data.Repositories
{
    public class SegmentRepository : ISegmentRepository
    {
        private string _connectionString;

        public SegmentRepository(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        public Task<int> CreateAsync(Segment segment)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Segment>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> RefundAsync(Segment segment)
        {
            throw new NotImplementedException();
        }
    }
}
