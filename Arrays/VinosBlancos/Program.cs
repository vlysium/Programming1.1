namespace VinosBlancos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vinos = { 175134, 175388, 172818, 142709, 151437, 152620 + 35432, 150979, 152210, 149450, 154398, 150160 };
            int max = GetMaxNumber(vinos);
            byte maxStar = 100;

            // sort array in descending order
            Array.Sort(vinos);
            Array.Reverse(vinos);

            // display as a "graph"
            foreach (int v in vinos)
            {
                int stars = maxStar * v / max;
                Console.WriteLine(string.Concat(Enumerable.Repeat("*", stars)));
            }
        }

        /// <summary>
        /// Returns the largest integer value in the specified array.
        /// </summary>
        /// <param name="numbers">
        /// An array of integers to search for the maximum value. Must not be null or empty.
        /// </param>
        /// <returns>The largest integer value found in the <paramref name="numbers"/> array.</returns>
        static int GetMaxNumber(int[] numbers)
        {
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                // iterate the array and save the highest number found
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }
    }
}
