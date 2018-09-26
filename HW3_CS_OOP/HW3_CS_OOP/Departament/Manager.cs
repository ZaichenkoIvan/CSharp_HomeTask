using System.Collections.Generic;
using HW3_CS_OOP.Properties;

namespace HW3_CS_OOP
{
    public class Manager : Employee
    {
        public List<Employee> _employees;
        
        public Manager()
        {
        }

        public Manager(double salary, string firstName, string secondName, int experience, Manager manager,
            List<Employee> _employees) : base(salary, firstName, secondName, experience, manager)
        {
            this._employees = new List<Employee>(_employees);
        }
        
        public void AddToTeam(Employee employee)
        {
            if(employee is Manager)
                throw new WrongEmployeeRoleException(employee.SecondName);
            _employees.Add(employee);
        }
        
        public void AddToTeam(Employee[] employees)
        {
            if (employees.Length != 0)
            {
                foreach (Employee element in employees)
                {
                    AddToTeam(element);
                }
            }
            else
                throw new NotEmployeeException();
        }
       
       
    }
}