using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using CCubAPI.Tenants;
namespace CCubAPI.Tenants
{
    
    [Table("User", Schema = "Admin")]
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public string? Location { get; set; }
        
        public string UserSkillSet { get; set; }
        public string EmailId { get; set; }

        public string? Contact { get; set; }

        public long TenantId { get; set; }

        public int? RoleId { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        

    }

    public class Userlogin 
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }

    public class UserloginResponse: User
    {

        public string AccessToken { get; set; }
    }
}
