using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
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

            var myBird = new Bird();
            myBird.Flies = true;
            myBird.Claws = true;
            myBird.Nocturnal = false;
            myBird.Migrates = false;
            myBird.Legs = 2;
            myBird.Tail = false;
            myBird.Swims = false;


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var myReptile = new Reptile()
            {
                Vertabrate = true,
                ShedsSkin = false,
                ProduceEggs = true,
                ColdBlooded = true,
                Legs = 4,
                Tail = true,
                Swims = true
            };

            var myAnimals = new Animal[] {myBird, myReptile};
            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"My pet has eyes, that's {animal.Eyes.ToString().ToLower()}.");
                Console.WriteLine($"My pet has {animal.Legs} legs.");
                Console.WriteLine($"My pet does have a tail, that's {animal.Tail.ToString().ToLower()}.");
                Console.WriteLine($"My pet swims, that's {animal.Swims.ToString().ToLower()}.");
                Console.WriteLine();
            }
        }
    }
}
