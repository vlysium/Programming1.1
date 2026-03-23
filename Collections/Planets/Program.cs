namespace Planets
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a list of planets
			List<Planet> planets = new List<Planet>();

			// Create planets as variables for readability/reference
			Planet mercury = new Planet("Mercury", 4849, 1407.6, 0, 0.39, 430);
			Planet venus = new Planet("Venus", 12104, 5832.5, 0, 0.72, 462);
			Planet earth = new Planet("Earth", 12742, 23.9, 1, 1.00, 15);
			Planet mars = new Planet("Mars", 6779, 24.6, 2, 1.52, -60);
			Planet jupiter = new Planet("Jupiter", 139820, 9.9, 79, 5.20, -108);
			Planet saturn = new Planet("Saturn", 116460, 10.7, 82, 9.58, -139);
			Planet uranus = new Planet("Uranus", 50724, 17.2, 27, 19.18, -197);
			Planet neptune = new Planet("Neptune", 49244, 16.1, 14, 30.07, -201);
			Planet pluto = new Planet("Pluto", 2376, 153.3, 5, 39.48, -229);

			// Add planets to the list
			planets.Add(mercury);
			// planets.Add(venus);
			planets.Add(earth);
			planets.Add(mars);
			planets.Add(jupiter);
			planets.Add(saturn);
			planets.Add(uranus);
			planets.Add(neptune);
			planets.Add(pluto);

			// Insert the missing planet, "Venus"
			planets.Insert(1, venus);

			// Remove the planet "Pluto"
			planets.Remove(pluto);

			// Insert the planet "Pluto" back into the list at its original position
			planets.Insert(8, pluto);

			// Print list of planets
			foreach(Planet planet in planets)
			{
				Console.WriteLine(planet.Name);
			}

			// Print the number of planets in the list
			Console.WriteLine($"Number of planets: {planets.Count}");

			// Make a new list of planets with a negative surface temperature
			List<Planet> coldPlanets = planets.Where(planet => planet.SurfaceTemperature < 0).ToList();

			// Print the names of the cold planets
			foreach(Planet planet in coldPlanets)
			{
				Console.WriteLine(planet.Name);
			}

			// Make a new list of planets with a diameter between 10000 km and 50000 km
			List<Planet> mediumSizedPlanets = planets.Where(planet => 10000 < planet.Diameter && planet.Diameter < 50000).ToList();

			// Print the name of the medium sized planets
			foreach(Planet planet in mediumSizedPlanets)
			{
				Console.WriteLine(planet.Name);
			}

			// Clear list
			planets.Clear();
		}
	}
}
