using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Authentication.Model
{
    public class SignUp
    {
         
            
            [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfigPassword { get; set; }
        
    }

        
}

