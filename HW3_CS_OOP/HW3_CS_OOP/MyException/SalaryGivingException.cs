using System;

namespace HW3_CS_OOP
{
    public class SalaryGivingException:Exception
    {
        public SalaryGivingException()
        {
            Console.WriteLine("Excettion! This Employee dont exist!");
        }
    }
}