using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Manipulation mn = new Manipulation();
            mn.Dividebyzero(0);
            Console.ReadKey();
        }
    }
}
