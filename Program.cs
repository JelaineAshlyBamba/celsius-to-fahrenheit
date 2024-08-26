namespace celsiustofahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for the temperature in Celsius
            Console.Write("Enter temperature in Celsius: ");
            
            // Read the input from the user
            string input = Console.ReadLine();

            // Convert the input to a double
            double celsius;
            if (double.TryParse(input, out celsius))
            {
                // Convert Celsius to Fahrenheit
                double fahrenheit = (celsius * 9 / 5) + 32;
                
                // Display the result
                Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}