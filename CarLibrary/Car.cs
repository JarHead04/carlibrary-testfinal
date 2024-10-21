namespace CarLibrary
{
    public class Car
    {
        // Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Engine Engine { get; set; } // Composition

        // Default constructor
        public Car() { }

        // Custom constructor
        public Car(string make, string model, int year, Engine engine)
        {
            Make = make;
            Model = model;
            Year = year;
            Engine = engine;
        }

        // Method to drive the car
        public void Drive()
        {
            Engine.Start(); // Set a breakpoint here
            Console.WriteLine("Driving started..."); // Set a breakpoint here
        }

        // Method to stop the car
        public void Stop()
        {
            Engine.Stop(); // Set a breakpoint here
            Console.WriteLine("Driving stopped..."); // Set a breakpoint here
        }
    }
}
