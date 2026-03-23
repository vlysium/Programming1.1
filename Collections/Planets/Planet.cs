namespace Planets {

	public class Planet
	{
		private string _name;
		private int _diameter;
		private double _rotationPeriod;
		private int _numberOfMoons;
		private double _distanceFromSun;
		private int _surfaceTemperature;

		/// <summary>
		/// The name of the planet.
		/// </summary>
		public string Name { get { return _name; } set { _name = value; } }
		/// <summary>
		/// The diameter of the planet in kilometers.
		/// </summary>
		public int Diameter { get { return _diameter; } set { _diameter = value; } }
		/// <summary>
		/// The rotation period of the planet in hours.
		/// </summary>
		public double RotationPeriod { get { return _rotationPeriod; } set { _rotationPeriod = value; } }
		/// <summary>
		/// The time it takes for the planet to complete one full rotation on its axis, in hours.
		/// </summary>
		public int NumberOfMoons { get { return _numberOfMoons; } set { _numberOfMoons = value; } }
		/// <summary>
		/// The average distance from the planet to the sun, in AU (astronomical units).
		/// </summary>
		public double DistanceFromSun { get { return _distanceFromSun; } set { _distanceFromSun = value; } }
		/// <summary>
		/// The average surface temperature of the planet in degrees Celsius.
		/// </summary>
		public int SurfaceTemperature { get { return _surfaceTemperature; } set { _surfaceTemperature = value; } }

		/// <summary>
		/// Initializes a new instance of the Planet class with basic astronomical properties.
		/// </summary>
		/// <param name="name">The name of the planet.</param>
		/// <param name="diameter">The diameter of the planet in kilometers.</param>
		/// <param name="rotationPeriod">The time it takes for the planet to complete one full rotation on its axis, in hours.</param>
		/// <param name="numberOfMoons">The total number of natural satellites (moons) orbiting the planet.</param>
		/// <param name="distanceFromSun">The average distance from the planet to the sun, in AU (astronomical units).</param>
		/// <param name="surfaceTemperature">The average surface temperature of the planet in degrees Celsius.</param>
		public Planet(string name, int diameter, double rotationPeriod, int numberOfMoons, double distanceFromSun, int surfaceTemperature)
		{
			_name = name;
			_diameter = diameter;
			_rotationPeriod = rotationPeriod;
			_numberOfMoons = numberOfMoons;
			_distanceFromSun = distanceFromSun;
			_surfaceTemperature = surfaceTemperature;
		}

		public override string ToString()
		{
			return $"Planet: {Name}, Diameter: {Diameter} km, Rotation Period: {RotationPeriod} hours, Number of Moons: {NumberOfMoons}, Distance from Sun: {DistanceFromSun} AU, Surface Temperature: {SurfaceTemperature} °C";
		}
	}
}
