using System;
using System.Collections.Generic;
using HW3_CS_OOP.Properties;

namespace HW3_CS_OOP
{
    public class Departament
    {
        public List<Manager> managers;

        public Departament()
        {
        }

        public Departament(List<Manager> managers)
        {
            this.managers = new List<Manager>(managers);
        }

        public void AddManager(Manager manager)
        {
            managers.Add(manager);
        }

        public void GiveSalary(Employee employee)
        {
            bool exception = true;
            foreach (Manager manager in managers)
            {
                if (manager.Equals(employee))
                {
                    if (manager._employees.Count > 5 && manager._employees.Count <= 10)
                        manager.Salary += 200;
                    if (manager._employees.Count > 10)
                        manager.Salary += 300;
                    int count = 0;
                    foreach (Employee element in manager._employees)
                    {
                        if (element is Developer)
                            count++;
                    }

                    if (count >= manager._employees.Count / 2.0)
                    {
                        manager.Salary = manager.Salary * 1.1;
                    }

                    Console.WriteLine($"{manager.FirstName} {manager.SecondName}: got salary: {manager.Salary}");
                    exception = false;
                    break;
                }
                foreach (Employee element in manager._employees)
                {
                    if (element.Equals(employee))
                    {
                        Console.WriteLine($"{element.FirstName} {element.SecondName}: got salary: {element.Salary}");
                        exception = false;
                        break;
                    }
                }
            }
            if(exception)
                throw new SalaryGivingException();
        }
        
        public void AddTeamMembers(Manager manager, Employee[] array)
        {
            if (manager is Manager)
            {
                manager.AddToTeam(array);
                managers.Add(manager);
            }
            else
                throw new WrongEmployeeRoleException(manager.SecondName);
        }
    }
}