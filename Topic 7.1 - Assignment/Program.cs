// See https://aka.ms/new-console-template for more information
Random generator = new Random();
string userInput;
int points = 3, randNum, bet;
bool quit = false;
Console.WriteLine("This is a coin game of heads or tails.");
while (points > 0 && !quit)
{
    randNum = generator.Next(1, 3);
    Console.WriteLine("You currently have " + points + " points.");
    Console.WriteLine("How much would you like to bet? Do not bet more than you already have.");
    Console.WriteLine();
    Int32.TryParse(Console.ReadLine(), out bet);
    Console.WriteLine("Would you like to choose heads or tails, or do you want to quit?");
    Console.WriteLine();
    userInput = Console.ReadLine();
    Console.WriteLine();
    if (bet > points)
        Console.WriteLine("Sorry, you can't bet that.");
    else if (userInput.ToLower() == "heads")
    {
        if (randNum == 1)
        {
            Console.WriteLine("Result: Heads");
            points += bet;
        }
        else if (randNum == 2)
        {
            Console.WriteLine("Result: Tails");
            points -= bet;
            if (points <= 0)
                Console.WriteLine("Sorry, you've run out of points.");
        }
    }
    else if (userInput.ToLower() == "tails")
    {
        if (randNum == 2)
        {
            Console.WriteLine("Result: Tails");
            points += bet;
        }
        else if (randNum == 1)
        {
            Console.WriteLine("Result: Heads");
            points -= bet;
            if (points <= 0)
                Console.WriteLine("Sorry, you've run out of points.");
        }
    }
    else if (userInput.ToLower() == "quit")
    {
        quit = true;
        Console.WriteLine("You ended the game with " + points + " points. Thanks for playing.");
    }
}