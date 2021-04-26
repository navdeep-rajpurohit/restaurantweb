using System;
using System.Collections.Generic;

#nullable disable

namespace Resturent.Models
{
    public partial class PriceManagement
    {
        public long PriceId { get; set; }
        public long? UserId { get; set; }
        public long? ItemId { get; set; }
        public long? VariationId { get; set; }
        public long? AddOnId { get; set; }
        public long? VariationAmount { get; set; }
        public long? AddOnAmount { get; set; }
        public bool? Status { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? EDate { get; set; }
        public DateTime? MDate { get; set; }
    }
}
