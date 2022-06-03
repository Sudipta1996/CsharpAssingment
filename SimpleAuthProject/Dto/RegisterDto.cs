using System;
using System.Text.Json.Serialization;

namespace pharmacyManagementWebApiservice.Dto
{
    public class RegisterDto
    {
        public string UserName { get; set; }
        public string Contact { get; set; }
        public string UserAddress { get; set; }
        public string Email { get; set; }
        public string UserPassword { get; set; }
        
    }
}
