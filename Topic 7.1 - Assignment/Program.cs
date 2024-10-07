// See https://aka.ms/new-console-template for more information
Random generator = new Random();
string userInput;
int points = 3, randNum;
bool quit = false;
while (points > 0 && !quit)
{
    randNum = generator.Next(1, 3);
    Console.WriteLine("You currently have " + points + " points.");
    Console.WriteLine("Would you like to choose heads or tails, or do you want to quit?");
    Console.WriteLine();
    userInput = Console.ReadLine();
    Console.WriteLine();
    if (userInput.ToLower() == "heads")
    {
        if (randNum == 1)
        {
            Console.WriteLine("Heads");
            points += 1;
        }
        else if (randNum == 2)
        {
            Console.WriteLine("Tails");
            points -= 1;
            if (points == 0)
                Console.WriteLine("Sorry, you've run out of points.");
        }
    }
    else if (userInput.ToLower() == "tails")
    {
        if (randNum == 2)
        {
            Console.WriteLine("Tails");
            points += 1;
        }
        else if (randNum == 1)
        {
            Console.WriteLine("Heads");
            points -= 1;
            if (points == 0)
                Console.WriteLine("Sorry, you've run out of points.");
        }
    }
    else if (userInput.ToLower() == "quit")
    {
        quit = true;
        Console.WriteLine("You ended the game with " + points + " points. Thanks for playing.");
    }
}