using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culturecubs.Microsite.DataAccess.Models
{

    [Table("tenant_contest")]
    public class TenantContest
    {
        public virtual int Id { get; set; }
        public virtual Guid TenantId { get; set; }
        public virtual List<Contest>? Contests { get; set; }
    }
}
