using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic9_1
{
    internal class Program
    {
        static void SayHello(string name, int age) {
            Console.WriteLine($"Привет, я {name}, мне {age} лет!");
        }
        static void Main(string[] args)
        {
            Person pers = new Person();
            pers.Name = "Маша";
            pers.Age = 25;

            SayHello(pers.Name, pers.Age);
        }
    }
}
