namespace TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your temperature in celsius:");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            double celsius = Convert.ToDouble(Console.ReadLine());

            Console.ResetColor();

            double fahrenheit = Math.Round((celsius * 1.8) + 32, 2);
            double reamur = celsius * 0.8;
            double kelvin = celsius + 273.15;

            Console.WriteLine($"{celsius} °C equals:");
            Console.WriteLine($"{fahrenheit} °F");
            Console.WriteLine($"{reamur} °Ré");
            Console.WriteLine($"{kelvin} K");
        }
    }
}
