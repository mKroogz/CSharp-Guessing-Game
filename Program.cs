using System;

namespace guessing_game
{
    class Program
    {
        static int difficulty(){
            while(true) {
                Console.WriteLine("  ***  Difficulty Menu  ***  ");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Easy - 8 Guesses (E)");
                Console.WriteLine("Medium - 6 Guesses (M)");
                Console.WriteLine("Hard - 4 Guesses (H)");
                Console.WriteLine("Cheater - Unlimited Guesses (C)");
                Console.Write("Choose your difficulty: ");
                string diff = Console.ReadLine();
                if (diff == "e" || diff == "E") {
                    return 8;
                } else if (diff == "m" || diff == "M") {
                    return 6;
                } else if (diff == "h" || diff == "H") {
                    return 4;
                } else if (diff == "c" || diff == "C") {
                    return 10;
                } else {
                    Console.WriteLine("Please choose valid difficulty.");
                }
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secretNumber  = rnd.Next(1, 101);
            Console.WriteLine("   ****   Guessing Game   ****   ");
            int guessNum = difficulty();
            for (int i = 0; i < guessNum; i++){
            Console.Write("Guess the secret number between 1-100: ");
            int guess;
            int.TryParse(Console.ReadLine(), out guess);
            if(guess == secretNumber){
                Console.WriteLine("Correct!");
                i = guessNum;
            } else if (guess < 1 || guess > 100) {
                Console.WriteLine("Please enter a number between 1-100");
                i--;
            } else {
                if (guess > secretNumber) {
                    Console.WriteLine("Too High!");
                } else {
                    Console.WriteLine("Too Low!");
                }
                if (guessNum < 10) {
                    Console.WriteLine($"Your guess ({i + 1})> {guess}");
                    Console.WriteLine($"{guessNum - 1 - i} guesses remaining");
                } else {
                    i = 0;
                    Console.WriteLine($"Your guess> {guess}");
                }
            }
            }
        }
    }
}
