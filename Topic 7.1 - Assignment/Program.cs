// See https://aka.ms/new-console-template for more information
Random generator = new Random();
string userInput;
int points = 3, randNum;
bool quit = false;
while (points > 0 && !quit)
{
    randNum = generator.Next(1, 2);
    Console.WriteLine("You currently have " + points + " points.");
    Console.WriteLine("Would you like to choose heads or tails, or do you want to quit?");
    userInput = Console.ReadLine();
    if (randNum == 1)
    {
        Console.WriteLine("Heads");
        if (userInput.ToLower() == "heads")
            points += 1;
        else if (userInput.ToLower() == "tails")
            points -= 1;
    }
    else if (randNum == 2)