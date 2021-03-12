using System;
using System.Collections.Generic;

#nullable disable

namespace Resturent.Models
{
    public partial class User
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public string EmailPass { get; set; }
        public string MobileNo { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? Status { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? EDate { get; set; }
        public DateTime? MDate { get; set; }
    }
}
