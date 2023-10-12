using System.Globalization;
using Course.Entities;
using Course.Entities.Enums;
using System;

namespace Course
{
    public class Program
    {
        static void Main()
        {
           Console.WriteLine("Enter departament's name: ")
           string departamentName = Console.ReadLine();

           Console.WriteLine("Enter worker data: ")
           Console.WriteLine("Name: ");
           string name = Console.ReadLine();

           Console.WriteLine("Level: Junior - MidLevel or Senior");
           WorkerLevel lever = Enum.Parse<WorkerLevel>(Console.ReadLine());

           Console.WriteLine("Base Salary:");
           double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
           Departament departament = new Departament(departamentName);
           Worker worker = new Worker(name, level, baseSalary, departament);

           Console.WriteLine("How many contracts to this worker?");
           int n = int.Parse(Console.ReadLine());
           
           for (int i = 0; i < n; i++)
           {
                Console.WriteLine($"Enter {i} contract data: \n" +
                                  $"Date (DD/MM/YYYY): \n");

                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");

                double valuePerHour = double.Parse(Console.ReadLine());
                Console.WriteLine("Duraction - hours:");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(Date, valuePerHour, hours);
           }

           Console.WriteLine();
           Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
           string monthAndYear = Console.ReadLine();
           int month = int.Parse(monthAndYear.Substring(0, 2));
           int year = int.Parse(monthAndYear.Substring(3));

           Console.WriteLine($"Name: {worker.Name}");
           Console.WriteLine($"Departament: {worker.Departament.Name}");
           Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month):c} ");
        }
    }
}