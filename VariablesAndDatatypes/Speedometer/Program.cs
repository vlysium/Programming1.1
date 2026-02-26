namespace Speedometer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input distance in kilometers:");
            int distanceTraveled = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Input time in minutes:");
            int durationInMinutes = Convert.ToInt16(Console.ReadLine());
            double durationInHours = durationInMinutes / 60.0;

            double averageSpeed = distanceTraveled / durationInHours;
            double averageSpeedRounded = Math.Round(averageSpeed, 2);

            Console.WriteLine($"Your average speed is {averageSpeedRounded} km/h");
        }
    }
}
