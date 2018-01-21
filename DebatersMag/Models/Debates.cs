using System;
using System.Collections.Generic;

namespace DebatersMag.Models
{
    public partial class Debates
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Topic { get; set; }
        public string DebateLink { get; set; }
        public string UserName { get; set; }
    }
}
