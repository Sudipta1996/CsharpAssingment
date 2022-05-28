using PharmacyManagementSystem.Models;

namespace pharmacyManagementWebApiservice.Dto
{
    public class AddOrders
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        //public virtual OrderDetail OrderNavigation { get; set; }
        //public virtual UserDetail User { get; set; }
    }
}
