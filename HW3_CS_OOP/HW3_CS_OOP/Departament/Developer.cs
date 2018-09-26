using HW3_CS_OOP.Properties;

namespace HW3_CS_OOP
{
    public class Developer:Employee
    {
        public Developer()
        {
        }

        public Developer(double salary, string firstName, string secondName, int experience, Manager manager) : base(salary, firstName, secondName, experience, manager)
        {
        }
    }
}