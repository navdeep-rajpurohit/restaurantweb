using System;
using System.Collections.Generic;

#nullable disable

namespace Resturent.Models
{
    public partial class Variation
    {
        public long VariationId { get; set; }
        public long? UserId { get; set; }
        public string VariationName { get; set; }
        public bool? Status { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? EDate { get; set; }
        public DateTime? MDate { get; set; }
    }
}
