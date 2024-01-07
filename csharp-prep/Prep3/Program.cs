using System;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            PlayGame();

            Console.WriteLine("Do you want to play again? (yes/no)");
            string answer = Console.ReadLine().ToLower(); 

            if (answer != "yes")
            {
                Console.WriteLine("Thanks for playing. Goodbye!");
                break; 
            }

        } while (true);
    }

    static void PlayGame()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int magicNumber;
        int attempts = 0;

        do
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();

            bool isValidInput = int.TryParse(userInput, out magicNumber);

            if (!isValidInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            if (magicNumber > number)
            {
                Console.WriteLine("Lower");
                attempts++;
            }
            else if (magicNumber < number)
            {
                Console.WriteLine("Higher");
                attempts++;
            }
            else
            {
                Console.WriteLine("Congratulations!");
                Console.WriteLine($"Your attempts: {attempts}");
            }

        } while (magicNumber != number);
    }
}
