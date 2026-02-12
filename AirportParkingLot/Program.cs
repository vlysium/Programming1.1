namespace AirportParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get user input for parking eligibility
            Console.WriteLine("Do you have a valid parking license? (y/n)");
            string inputHasParkingLicense = Console.ReadLine();

            // get user input for parking permission
            Console.WriteLine("Do you have a valid parking permission? (y/n)");
            string inputHasParkingPermission = Console.ReadLine();

            // get user input for parking time
            Console.WriteLine("What time do you want to park? (HH:mm)");
            DateTime inputTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm", null);

            // get user input for employee status
            Console.WriteLine("Are you an employee? (y/n)");
            string inputIsEmployee = Console.ReadLine();

            // function to check parking eligibility
            bool CheckParkingEligibility()
            {
                if (inputHasParkingLicense == "n")
                {
                    return false;
                }

                if (inputHasParkingPermission == "n")
                {
                    return false;
                }

                if (inputTime.Hour < 8 || inputTime.Hour >= 18)
                {
                    return false;
                }

                if (inputIsEmployee == "y")
                {
                    return true;
                }
                return true;
            }

            // output the result
            bool isEligible = CheckParkingEligibility();
            if (isEligible)
            {
                Console.WriteLine("You are eligible to park.");
            }
            else
            {
                Console.WriteLine("You are not eligible to park.");
            }
        }
    }
}
