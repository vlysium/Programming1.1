namespace PhoneBook
{

	public class Person
	{
		private string _name;
		private string _email;
		private string _phoneNumber;

		/// <summary>
		/// The name of the person.
		/// </summary>
		public string Name { 
			get { return _name; } 
			set { _name = value; } 
		}
		/// <summary>
		/// The email of the person.
		/// </summary>
		public string Email { 
			get { return _email; } 
			set { _email = value; } 
		}
		/// <summary>
		/// The phone number of the person.
		/// </summary>
		public string PhoneNumber { 
			get { return _phoneNumber; } 
			set { _phoneNumber = value; } 
		}

		/// <summary>
		/// Initializes a new instance of the Person class with the specified name, email, and phone number.
		/// </summary>
		/// <param name="name">
		/// The name of the person.
		/// </param>
		/// <param name="email">
		/// The email of the person.
		/// </param>
		/// <param name="phoneNumber">
		/// The phone number of the person.
		/// </param>
		public Person(string name, string email, string phoneNumber)
		{
			_name = name;
			_email = email;
			_phoneNumber = phoneNumber;
		}

		public override string ToString()
		{
			return $"{Name}, Email: {Email}, Phone Number: {PhoneNumber}";
		}	
	}
}