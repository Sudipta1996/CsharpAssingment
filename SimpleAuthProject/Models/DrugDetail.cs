using System;
using System.Collections.Generic;

#nullable disable

namespace pharmacyManagementWebApiservice.Models
{
    public partial class DrugDetail
    {
        public DrugDetail()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int DrugId { get; set; }
        public string DrugName { get; set; }
        public int Quantity { get; set; }
        public decimal? Price { get; set; }
        public int? SupplierId { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public DateTime? ModifedDate { get; set; }=DateTime.Now;
        public DateTime? ModifedBy { get; set; }=DateTime.Now;
        public DateTime CreatedBy { get; set; }= DateTime.Now;
        public DateTime ExpiryDate { get; set; } 

        public virtual SupplierDetail Supplier { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
