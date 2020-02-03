using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationExceptionApp
{
    class ValidateUser:ApplicationException
    {
        string message,message1;
        
        public ValidateUser(String msg,String msg1)
        {
            message = msg;
            message1 = msg1;

        }

        public override string Message { get { return message; }  }

        public  string Message1 { get { return message1; } }
        
    }
}
