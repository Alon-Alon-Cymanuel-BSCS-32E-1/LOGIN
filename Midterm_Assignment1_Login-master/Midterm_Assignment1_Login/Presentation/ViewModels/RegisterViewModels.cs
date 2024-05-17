using System.ComponentModel.DataAnnotations;

namespace Midterm_Assignment1_Login.Presentation.ViewModels
{
    public class RegisterViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Username is required.")]
        public string Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirm Password is required.")]
        [Compare("Password", ErrorMessage = "PASSWORD IS NOT THE SAME!")]
        public string ConfirmPassword { get; set; }

    }
}
