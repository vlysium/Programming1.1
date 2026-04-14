namespace VroomVroom
{
	public class Car : Vehicle
	{
		public Car(double fuelLevel) : base(fuelLevel) { }

		public override void Start()
		{
			Console.WriteLine("Turning the key to start the car...");
		}
	}
}
