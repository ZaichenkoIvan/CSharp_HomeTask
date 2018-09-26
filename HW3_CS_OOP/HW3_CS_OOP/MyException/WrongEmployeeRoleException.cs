using System;

namespace HW3_CS_OOP
{
    public class WrongEmployeeRoleException:Exception
    {
        public WrongEmployeeRoleException(string secondName)
        {
            Console.WriteLine($"Employee {secondName} has unexpected role!");
        }
    }
}