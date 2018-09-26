using System;

namespace HW3_CS_OOP
{
    public class Dog:IAnimal
    {
        public string Name { get; set; }

        public Dog()
        {
        }

        public Dog(string name)
        {
            Name = name;
        }

        public void Voice()
        {
            Console.WriteLine("Gav");
        }

        public void Feed()
        {
            Console.WriteLine("Dog eat meat");
        }
    }
}