﻿using System;
using System.Collections.Generic;

namespace MyPortfolio.Models
{
    public partial class TblAbout
    {
        public int AboutId { get; set; }
        public string? Title { get; set; }
        public string? Header { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}
