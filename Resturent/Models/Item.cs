using System;
using System.Collections.Generic;

#nullable disable

namespace Resturent.Models
{
    public partial class Item
    {
        public long ItemId { get; set; }
        public string ItemName { get; set; }
        public long? CategoryId { get; set; }
        public long? ItemPrice { get; set; }

        public virtual Category Category { get; set; }
    }
}
