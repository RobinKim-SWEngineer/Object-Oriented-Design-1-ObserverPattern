using ObserverPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
	public interface IEmployeeManagable
	{
		void HireNewEmployee(Employee employee);
		void AwardEmployee(Employee employee);
	}
}
