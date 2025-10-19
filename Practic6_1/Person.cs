using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic9_1
{
    internal class Person
    {
        private string name;
        private int age;
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Возраст должен быть в диапазоне 0-120");
                    age = 0;
                }
            }
        }

        public Person(string PersonName, int PersonAge){
            Name = PersonName;
            Age = PersonAge;
        }
        public void SayHello()
        {
            Console.WriteLine($"Привет, я {Name}, мне {Age} лет!");
        }

    }
}
