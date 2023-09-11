namespace consoleApp5
{
    enum Beverage
    {
        Coffee,
        Tea,
        Water,
        Soda,
        Juice,

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( " Welcome to the awsome vending machine");
            Console.WriteLine( " Which beverage do you prefer? ( Coffe,Tea, Water, Soda,Juice ");
            string userInput = Console.ReadLine();

            switch(userInput.ToLower())
            {
                case "coffee":
                    Respond(Beverage.Coffee); 
                    break;
                case "water":
                    Respond(Beverage.Water);
                    break;
                case "tea":
                    Respond(Beverage.Tea);
                    break;
                case "soda":
                    Respond(Beverage.Soda);
                    break;
                case "juice":
                    Respond(Beverage.Juice);
                    break;
                default:
                    Console.WriteLine(" Invalid input, this drink does not exist");
                    break;

            }

        }
        static void Respond(Beverage drink)
        {
            switch (drink)
            {
                case Beverage.Coffee:
                    Console.WriteLine( " You orderd kaffe latte");
                    break;
                case Beverage.Water:
                    Console.WriteLine(" You choose water, why though?");
                    break;
                case Beverage.Tea:
                    Console.WriteLine(" You ordered Tea , jukky ");
                    break;
                case Beverage.Soda:
                    Console.WriteLine(" Nice choice, bebsi cola");
                    break;
                case Beverage.Juice:
                    Console.WriteLine(" One orange juice comming your way!");
                    break;

            }
        }
    }
}