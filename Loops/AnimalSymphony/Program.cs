using System;
using System.Media;

namespace AnimalSymphony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // list of possible animals
            string[] animals = { "horse", "cow", "dog", "cat", "sheep", "monkey", "chicken" };

            // pick a random animal
            Random random = new Random();
            int animalIndex = random.Next(0, animals.Length);
            string chosenAnimal = animals[animalIndex];

            // states
            string userInput = "";

            // get audio
            Console.WriteLine("Which animal makes this sound?");
            SoundPlayer soundplayer = new SoundPlayer();
            string animalAudioName = $"{chosenAnimal}.wav";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "audio", animalAudioName); // relative path
            soundplayer.SoundLocation = path;

            // game
            while (userInput != chosenAnimal)
            {
                soundplayer.Play();
                userInput = Console.ReadLine().ToLower();

                if (userInput == chosenAnimal) // the user guesses correctly
                {
                    Console.WriteLine($"Congratulations! You guessed correctly, the animal is a {chosenAnimal}.");
                    return;
                }

                Console.WriteLine("That's not correct, try again.");
            }
        }
    }
}
