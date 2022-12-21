using Infrastructure.Services;
using Domain.Models;

var dep = new Department();

dep.Name = "ArdasheR";
dep.Description = "student";

var depService = new DepartmentService();

depService.AddDepartments(dep);
foreach (var departmentElement in depService.GetDepartments())
{
    System.Console.WriteLine($"{departmentElement.Name} {departmentElement.Description}");
}
System.Console.WriteLine();


Employee employee1 = new Employee();

employee1.FirstName = "ArdasheR";
employee1.LastName = "Sattori";
employee1.Salary = 3000;

var employeeService = new EmployeeService();

employeeService.AddEmployees(employee1);

foreach(var employeeElement in employeeService.GetEmployees())
{
    System.Console.WriteLine($"{employeeElement.FirstName} {employeeElement.LastName} {employeeElement.Salary}");
}

int n = Convert.ToInt32(Console.ReadLine());

for(int i=1; i<=n; i++)
{
    Employee employee2 = new Employee();
    employee2.FirstName = Console.ReadLine();
    employee2.LastName = Console.ReadLine();
    employee2.Salary = Convert.ToDecimal(Console.ReadLine());
    
    var eService = new EmployeeService();

    eService.AddEmployees(employee2);
    foreach(var eElement in eService.GetEmployees())
    {
        System.Console.WriteLine($"{i} {eElement.FirstName} {eElement.LastName} {eElement.Salary}");
    }
}