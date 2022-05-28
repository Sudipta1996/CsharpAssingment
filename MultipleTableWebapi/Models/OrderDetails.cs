using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MultipleTableWebapi.Models
{
    public class OrderDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [Required]
        public string DrugId { get; set; }
         [Required]
        public int Quantity { get; set; }
        [Required]
        public int Payment { get; set; }
        [Required]
        public int Total { get; set; }  
    }
}
