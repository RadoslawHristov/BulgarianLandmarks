using My_Web_Project_LandMarks_.Core.Constants;
using System.ComponentModel.DataAnnotations;

namespace My_Web_Project_LandMarks_.Core.Models
{
    public class RegisterViewModel
    {

        [Required]
        [StringLength(GlobalConstant.UserConstant.UserNameMaxLenght,
            MinimumLength =GlobalConstant.UserConstant.UserNameMinLenght)]
        public string UserName { get; set; } = null!;


        [Required]
        [StringLength(GlobalConstant.UserConstant.FirstNameMaxLenght,
            MinimumLength =GlobalConstant.UserConstant.FirstNameMinLenght)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(GlobalConstant.UserConstant.LastNameMaxLenght,
            MinimumLength =GlobalConstant.UserConstant.LastNameMinLenght)]
        public string LastName { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(GlobalConstant.UserConstant.PassworMaxLenght,
            MinimumLength = GlobalConstant.UserConstant.PassworMinLenght)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Required]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;
    }
}
