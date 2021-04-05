using ObserverPattern.Interfaces;
using System;

namespace ObserverPattern.ApplicationObjects.Departments
{
	public class HumanResources : IObservable
	{
		public string DepartmentID { get; }

		public HumanResources() => DepartmentID = "HumanResources";

		public void GetNotified(string message) => Console.WriteLine($"Human resources department gets notified : {message}");
	}
}
