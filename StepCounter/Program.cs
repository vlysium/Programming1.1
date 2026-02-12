namespace StepCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many steps have you walked today?");
            int steps = Convert.ToInt16(Console.ReadLine());

            double distancePerStep = 0.762; // in meters

            double distanceWalked = Math.Round((distancePerStep * steps) / 1000, 2);

            Console.WriteLine($"You have walked {distanceWalked} km today");
        }
    }
}
