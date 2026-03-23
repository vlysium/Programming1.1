namespace TelephoneQueue
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Initialize variables
			Clinic clinic = new Clinic();
			Patient patient1 = new Patient("Alice", "Renew prescription");
			Patient patient2 = new Patient("Bob", "Ear infection");
			Patient patient3 = new Patient("Charlie", "Flu symptoms");
			Patient patient4 = new Patient("Diana", "Receive test results");

			Random random = new Random();

			// Add patients to the clinic queue
			clinic.EnqueuePatient(patient1);
			clinic.EnqueuePatient(patient2);
			clinic.EnqueuePatient(patient3);
			clinic.EnqueuePatient(patient4);

			// Display the number of patients in the queue
			Console.WriteLine($"Patients in queue: {clinic.PatientsInQueue()}");

			// Treat patients in the order they arrived
			while (clinic.PatientsInQueue() > 0)
			{
				// Treat the patient
				Patient currentPatient = clinic.DequeuePatient();
				Console.WriteLine($"Treating patient: {currentPatient}");
				
				// Simulate random time taken to treat the patient
				Thread.Sleep(random.Next(1000, 5000));
				Console.WriteLine($"Patients remaining in queue: {clinic.PatientsInQueue()}");
			}
			
			Console.WriteLine("All patients have been treated.");
		}
	}
}
