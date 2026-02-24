namespace SortingHat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            College myCollege = SortingHat.Enroll();
            Console.WriteLine($"You are enrolled in {myCollege}.");
        }
    }
}
