namespace CarLibrary
{
    public class Engine
    {
        // Properties
        public int Cylinders { get; set; }
        public double Horsepower { get; set; }

        // Default constructor
        public Engine() { }

        // Custom constructor
        public Engine(int cylinders, double horsepower)
        {
            Cylinders = cylinders;
            Horsepower = horsepower;
        }

        // Method to start the engine
        public void Start()
        {
            Console.WriteLine("Engine starting..."); // Set a breakpoint here
        }

        // Method to stop the engine
        public void Stop()
        {
            Console.WriteLine("Engine stopping..."); // Set a breakpoint here
        }
    }
}
