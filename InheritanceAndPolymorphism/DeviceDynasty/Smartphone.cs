namespace DeviceDynasty
{
	public enum SmartphoneOperatingSystem
	{
		Android,
		IOS,
		WindowsPhone
	}
	public class Smartphone : ElectronicDevice
	{
		private SmartphoneOperatingSystem _operatingSystem;

		/// <summary>
		/// Gets or sets the operating system of the smartphone.
		/// </summary>
		public SmartphoneOperatingSystem OperatingSystem
		{
			get { return _operatingSystem; }
			set { _operatingSystem = value; }
		}

		/// <summary>
		/// Initializes a new instance of the Smartphone class with the specified brand, model, battery capacity, and operating system.
		/// </summary>
		/// <param name="brand">The brand of the smartphone.</param>
		/// <param name="model">The model of the smartphone.</param>
		/// <param name="batteryCapacity">The battery capacity of the smartphone in milliampere-hours (mAh).</param>
		/// <param name="operatingSystem">The operating system of the smartphone.</param>
		public Smartphone(string brand, string model, double batteryCapacity, SmartphoneOperatingSystem operatingSystem) : base(brand, model, batteryCapacity)
		{
			_operatingSystem = operatingSystem;
		}

		/// <summary>
		/// Displays the details of the smartphone, including brand, model, battery capacity, and operating system.
		/// </summary>
		public void GetSmartphoneDetails()
		{
			GetDeviceDetails();
			Console.WriteLine($"Operating System: {OperatingSystem}");
		}
	}
}
