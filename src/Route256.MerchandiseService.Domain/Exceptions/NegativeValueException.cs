﻿using System;

namespace Route256.MerchandiseService.Domain.Exceptions
{
    public sealed class NegativeValueException : Exception
    {
        public NegativeValueException(string message) : base(message)
        {
            
        }
        
        public NegativeValueException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}