using System;
using System.Collections.Generic;

#nullable disable

namespace pharmacyManagementWebApiservice.Models
{
    public partial class SupplierDetail
    {
        public SupplierDetail()
        {
            DrugDetails = new HashSet<DrugDetail>();
        }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierContact { get; set; }
        public string SupplierEmail { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public DateTime? ModifedDate { get; set; }=DateTime.Now;
        public DateTime? ModifedBy { get; set; } = DateTime.Now;
        public DateTime CreatedBy { get; set; } = DateTime.Now;

        public virtual ICollection<DrugDetail> DrugDetails { get; set; }
    }
}
