namespace VroomVroom
{
	public class Motorbike : Vehicle
	{
		public Motorbike(double fuelLevel) : base(fuelLevel) { }

		public override void Start()
		{
			Console.WriteLine("Twisting the throttle to start the motorbike...");
		}
	}
}
