namespace PlasticFantastic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard1 = new CreditCard("1234 5678 9012 3456", CardType.Dankort);
            Console.WriteLine(creditCard1.ToString());

            CreditCard creditCard2 = new CreditCard("1234 5678 9012 3456", CardType.Visa, 5000);
            Console.WriteLine(creditCard2.ToString());

            CreditCard creditCard3 = new CreditCard("1234 5678 9012 3456", CardType.MasterCard, 10000, "John Doe");
            Console.WriteLine(creditCard3.ToString());
        }
    }
}
