using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
	public interface IDepartmentsManagable
	{
		void RegisterDepartment(IObservable observable);
		void RemoveDepartment(IObservable observable);
		void NotifyDepartments(string message);
	}
}
