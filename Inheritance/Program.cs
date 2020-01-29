using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Space()
            {
                Console.WriteLine();
            }

            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var flamingo = new Bird();
            flamingo.Type = "flamingo";
            flamingo.FlightSpeed = 2;
            flamingo.IsFlamingo = true;
            flamingo.Size = "biggish";
            flamingo.WingSpan = 900;

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Today we will be learning about the {flamingo.Type} bird. " +
                $" The answer to if it is a living thing or not: {flamingo.IsLiving}. " +
                $"This bird has a flight speed of {flamingo.FlightSpeed} mph. " +
                $"If you are wondering whether it has feathers: {flamingo.HasFeathers}. " +
                $"It has {flamingo.Legs} legs, and most scientists describe its size as {flamingo.Size} " +
                $"with a wingspan of {flamingo.WingSpan}."
                );

            Space();
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */



            var snake = new Reptile()
            {
                CanSwim = true,
                Legs = 0,
                Length = 10,
                Size = "too big",
                Type = "Snake",
            };
            Console.WriteLine($"Type: {snake.Type}. Can Swim? {snake.CanSwim}. Has feathers? {snake.HasFeathers}. " +
                $"Legs? {snake.Legs}. Length? {snake.Length} feet. Size? {snake.Size}. Alive? {snake.IsLiving}. " +
                $"Pretty? {snake.IsPretty}.");
           




        }

    }
}
