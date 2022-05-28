using System.Text.Json.Serialization;

namespace RelationShipsTable
{
    public class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public int    price { get; set; }
        [JsonIgnore]
        public User ProductUser { get; set; }
        public int UserId { get; set; }
        public Order Orders { get; set; }
       

    }
}
