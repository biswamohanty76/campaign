using Culturecubs.Microsite.DataAccess.DataContext;
using Culturecubs.Microsite.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culturecubs.Microsite.DataAccess.Repository
{

    public class CanidateRegistrationRepository : ICanidateRegistrationRepository
    {
        private readonly ApplicationDbContext _ctx;
        public CanidateRegistrationRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<bool> RegisterCanidate(CandidateRegistration candidate)
        {
            if (candidate != null)
            {
                _ctx.CandidateRegistration.Add(candidate);
                await _ctx.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
