﻿using System;

namespace OpenHAB.Core
{
    public class OpenHABException : Exception
    {
        public OpenHABException(string message) : base(message)
        {
        }

        public OpenHABException(string message, Exception exception)
            :base(message, exception)
        {
            
        }
    }
}