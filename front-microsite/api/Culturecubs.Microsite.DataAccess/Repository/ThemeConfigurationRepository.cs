using Culturecubs.Microsite.DataAccess.DataContext;
using Culturecubs.Microsite.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Culturecubs.Microsite.DataAccess.Repository
{
    public class ThemeConfigurationRepository : IThemeConfigurationRepository
    {
        private readonly ApplicationDbContext _ctx;
        public ThemeConfigurationRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<ThemeConfiguration> GetThemeByTenantId(Guid tenantId)
        {
            var themeConfig = await _ctx.ThemeConfigurations.Where(x => x.TenantId == tenantId).FirstOrDefaultAsync();

            return themeConfig ?? new ThemeConfiguration();
        }
    }
}
