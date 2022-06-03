using System;
using System.Collections.Generic;

#nullable disable

namespace pharmacyManagementWebApiservice.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedBy { get; set; }=DateTime.Now;
        public DateTime ModifedDate { get; set; }= DateTime.Now;
        public DateTime ModifedBy { get; set; }=DateTime.Now ;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public virtual OrderDetail OrderNavigation { get; set; }
        public virtual UserDetail User { get; set; }
    }
}
