using System.ComponentModel.DataAnnotations;

namespace Restaurant_Website.ViewModels
{
    public class RegisterViewModel
    {
        //Data annotations for validation
        public string UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password is not matching.")]
        public string ConfirmPassword { get; set; }
    }
}
