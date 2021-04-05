using ObserverPattern.Interfaces;
using ObserverPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ObserverPattern.ApplicationObjects.Management
{
	class EmployeeManagementSystem : IDepartmentsManagable
	{
		private readonly List<IObservable> _departments = new List<IObservable>();
		private readonly IEmployeeManagable _employeeManagable;
		private string _message;

		public EmployeeManagementSystem(IEmployeeManagable employeeManagable) => _employeeManagable = employeeManagable;

		public void NotifyDepartments(string message) => _departments.ForEach(department => department.GetNotified(message));

		public void RegisterDepartment(IObservable department)
		{
			if (_departments.Any(registeredObserver => registeredObserver.DepartmentID == department.DepartmentID))
			{
				Console.WriteLine($"Department {department.DepartmentID} is already registered");
				return;
			}

			_departments.Add(department);
			Console.WriteLine($"Department {department.DepartmentID} is registered");
		}

		public void RemoveDepartment(IObservable department)
		{
			if (_departments.Any(registeredObserver => registeredObserver.DepartmentID == department.DepartmentID))
			{
				_departments.Remove(department);
				Console.WriteLine($"Department {department.DepartmentID} is removed");

				return;
			}

			Console.WriteLine($"Department {department.DepartmentID} does not exist");
		}
		
		public void Hire(Employee employee)
		{
			_employeeManagable.HireNewEmployee(employee);

			_message = $"Let's welcom our new colleague {employee.Name} in {employee.Department} !";
			NotifyDepartments(_message);
		}

		public void Award(Employee employee)
		{
			_message = $"Congratulation {employee.Name} in {employee.Department} for being awared as best employee !";
			NotifyDepartments(_message);
		}
	}
}
