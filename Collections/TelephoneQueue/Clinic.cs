namespace TelephoneQueue {

	public class Clinic
	{
		private Queue<Patient> _queue;

		/// <summary>
		/// Initializes a new instance of the Clinic class, which contains a queue of patients.
		/// </summary>
		public Clinic()
		{
			_queue = new Queue<Patient>();
		}

		/// <summary>
		/// Adds a patient to the end of the queue.
		/// </summary>
		/// <param name="patient">The <see cref="Patient"/> to add to the queue</param>
		public void EnqueuePatient(Patient patient)
		{
			_queue.Enqueue(patient);
		}

		/// <summary>
		/// Removes and returns the patient at the front of the queue.
		/// </summary>
		/// <returns>The <see cref="Patient"/> at the front of the queue.</returns>
		public Patient DequeuePatient()
		{
			return _queue.Dequeue();
		}

		/// <summary>
		/// Returns the number of patients currently in the queue.
		/// </summary>
		/// <returns>The number of patients currently in the queue.</returns>
		public int PatientsInQueue()
		{
			return _queue.Count;
		}

		/// <summary>
		/// Returns the patient at the front of the queue without removing them.
		/// </summary>
		/// <returns>The <see cref="Patient"/> at the front of the queue.</returns>
		public Patient NextPatient()
		{
			return _queue.Peek();
		}
	}
}
