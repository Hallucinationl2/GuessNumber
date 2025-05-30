using System;

class GuessGame
{
    static void Main()
    {
        Random rng = new Random();
        int number = rng.Next(1, 101);
        int guess, tries = 0;

        Console.WriteLine("Познай числото между 1 и 100");
        do
        {
            Console.Write("Вашият избор: ");
            guess = int.Parse(Console.ReadLine());
            tries++;

            if (guess < number) Console.WriteLine("По-голямо!");
            else if (guess > number) Console.WriteLine("По-малко!");
            else Console.WriteLine($"Познахте за {tries} опита!");
        } while (guess != number);
    }
}