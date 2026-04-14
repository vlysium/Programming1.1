namespace VroomVroom
{
	public abstract class Vehicle
	{
		private double _fuelLevel;

		/// <summary>
		/// Gets or sets the fuel level of the vehicle. The value is constrained between 0 and 100.
		/// </summary>
		public double FuelLevel
		{
			get { return _fuelLevel; }
			set
			{
				if (value < 0)
				{
					_fuelLevel = 0;
				}
				else if (value > 100)
				{
					_fuelLevel = 100;
				}
				else
				{
					_fuelLevel = value;
				}
			}
		}

		/// <summary>
		/// Constructor for the Vehicle class. Since this is an abstract class, it cannot
		/// be instantiated directly, but this constructor can be called by derived classes.
		/// </summary>
		/// <param name="fuelLevel">The initial fuel level for the vehicle.</param>
		public Vehicle(double fuelLevel)
		{
			_fuelLevel = fuelLevel;
		}

		/// <summary>
		/// Abstract method to start the vehicle.
		/// Derived classes must provide their own implementation of this method.
		/// </summary>
		public abstract void Start();

		/// <summary>
		/// Method to stop the vehicle.
		/// </summary>
		public void Stop()
		{
			Console.WriteLine("The vehicle has stopped.");
		}
	}
}
