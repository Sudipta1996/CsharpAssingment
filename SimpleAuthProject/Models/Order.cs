using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace PharmacyManagementSystem.Models
{
    public partial class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Key]
        public int UserId { get; set; }
        public DateTime CreatedBy { get; set; } = DateTime.Now;
        public DateTime ModifedDate { get; set; } = DateTime.Now;
        public DateTime ModifedBy { get; set; } = DateTime.Now;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public virtual OrderDetail OrderNavigation { get; set; }
        public virtual UserDetail User { get; set; }
    }
}
