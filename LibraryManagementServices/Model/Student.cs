using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementServices.Model
{
    [Table("StudentTable")]
    public class Student
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
