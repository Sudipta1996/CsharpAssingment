using System;
using System.Collections.Generic;

#nullable disable

namespace pharmacyManagementWebApiservice.Models
{
    public partial class OrderDetail
    {
        public OrderDetail()
        {
            Orders = new HashSet<Order>();
        }

        public int OrderId { get; set; }
        public int? DrugId { get; set; }
        public int? Quantity { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public DateTime? ModifedDate { get; set; }=DateTime.Now;
        public DateTime? ModifedBy { get; set; }=DateTime.Now;
        public DateTime CreatedBy { get; set; } = DateTime.Now;
        public decimal? OrderPrice { get; set; }
        public DateTime? OrderPickedUp { get; set; }

        public virtual DrugDetail Drug { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
