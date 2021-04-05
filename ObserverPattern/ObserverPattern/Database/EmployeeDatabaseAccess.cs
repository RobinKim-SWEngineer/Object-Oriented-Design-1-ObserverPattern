using ObserverPattern.Interfaces;
using ObserverPattern.Model;
using System.Collections.Generic;

namespace ObserverPattern.Database
{
	class EmployeeDatabaseAccess : IEmployeeManagable
	{
		private readonly List<Employee> _employees = new List<Employee>();

		public void AwardEmployee(Employee employee) => employee.IncreaseSalary(500);

		public void HireNewEmployee(Employee employee) => _employees.Add(employee);
	}
}
