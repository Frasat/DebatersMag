using System;
using System.Collections.Generic;

namespace DebatersMag.Models
{
    public partial class Magazine
    {
        public int ArticeiId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Category { get; set; }
        public int? PhoneNo { get; set; }
        public string SentArticle { get; set; }
        public DateTime? SentDate { get; set; }
    }
}
