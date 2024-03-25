using System.ComponentModel.DataAnnotations;

namespace BharatWTAPI.Models.DTO
{
    public class RegisterRequestDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        public string[] Roles { get; set; } 

    }
}
