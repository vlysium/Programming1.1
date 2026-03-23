namespace TelephoneQueue {

	public class Patient
	{
		private string _name;
		private string _need;
		private DateTime _contactTime;

		/// <summary>
		/// Name of the patient
		/// </summary>
		public string Name { get { return _name; } set { _name = value; } }
		/// <summary>
		/// The type of help the patient needs
		/// </summary>
		public string Need { get { return _need; } set { _need = value; } }
		/// <summary>
		/// The time the patient contacted the hospital
		/// </summary>
		public DateTime ContactTime { get { return _contactTime; } set { _contactTime = value; } }

		/// <summary>
		/// Initializes a new instance of the <see cref="Patient"/> class.
		/// </summary>
		/// <param name="name">The name of the patient</param>
		/// <param name="need">The type of help the patient needs</param>
		public Patient(string name, string need)
		{
			_name = name;
			_need = need;
			_contactTime = DateTime.Now;
		}

		/// <inheritdoc cref="Patient(string, string)" />
		/// <param name="contactTime">The time the patient contacted the hospital</param>
		/// <remarks>
		/// This constructor allows you to specify the contact time of
		/// the patient, instead of using the current time.
		/// </remarks>
		public Patient(string name, string need, DateTime contactTime) : this(name, need)
		{
			_contactTime = contactTime;
		}

		public override string ToString()
		{
			return $"{Name}, Need: {Need}, Contact Time: {ContactTime}";
		}
	}
}
