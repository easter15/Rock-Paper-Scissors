
Random random = new Random();
bool playAgain = true;
string player;
string computer;
string answer;

while (playAgain)
{

    player = "";
    computer = "";
    answer = "";

    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
    {
        Console.Write("Enter ROCK, PAPER or SCISSORS: ");
        player = Console.ReadLine();
        player = player.ToUpper();
    }

    
    switch (random.Next(1, 4))
    {
        case 1:
            computer = "ROCK";
            break;
        case 2:
            computer = "PAPER";
            break;
        case 3:
            computer = "SCISSORS";
            break;
             
    }
    Console.WriteLine("Player: " + player);
    Console.WriteLine("Computer: " + computer);

    switch (player)
    {
        case "ROCK":
            if (computer == "ROCK")
            {
                Console.WriteLine("I's a draw\n");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("Computer wins!\n");
            }
            else
            {
                Console.WriteLine("You win!\n");
            }
            break;
        case "PAPER":
            if (computer == "ROCK")
            {
                Console.WriteLine("You win!\n");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("It's a draw!\n");
            }
            else
            {
                Console.WriteLine("Computer wins!\n");
            }
            break;
        case "SCISSORS":
            if (computer == "ROCK")
            {
                Console.WriteLine("Computer wins!\n");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("You win!\n");
            }
            else
            {
                Console.WriteLine("It's a draw!\n");
            }
            break;
    }

    Console.Write("Would you like to play again? (Y/N): ");
    answer = Console.ReadLine();
    answer = answer.ToUpper();

    if (answer == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
    }
}     

Console.WriteLine("Goodbye and thank you for playing");
Console.ReadKey();