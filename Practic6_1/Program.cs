using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic9_1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Person pers = new Person();
            pers.Name = "Маша";
            pers.Age = 25;

            pers.SayHello();
        }
    }
}
