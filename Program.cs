using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company company = new Company("Mamba Industries", DateTime.Now);

            // Create three employees
            Employee employee1 = new Employee("Paula", "Mooney", "Manager", new DateTime(2021, 9, 5));
            Employee employee2 = new Employee("Brandye", "Rispress", "Assistant Manager", new DateTime(2021, 10, 13));
            Employee employee3 = new Employee("Andrew", "Fleck", "Electrician", new DateTime(2022, 2, 13));

            // Assign the employees to the company
            company.Employees.Add(employee1);
            company.Employees.Add(employee2);
            company.Employees.Add(employee3);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            foreach (Employee employee in company.Employees)
            {
                Console.WriteLine("Employee:");
                DisplayEmployeeInfo(employee);
                Console.WriteLine();
            }
            
        }

        static void DisplayEmployeeInfo(Employee employee)
        {
            Console.WriteLine($"First Name: {employee.FirstName}");
            Console.WriteLine($"Last Name: {employee.LastName}");
            Console.WriteLine($"Title: {employee.Title}");
            Console.WriteLine($"Start Date: {employee.StartDate.ToShortDateString()}");
        }
    }
}
