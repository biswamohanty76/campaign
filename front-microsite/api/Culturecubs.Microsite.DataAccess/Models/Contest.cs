using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culturecubs.Microsite.DataAccess.Models
{

    [Table("contest")]
    public class Contest
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual Guid TenantId { get; set; }
        public virtual string? Title { get; set; }
        public virtual string? Description { get; set; }
        public virtual string? Category { get; set; }
        public virtual string? Location { get; set; }
        public virtual string? Experience { get; set; }
        public virtual string? Image { get; set; }
        public virtual DateTime RegistrationEndDate { get; set; }
        public virtual string? Summary { get; set; }
        public ICollection<ContestTab>? Tabs { get; set; }
    }
}
