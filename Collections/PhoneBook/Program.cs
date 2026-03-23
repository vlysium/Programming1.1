namespace PhoneBook
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a phone book
			PhoneBook phoneBook = new PhoneBook();

			// Create employees as variables for readability/reference
			Person alice = new Person("Alice", "alice@email.address", "12345678");
			Person bob = new Person("Bob", "bob@email.address", "10101010");
			Person charlie = new Person("Charlie", "charlie@email.address", "55555555");
			Person diana = new Person("Diana", "diana@email.address", "11111111");

			// Add employees to the phone book
			phoneBook.AddEmployee(alice);
			phoneBook.AddEmployee(bob);
			phoneBook.AddEmployee(charlie);
			phoneBook.AddEmployee(diana);

			// Remove an employee from the phone book
			phoneBook.RemoveEmployee(bob);

			// Search for an employee in the phone book
			Person? searchResult = phoneBook.SearchEmployee("12345678");
			Console.WriteLine(searchResult != null ? $"Employee found: {searchResult}" : "Employee not found.");

			// Clear the phone book
			phoneBook.Clear();
		}
	}
}
