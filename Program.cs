using System;

namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------------Exercise 1---------------------
            //Name: Marias
            //Favorite Color: Red
            //Favorite Animal: Lion
            //Favorite Band: The Gap Band

            Console.WriteLine("Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What's your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Oh that's nice!! I like the {animal} as well. What's your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks {userName}! Here is your profile.");
            Console.WriteLine("-------------------------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");

        }
    }
}
