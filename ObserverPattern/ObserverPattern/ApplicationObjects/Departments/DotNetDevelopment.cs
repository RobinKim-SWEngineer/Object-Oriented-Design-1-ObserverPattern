using ObserverPattern.Interfaces;
using System;

namespace ObserverPattern.ApplicationObjects.Departments
{
	class DotNetDevelopment : IObservable
	{
		public string DepartmentID { get; }

		public DotNetDevelopment() => DepartmentID = "DotNetDevelopment";

		public void GetNotified(string message) => Console.WriteLine($"Business Strategy department gets notified : {message}");
	}
}
