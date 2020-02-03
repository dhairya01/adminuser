using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationExceptionApp
{
    class AdminUser
    {
        
        public string newuser(string userName, string mobilenumber)
        {
            string msg;

            try
            {
                if(userName=="" && mobilenumber==" ")
                {
                    throw new ValidateUser("user name should not be empty","Mobilenumber should not be of string type");
                }
                
            }
            catch(ValidateUser exp)
            {
                Console.WriteLine(exp.Message);
                Console.WriteLine(exp.Message1);
            }
            
            finally
            {
                msg = "User created succesfully";
            }
            return msg;
        }
    }
}
