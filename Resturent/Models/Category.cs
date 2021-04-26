using System;
using System.Collections.Generic;

#nullable disable

namespace Resturent.Models
{
    public partial class Category
    {
        public Category()
        {
            Items = new HashSet<Item>();
        }

        public long CategoryId { get; set; }
        public long? UserId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public bool? Status { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? EDate { get; set; }
        public DateTime? MDate { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
