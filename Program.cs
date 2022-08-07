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
            }
    }
}
