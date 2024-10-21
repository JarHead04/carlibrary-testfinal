using System;
using CarLibrary;  // Ensure this is present to reference the CarLibrary

namespace CarTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create a new instance of Engine
            Engine engine = new Engine(4, 210);  // 4 cylinders, 210 horsepower

            // Step 2: Create a new instance of Car
            Car myCar = new Car("Ford", "Fiesta", 2016, engine);

            // Step 3: Display car information
            Console.WriteLine($"Car Make: {myCar.Make}, Model: {myCar.Model}, Year: {myCar.Year}");

            // Step 4: Call Drive method - this starts the engine and prints "Driving started..."
            myCar.Drive();

            // Step 5: Call Stop method - this stops the engine and prints "Driving stopped..."
            myCar.Stop();

            // Keep the console window open to observe the output
            Console.ReadLine();
        }
    }
}
