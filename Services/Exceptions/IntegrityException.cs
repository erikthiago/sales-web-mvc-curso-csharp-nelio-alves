using System;

namespace SalesWebMVC.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string messsage) : base(messsage)
        {

        }
    }
}
