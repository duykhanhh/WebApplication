using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Utilities.Exceptions
{
    public class WebApplicationException : Exception
    {
        public WebApplicationException()
        {
        }

        public WebApplicationException(string message)
            : base(message)
        {
        }

        public WebApplicationException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
