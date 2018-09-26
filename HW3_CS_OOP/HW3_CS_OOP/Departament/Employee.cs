using System;
using System.Runtime.ExceptionServices;

namespace HW3_CS_OOP.Properties
{
    public abstract class Employee
    {
        private string firstName;
        private string secondName;
        private double salary;
        private int experience;
        private Manager _manager;
        
        protected Employee()
        {
        }

        protected Employee(double salary, string firstName, string secondName, int experience, Manager manager)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.experience = experience;
            this.salary = salary;
            _manager = manager;
        }

        public double Salary
        {
            get => salary;
            set
            {
                if (experience > 5)
                    salary = value * 1.2 + 500;
                if (experience > 2 && experience <= 5)
                    salary = value + 200;
                if (experience <= 2)
                    salary = value;
            }
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string SecondName
        {
            get => secondName;
            set => secondName = value;
        }

        public int Experience
        {
            get => experience;
            set => experience = value;
        }

        public bool Equals(Employee employee)
        {
            return employee.Experience==experience && employee.FirstName==firstName && 
                     employee.SecondName == secondName;
        }

        public void Print()
        {
            Console.WriteLine($"This employee - {firstName} {secondName}, manager : {secondName}, experiense - {experience} year");
        }

    }
}