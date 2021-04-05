using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
	public interface IObservable
	{
		string DepartmentID { get; }
		void GetNotified(string message);
	}
}
