﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DebatersMag.Models
{
    public partial class Events
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public DateTime End { get; set; }
        public DateTime Start { get; set; }
        public string Text { get; set; }
    }
}
