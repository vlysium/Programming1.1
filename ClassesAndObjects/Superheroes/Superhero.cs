namespace Superheroes
{
    public class Superhero
    {
        private string _name;
        private string _superpower;
        private string _weakness;

        /// <summary>
        /// Initializes a new instance of the Superhero class with the specified name, superpower, and weakness.
        /// </summary>
        /// <param name="name">The name of the superhero.</param>
        /// <param name="superpower">The superpower of the superhero.</param>
        /// <param name="weakness">The weakness of the superhero.</param>
        public Superhero(string name, string superpower, string weakness)
        {
            _name = name;
            _superpower = superpower;
            _weakness = weakness;
        }

        public string Name { get => _name; }
        public string Superpower { get => _superpower; }
        public string Weakness { get => _weakness; }

        /// <summary>
        /// Introduces the superhero by printing their name, superpower, and weakness to the console.
        /// </summary>
        public void Introduce()
        {
            Console.WriteLine($"I am {Name}, my superpower is {Superpower} and my weakness is {Weakness}.");
        }

        
        public override string ToString()
        {
            return $"Superhero: {Name}, Superpower: {Superpower}, Weakness: {Weakness}";
        }
    }
}
