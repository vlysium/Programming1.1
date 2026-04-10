namespace DeviceDynasty
{
	public abstract class ElectronicDevice
	{
		private string _brand;
		private string _model;
		private double _batteryCapacity;

		/// <summary>
		/// Gets or sets the brand of the electronic device.
		/// </summary>
		public string Brand
		{
			get { return _brand; }
			protected set { _brand = value; }
		}

		/// <summary>
		/// Gets or sets the model of the electronic device.
		/// </summary>
		public string Model
		{
			get { return _model; }
			protected set { _model = value; }
		}

		/// <summary>
		/// Gets or sets the battery capacity of the electronic device in milliampere-hours (mAh).
		/// </summary>
		public double BatteryCapacity
		{
			get { return _batteryCapacity; }
			protected set { _batteryCapacity = value; }
		}

		/// <summary>
		/// Initializes a new instance of the ElectronicDevice class with the specified brand, model, and battery capacity.
		/// </summary>
		/// <param name="brand">The brand of the electronic device.</param>
		/// <param name="model">The model of the electronic device.</param>
		/// <param name="batteryCapacity">The battery capacity of the electronic device in milliampere-hours (mAh).</param>
		public ElectronicDevice(string brand, string model, double batteryCapacity)
		{
			_brand = brand;
			_model = model;
			_batteryCapacity = batteryCapacity;
		}

		/// <summary>
		/// Displays the details of the electronic device, including brand, model, and battery capacity.
		/// </summary>
		public void GetDeviceDetails()
		{
			Console.WriteLine($"Brand: {Brand}, Model: {Model}, Battery Capacity: {BatteryCapacity} mAh");
		}
	}
}
