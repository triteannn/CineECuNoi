using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSApp.Exceptions
{
    public class SeviceException: Exception
    {
        public SeviceException(string message) : base(message)
        {

        }
    }
}
