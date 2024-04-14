using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_MiniConsoleApp.Exceptions
{
    internal class StudentNameException:Exception
    {
        public StudentNameException(string message):base(message) 
        {
            
        }
    }
}
