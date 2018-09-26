using HW3_CS_OOP.Properties;

namespace HW3_CS_OOP
{
    public class Designer:Employee
    {
        private double coeff { get; set; }
        
        public Designer()
        {
        }

       
        public Designer(double salary, string firstName, string secondName, int experience, Manager manager, double coeff) : base(salary, firstName, secondName, experience, manager)
        {
            this.coeff = coeff;
            Salary = salary * coeff;
        }
    }
}