namespace PhoneBook
{

	public class PhoneBook
	{
		private Dictionary<string, Person> _employees;

		/// <summary>
		/// Gets or sets the employees in the phone book. The key is the employee's phone number,
		/// and the value is a <see cref="Person"/> containing their details.
		/// </summary>
		public Dictionary<string, Person> Employees
		{
			get { return _employees; }
			set { _employees = value; }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PhoneBook"/> class with an empty dictionary of employees.
		/// </summary>
		public PhoneBook()
		{
			_employees = new Dictionary<string, Person>();
		}

		/// <summary>
		/// Adds a new employee to the phone book. The employee's phone number is used as the key in the dictionary.
		/// </summary>
		/// <param name="person">The person to add as an employee.</param>
		public void AddEmployee(Person person)
		{
			Employees.Add(person.PhoneNumber, person);
		}

		/// <summary>
		/// Removes an employee from the phone book based on their phone number.
		/// </summary>
		/// <param name="person">The person to remove.</param>
		public void RemoveEmployee(Person person)
		{
			Employees.Remove(person.PhoneNumber);
		}

		/// <summary>
		/// Searches for an employee in the phone book using their phone number. If the employee is found,
		/// their details are returned as a <see cref="Person"/> object; otherwise, null is returned.
		/// </summary>
		/// <param name="phoneNumber">The phone number of the employee to search for.</param>
		/// <returns>The employee if found; otherwise, null.</returns>
		public Person? SearchEmployee(string phoneNumber)
		{
			// Try to get the employee from the dictionary using the provided phone number
			if (Employees.TryGetValue(phoneNumber, out Person? person))
			{
				return person;
			}
			else
			{
				return null; // Return null if the employee is not found
			}
		}

		/// <summary>
		/// Clears all employees from the phone book.
		/// </summary>
		public void Clear()
		{
			Employees.Clear();
		}
	}
}