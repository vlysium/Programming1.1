namespace DeviceDynasty
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Laptop myLaptop = new Laptop("ASUS", "ASUS TUF Gaming A16", 6000, LaptopOperatingSystem.Windows);
			myLaptop.GetLaptopDetails();

			Smartphone mySmartphone = new Smartphone("Apple", "iPhone 16", 3561, SmartphoneOperatingSystem.IOS);
			mySmartphone.GetSmartphoneDetails();
		}
	}
}
