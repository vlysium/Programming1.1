namespace VroomVroom
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Car myCar = new Car(80);
			myCar.Start();
			myCar.Stop();

			Motorbike myMotorbike = new Motorbike(95);
			myMotorbike.Start();
			myMotorbike.Stop();
		}
	}
}
