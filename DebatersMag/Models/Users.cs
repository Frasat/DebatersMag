using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DebatersMag.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public DateTime? Dob { get; set; }
        public string Interests { get; set; }
        public string Country { get; set; }
        public int? Phone { get; set; }
        public string RecoveryEmail { get; set; }
    }
}
