namespace Yearbook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("John Doe", 30, new DateTime(1994, 5, 15));
            Person person2 = new Person("Jane Jane", 25, new DateTime(1999, 2, 22));

            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
        }
    }
}
