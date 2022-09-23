using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            int hoursWorked = 0;            // Hours worked
            double hourlyRate = 0;           // Hourly Rate
            int hours = 0; 

            // Outputs
            double totalSalary = 0;         // Total Salary
            double regularSalary = 0;       // <= 40 hours work
            double overtimeSalary = 0;      // > 40 hours work  rate 1.5

            // Prompts
            Console.Write("Please enter Hours Worked: ");
            hoursWorked = int.Parse(Console.ReadLine());

            Console.Write("Please enter Hourly Rate: ");
            hourlyRate = double.Parse(Console.ReadLine());

            hours = hoursWorked; 

            // First calculate overtime
            if(hoursWorked > 40)
            {
                overtimeSalary = (1.5 * hourlyRate) * (hoursWorked - 40);
                hoursWorked = 40;
            }

            // Regulary Salary
            regularSalary = hoursWorked * hourlyRate;

            // Sum up for total salary
            totalSalary = regularSalary + overtimeSalary;

            // now Output
            Console.WriteLine("\nEmployee Salary:");
            Console.WriteLine("Hourly Rate:      {0}", hourlyRate.ToString("C02"));
            Console.WriteLine("Hours Worked:     {0}", hours);
            Console.WriteLine("Overtime Salary:  {0}", overtimeSalary.ToString("C02"));
            Console.WriteLine("Regular Salary:   {0}", regularSalary.ToString("C02"));
            Console.WriteLine("Grand total:      {0}", totalSalary.ToString("C02"));

            // Stop console 
            Console.ReadLine();
        }
    }
}
