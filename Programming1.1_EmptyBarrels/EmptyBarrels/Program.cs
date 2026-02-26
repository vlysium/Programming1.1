namespace EmptyBarrels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double barrelRadius = 8.6;
            double barrelHeight = 12.4;
            Console.WriteLine($"Barrel radius: {barrelRadius} units.");
            Console.WriteLine($"Barrel height: {barrelHeight} units.");
            Console.WriteLine($"Barrel volume: {GetBarrelSurfaceArea(barrelRadius, barrelHeight)} square units.");
            Console.WriteLine($"Barrel volume: {GetBarrelVolume(barrelRadius, barrelHeight)} cubic units.");
        }

        /// <summary>
        /// Calculates the total surface area of a closed cylindrical barrel, including the top and bottom.
        /// </summary>
        /// <param name="radius">The radius of the barrel's circular base, in meters. Must be non-negative.</param>
        /// <param name="height">The height of the barrel, in meters. Must be non-negative.</param>
        /// <returns>The total surface area of the barrel, in square meters.</returns>
        static double GetBarrelSurfaceArea(double radius, double height)
        {
            return 2 * Math.PI * Math.Pow(radius, 2) + 2 * Math.PI * radius * height;
        }

        /// <summary>
        /// Calculates the volume of a cylindrical barrel given its radius and height.
        /// </summary>
        /// <param name="radius">The radius of the barrel's base, in units consistent with the desired output volume. Must be non-negative.</param>
        /// <param name="height">The height of the barrel, in the same units as the radius. Must be non-negative.</param>
        /// <returns>The volume of the barrel, in cubic units corresponding to the units of the radius and height. Returns 0 if
        /// either radius or height is 0.</returns>
        static double GetBarrelVolume(double radius, double height)
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }
    }
}
