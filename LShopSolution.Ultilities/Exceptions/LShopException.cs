using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LShopSolution.Ultilities.Exceptions
{
    public class LShopException : Exception
    {
        public LShopException() { }

        public LShopException(string message) : base(message) 
        { 
        }

        public LShopException(string message,  Exception innerException) : base(message, innerException) 
        {
        }
    }
}
