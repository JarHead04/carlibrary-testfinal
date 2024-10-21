using System;
using CarLibrary;  // Reference the CarLibrary namespace

namespace CarTest
{
    class Program
    {
        static void Main(string[] args)  // Entry point
        {
            // Create an Engine object
            Engine myEngine = new Engine(6, 300.0);

            // Create a Car object using the custom constructor
            Car myCar = new Car("Toyota", "Camry", 2024, myEngine);

            // Test the Car's methods
            Console.WriteLine($"Car Make: {myCar.Make}, Model: {myCar.Model}, Year: {myCar.Year}");
            myCar.Drive();  // This will start the engine and print "Driving started..."
            myCar.Stop();   // This will stop the engine and print "Driving stopped..."

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
