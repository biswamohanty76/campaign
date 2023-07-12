using Culturecubs.Microsite.DataAccess.DataContext;
using Culturecubs.Microsite.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Culturecubs.Microsite.DataAccess.Repository
{
    public class TenantContestRepository : ITenantContestRepository
    {
        private readonly ApplicationDbContext _ctx;
        public TenantContestRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<List<Contest>> GetContestsByTenantId(Guid tenantId)
        {
            var contests = await _ctx.Contests
                        .Include(c => c.Tabs)
                        .Where(x => x.TenantId == tenantId)
                        .ToListAsync();
            return contests;
        }
    }
}
