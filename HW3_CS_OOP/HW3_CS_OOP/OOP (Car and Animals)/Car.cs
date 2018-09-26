using System;

namespace HW3_CS_OOP
{
    public class Car
    {
        private string brand;
        private string color;
        private double price;

        public Car()
        {
            brand = "Mustang";
            color = "Black";
            price = 200000;
        }

        public Car(string brand, string color, double price)
        {
            this.brand = brand;
            this.color = color;
            this.price = price;
        }

        public string Color
        {
            get => color;
            set => color = value;
        }

        public void Input()
        {
            brand = Console.ReadLine();
            color = Console.ReadLine();
            price = Convert.ToDouble(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"Brand of car is {brand}, car`s color is {color}. Car cost {price}");
        }

        public void ChangePrice(double x)
        {
            price = price * x / 100;
        }
    }
}