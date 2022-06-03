using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace pharmacyManagementWebApiservice.Models
{
    public partial class UserDetail
    {
        public UserDetail()
        {
            Orders = new HashSet<Order>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Contact { get; set; }
        public string UserAddress { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public DateTime? ModifedDate { get; set; }=DateTime.Now;
        public DateTime CreatedBy { get; set; } = DateTime.Now;
        public DateTime? ModifedBy { get; set; } = DateTime.Now;
        [JsonIgnore]
        public string UserPassword { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
