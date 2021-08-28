using System;
using System.Net;

namespace Application.Exceptions
{
    public class BusinessException : Exception
    {
        public HttpStatusCode Status { get; private set; }

        public BusinessException(HttpStatusCode status, string message) : base(message)
        {
            Status = status;
        }
    }
}
