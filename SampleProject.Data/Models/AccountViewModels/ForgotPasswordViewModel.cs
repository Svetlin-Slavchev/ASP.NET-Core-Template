using System.ComponentModel.DataAnnotations;

namespace SampleProject.Data.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
