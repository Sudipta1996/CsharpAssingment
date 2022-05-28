namespace TeacherMangementCoreApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDate { get; set; }   = DateTime.Now;
    }
}
