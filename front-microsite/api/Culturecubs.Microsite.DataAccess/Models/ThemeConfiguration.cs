using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culturecubs.Microsite.DataAccess.Models
{

    [Table("theme_configuration")]
    public class ThemeConfiguration
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual Guid TenantId { get; set; }
        public virtual string? Background { get; set; }
        public virtual string? Surface { get; set; }
        public virtual string? Primary { get; set; }
        public virtual string? PrimaryDarken1 { get; set; }
        public virtual string? Secondary { get; set; }
        public virtual string? SecondaryDarken1 { get; set; }
        public virtual string? Error { get; set; }
        public virtual string? Info { get; set; }
        public virtual string? Success { get; set; }
        public virtual string? Warning { get; set; }
        public virtual bool IsDark { get; set; }
        public virtual string? TenantIcon { get; set; }
        public virtual string? TenatLogo { get; set; }
    }
}
