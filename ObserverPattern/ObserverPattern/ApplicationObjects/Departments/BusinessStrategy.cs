using ObserverPattern.Interfaces;
using System;

namespace ObserverPattern.ApplicationObjects.Departments
{
	public class BusinessStrategy : IObservable
	{
		public string DepartmentID { get; }

		public BusinessStrategy() => DepartmentID = "BusinessStrategy";

		public void GetNotified(string message) => Console.WriteLine($"Business Strategy department gets notified : {message}");
	}
}
