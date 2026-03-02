namespace Superheroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Superhero superman = new Superhero("Superman", "Super strength", "Kryptonite");
            Superhero spiderman = new Superhero("Spider-Man", "Wall-crawling", "Vulnerability to sonic attacks");
            Superhero wonderwoman = new Superhero("Wonder Woman", "Superhuman combat skill", "Can be restrained by magical bindings");
            Superhero batman = new Superhero("Batman", "Genius-level intellect", "No superhuman abilities");
            Superhero thor = new Superhero("Thor", "Control over lightning", "Worthiness requirement to wield Mjolnir");
            Superhero ironman = new Superhero("Iron Man", "Advanced powered armor", "Dependence on technology");
            Superhero hulk = new Superhero("Hulk", "Strength increases with anger", "Struggles to control his rage");

            superman.Introduce();
            spiderman.Introduce();
            wonderwoman.Introduce();
            batman.Introduce();
            thor.Introduce();
            ironman.Introduce();
            hulk.Introduce();
        }
    }
}
