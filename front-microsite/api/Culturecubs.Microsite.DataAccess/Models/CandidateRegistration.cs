using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culturecubs.Microsite.DataAccess.Models
{
    [Table("canidate")]
    public class CandidateRegistration
    {
        [Key]
        public int Id { get; set; }
        public string? Company { get; set; }
        public string? User { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? URL { get; set; }
        public string? Attachment { get; set; }
    }
}
