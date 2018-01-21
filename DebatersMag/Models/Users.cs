using System;
using System.Collections.Generic;

namespace DebatersMag.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime? Dob { get; set; }
        public string Interests { get; set; }
        public string Country { get; set; }
        public int? Phone { get; set; }
        public string RecoveryEmail { get; set; }
    }
}
