using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCustomDemo.CustomException
{
    class InvalidAddressException : Exception
    {
        public InvalidAddressException(string message, Exception innerException)
            :base(message, innerException)
        {
        }
    }
}
