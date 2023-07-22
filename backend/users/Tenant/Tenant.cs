
using System.ComponentModel.DataAnnotations.Schema;

namespace CCubAPI.Tenants
{
    [Table("Tenant", Schema = "Admin")]
    public class Tenant
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }
        public string URL { get; set; }
        public string EmailId { get; set; }

        public string? Contact { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool IsActive { get; set; }



    }
}
