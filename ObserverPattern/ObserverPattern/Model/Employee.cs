namespace ObserverPattern.Model
{
	public class Employee
	{
		private readonly int _id = 0;

		public int ID { get; private set; }
		public string Name { get; private set; }
		public string Department { get; private set; }
		public int Salary { get; private set; }

		public Employee(string name, string department, int salary)
		{
			_id++;

			Name = name;
			Department = department;
			Salary = salary;
			ID = _id;
		}

		public void IncreaseSalary(int newSalary) => Salary += newSalary;
	}
}
