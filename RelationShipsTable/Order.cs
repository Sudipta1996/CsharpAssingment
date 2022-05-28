using System.Text.Json.Serialization;

namespace RelationShipsTable
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        [JsonIgnore]
        public Product Products  { get; set; }
        public int ProductId { get; set; }
    }
}
