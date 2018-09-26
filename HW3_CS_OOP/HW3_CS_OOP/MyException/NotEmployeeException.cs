using System;

namespace HW3_CS_OOP
{
    public class NotEmployeeException:Exception
    {
        public NotEmployeeException()
        {
            Console.WriteLine("There are not Employees in array");
        }
    }
}