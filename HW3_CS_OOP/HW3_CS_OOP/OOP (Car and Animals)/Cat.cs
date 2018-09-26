using System;

namespace HW3_CS_OOP
{
    public class Cat:IAnimal
    {
        public string Name { get; set; }
        
        public Cat()
        {
        }
        
        public Cat(string name)
        {
            Name = name;
        }
        
        public void Voice()
        {
            Console.WriteLine("Meow");
        }

        public void Feed()
        {
            Console.WriteLine("Cat eat milk");
        }
    }
}