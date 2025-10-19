namespace Practic9_1
{
    internal class Person
    {
        public string Name;
        public int age;
        public int Age
        {
            get { return age; }
            set {
                if (value >= 0 && value <= 120)
                {
                    age = value;
                }
                else {
                    Console.WriteLine("Возраст должен быть в диапазоне 0-120");
                }
            }
        }

    }
}