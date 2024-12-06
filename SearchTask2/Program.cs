
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            CheckForVowels(input);

            Console.WriteLine("The string contains vowels.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void CheckForVowels(string input)
    {
        string vowels = "aeiouAEIOU";

        foreach (char c in input)
        {
            if (vowels.Contains(c))
            {
                return; 
            }
        }

        throw new Exception("The string does not contain any vowels.");
    }
}
