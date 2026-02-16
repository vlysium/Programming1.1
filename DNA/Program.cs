namespace DNA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string templateStrand = "GAGCCTACTAACGGGAT";
            string newStrand      = "CATCGTAATGACGGCCT";
            int hammingDistance = GetGammingDistance(templateStrand, newStrand);
            Console.WriteLine($"Hamming distance: {hammingDistance}");
        }

        /// <summary>
        /// Calculates the Hamming distance between two DNA strands, representing the number of differing positions
        /// between them.
        /// </summary>
        /// <remarks>
        /// If the input strands are of unequal length, the shorter strand is padded with underscores ('_') to match the
        /// length of the longer strand before comparison. This ensures that all positions are compared.
        /// </remarks>
        /// <param name="templateStrand">
        /// The original DNA strand to compare. If shorter than <paramref name="newStrand"/> , it is padded with
        /// underscores ('_') to match the length.
        /// </param>
        /// <param name="newStrand">
        /// The DNA strand to compare against the template. If shorter than <paramref name="templateStrand"/> , it is
        /// padded with underscores ('_') to match the length.
        /// </param>
        /// <returns>
        /// The number of positions at which the corresponding symbols in the two strands are different. Returns 0 if
        /// the strands are identical after padding.
        /// </returns>
        static int GetGammingDistance(string templateStrand, string newStrand)
        {
            int hammingDistance = 0;

            // make both strings equal lengths if one is shorter by adding lengths to it
            int maxLength = Math.Max(templateStrand.Length, newStrand.Length);
            templateStrand = templateStrand.PadRight(maxLength, '_');
            newStrand = newStrand.PadRight(maxLength, '_');

            for (int i = 0; i < templateStrand.Length; i++)
            {
                // compare bases and increment hamming distance if they don't match
                if (templateStrand[i] != newStrand[i])
                {
                    hammingDistance++;
                }
            }

            return hammingDistance;
        }
    }
}
