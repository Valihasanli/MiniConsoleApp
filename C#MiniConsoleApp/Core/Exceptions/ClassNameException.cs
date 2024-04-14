using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Exceptions
{
    internal class ClassNameException:Exception
    {
        public ClassNameException(string message) : base(message)
        {

        }
    }
}
