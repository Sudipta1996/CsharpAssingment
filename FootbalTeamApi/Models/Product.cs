using System;
using System.Collections.Generic;

namespace FootbalTeamApi.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int DisplayOrder { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
