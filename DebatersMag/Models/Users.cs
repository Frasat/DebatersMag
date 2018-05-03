using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DebatersMag.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter User Name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
            "Numbers and special characters are not allowed in the name.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Enter User Name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
            "Numbers and special characters are not allowed in the name.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Enter User Name")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
      //  [RegularExpression(@"^.*(?=.*[!@#$%^&*\(\)_\-+=]).*$")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 8 and 255 characters", MinimumLength = 8)]
        public string Password { get; set; }
       // [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$)")]
        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 8 and 255 characters", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [System.ComponentModel.DisplayName("Date of Birth")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Dob { get; set; }
        public string Interests { get; set; }
        public string Country { get; set; }
       // [DataType(DataType.PhoneNumber)]
       // [Display(Name = "Phone Number")]
       // [Required(ErrorMessage = "Phone Number Required!")]
//[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public double phone { get; set; }
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string RecoveryEmail { get; set; }
    }
}
