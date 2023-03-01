using Employees;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = GetEmployeesFromDatabase();

            var sortedEmployees = employees.OrderBy(employee => employee.Salary);

            foreach (var employee in sortedEmployees)
            {
                Console.WriteLine($"{employee.Name} - {employee.Salary}");
            }
        }

        static List<Employee> GetEmployeesFromDatabase()
        {
            return new List<Employee> {
            new Employee { Name = "John", Salary = 50000 },
            new Employee { Name = "Alice", Salary = 60000 },
            new Employee { Name = "Bob", Salary = 45000 }};
        }
    }
}