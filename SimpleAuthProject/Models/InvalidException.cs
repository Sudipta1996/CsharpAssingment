﻿using System;

namespace pharmacyManagementWebApiservice.Models
{
    public class InvalidException : Exception
    {
        public InvalidException(string message) : base(message)
        {
                
        }
    }
}
