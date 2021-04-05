using ObserverPattern.ApplicationObjects.Departments;
using ObserverPattern.ApplicationObjects.Management;
using ObserverPattern.Database;
using ObserverPattern.Model;
using System;

namespace ObserverPattern
{
	class Program
	{
		static void Main()
		{
			EmployeeDatabaseAccess employeeDAO = new EmployeeDatabaseAccess();
			EmployeeManagementSystem employeeManagementSystem = new EmployeeManagementSystem(employeeDAO);

			BusinessStrategy businessStrategy = new BusinessStrategy();
			HumanResources humanResources = new HumanResources();
			DotNetDevelopment dotNetDevelopment = new DotNetDevelopment();
			Console.WriteLine();

			employeeManagementSystem.RegisterDepartment(businessStrategy);
			employeeManagementSystem.RegisterDepartment(humanResources);
			employeeManagementSystem.RegisterDepartment(dotNetDevelopment);
			Console.WriteLine();

			Employee RobinKim = new Employee("Robin Kim", ".NET development team 3", 55000);

			employeeManagementSystem.Hire(RobinKim);
			Console.WriteLine();
			employeeManagementSystem.Award(RobinKim);

			Console.ReadKey();
		}
	}
}
