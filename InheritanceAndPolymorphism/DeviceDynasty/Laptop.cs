namespace DeviceDynasty
{
	public enum LaptopOperatingSystem
	{
		Windows,
		MacOS,
		Linux
	}

	public class Laptop : ElectronicDevice
	{
		private LaptopOperatingSystem _operatingSystem;

		/// <summary>
		/// Gets or sets the operating system of the laptop.
		/// </summary>
		public LaptopOperatingSystem OperatingSystem
		{
			get { return _operatingSystem; }
			set { _operatingSystem = value; }
		}

		/// <summary>
		/// Initializes a new instance of the Laptop class with the specified brand, model, battery capacity, and operating system.
		/// </summary>
		/// <param name="brand">The brand of the laptop.</param>
		/// <param name="model">The model of the laptop.</param>
		/// <param name="batteryCapacity">The battery capacity of the laptop in milliampere-hours (mAh).</param>
		/// <param name="operatingSystem">The operating system of the laptop.</param>
		public Laptop(string brand, string model, double batteryCapacity, LaptopOperatingSystem operatingSystem) : base(brand, model, batteryCapacity)
		{
			_operatingSystem = operatingSystem;
		}

		/// <summary>
		/// Displays the details of the laptop, including brand, model, battery capacity, and operating system.
		/// </summary>
		public void GetLaptopDetails()
		{
			GetDeviceDetails();
			Console.WriteLine($"Operating System: {OperatingSystem}");
		}
	}
}
