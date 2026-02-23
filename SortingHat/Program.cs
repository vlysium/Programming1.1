namespace SortingHat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            College myCollege = SortingHat();
            Console.WriteLine($"You are enrolled in {myCollege}.");
        }

        public enum College { Gryffindor, Hufflepuff, Ravenclaw, Slytherin }

        /// <summary>
        /// Randomly selects and returns a <see cref="College"/> value, simulating the behavior of a sorting hat.
        /// </summary>
        /// <returns>
        /// A randomly chosen <see cref="College"/> enum value.
        /// </returns>
        /// <remarks>
        /// This method creates a new instance of <see cref="Random"/> and selects a random value from the available
        /// <see cref="College"/> enum values.
        /// </remarks>
        public static College SortingHat()
        {
            Random random = new Random();

            College[] colleges = (College[])Enum.GetValues(typeof(College));

            int randomCollege = random.Next(colleges.Length);

            College chosenCollege = (College)randomCollege;

            return chosenCollege;
        }
    }
}
