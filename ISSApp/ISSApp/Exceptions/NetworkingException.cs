using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSApp.Exceptions
{
    class NetworkingException : Exception
    {
        public NetworkingException(string message) :base(message)
        {

        }
    }
}
