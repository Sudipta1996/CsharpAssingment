using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

#nullable disable

namespace PharmacyManagementSystem.Models
{
    public partial class UserDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Contact { get; set; }
        public string UserAddress { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public string UserPassword { get; set; }
        [JsonIgnore]
        public DateTime CreatedDate { get; set; }=DateTime.Now;
        [JsonIgnore]
        public DateTime? ModifedDate { get; set; }= DateTime.Now;
        [JsonIgnore]
        public DateTime CreatedBy { get; set; } = DateTime.Now;
        [JsonIgnore]
        public DateTime? ModifedBy { get; set; } = DateTime.Now;
    }
}
