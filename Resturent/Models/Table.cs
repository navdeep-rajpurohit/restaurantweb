using System;
using System.Collections.Generic;

#nullable disable

namespace Resturent.Models
{
    public partial class Table
    {
        public long TableId { get; set; }
        public long? UserId { get; set; }
        public string TableName { get; set; }
        public string TableDesc { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? Status { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? EDate { get; set; }
        public DateTime? MDate { get; set; }
    }
}
