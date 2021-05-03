using System;
using System.Globalization;
using System.Collections.Generic;

namespace list_employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employee will be registred? ");
            int n = int.Parse(Console.ReadLine());
            
            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"employee#{i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));

            }
            Console.WriteLine(" ");
            Console.Write("enter the ID that will be have salary increase: ");
            int searchid = int.Parse(Console.ReadLine());
            Employee emp = list.Find(x => x.Id == searchid);
            Console.WriteLine("");
            if (emp != null)
            {
                Console.Write("enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);




            }
            else
            {
                Console.WriteLine("id not exist");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Update list of employee");
            foreach (Employee obj in list)
            {

                Console.WriteLine(obj);

            }
        }
    }
}
