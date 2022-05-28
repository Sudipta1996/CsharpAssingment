namespace RelationShipsTable
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public List<Product> Products { get; set; }
    }
}
