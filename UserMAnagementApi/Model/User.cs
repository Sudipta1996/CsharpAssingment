using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace UserMAnagementApi.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public string Name { get; set; }
        [Required]
        [StringLength(10)]
        public string Contact { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Address { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
    }
}
