using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingApp
{
    class Manipulation
    {
        public void Dividebyzero(int number)
        {
            
            try
            {
                int number2 = 122;
                int result = number2 / number;
                Console.WriteLine("result:" + result);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine("Number should not be zero");
            }
            finally
            {
                Console.WriteLine("");

            }
        }
    }
}
