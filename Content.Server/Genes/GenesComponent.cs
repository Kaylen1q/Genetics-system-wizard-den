namespace Content.Server.Genes;

[RegisterComponent]
public sealed partial class GenesComponent : Component
{
    public void InitializeButtonValues()
    {
        Random random = new Random();

        // Define the maximum value (decimal equivalent of "DAc")
        const int maxDecimal = 0xDAC;

        // Array to store button values (55 sets of 3 buttons each)
        string[,] buttonValues = new string[55, 3];

        // Fill the array with random hexadecimal values
        for (int i = 0; i < 55; i++) // Loop for sets
        {
            for (int j = 0; j < 3; j++) // Loop for each button in a set
            {
                // Generate a random number below the maxDecimal
                int randomDecimal = random.Next(maxDecimal);

                // Convert the number to hexadecimal and store in the array
                buttonValues[i, j] = randomDecimal.ToString("X");
            }
        }

        // Display the values for demonstration
        for (int i = 0; i < 55; i++)
        {
           // Console.WriteLine($"{i + 1}button.1: {buttonValues[i, 0]}");
            ///Console.WriteLine($"{i + 1}button.2: {buttonValues[i, 1]}");
            //sole.WriteLine($"{i + 1}button.3: {buttonValues[i, 2]}");
        }
    }
}
