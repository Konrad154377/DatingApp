using System.ComponentModel.DataAnnotations;
namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "You must specify password beetwen 5 and 15 charakters")]
        public string Password { get; set; }
        
    }
}