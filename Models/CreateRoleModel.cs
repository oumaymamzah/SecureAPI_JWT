using System.ComponentModel.DataAnnotations;

namespace SecureAPI_JWT.Models
{
    public class CreateRoleModel
    {
        [Required]

        public string RoleName { get; set; }
      
    }
}