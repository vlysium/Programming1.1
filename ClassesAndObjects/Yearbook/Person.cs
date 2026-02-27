namespace Yearbook {

    public class Person
    {
        public string Name { get; }

        public int Age { get; }

        public DateTime Birthday { get; }

        /// <summary>
        /// Initializes a new instance of the Person class with the specified name, age, and birthday.
        /// </summary>
        /// <param name="name">
        /// The name of the person.
        /// </param>
        /// <param name="age">
        /// The age of the person.
        /// </param>
        /// <param name="birthday">
        /// The birthday of the person.
        /// </param>
        public Person(string name, int age, DateTime birthday)
        {
            Name = name;
            Age = age;
            Birthday = birthday;
        }

        /// <summary>
        /// Returns a string that represents the current object, including the name,
        /// age, and birthday of the person.
        /// </summary>
        /// <returns>A string representation of the person.</returns>
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Birthday: {Birthday.ToShortDateString()}";
        }
    }
}
