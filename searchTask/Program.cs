
namespace searchTask
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a list of integers separated by commas:");
                string input = Console.ReadLine();
                string[] numbers = input.Split(',');

                List<int> list = new List<int>();
                int duplicateCount = 0;

                foreach (var number in numbers)
                {
                    int num = int.Parse(number.Trim());

                    if (list.Contains(num))
                    {
                        duplicateCount++;
                    }
                    else
                    {
                        list.Add(num); 
                    }
                }

                if (duplicateCount > 0)
                {
                    Console.WriteLine($"Total duplicate numbers: {duplicateCount}");
                }
                else
                {
                    Console.WriteLine("No duplicates found.");
                }
            }
            catch
            {
                Console.WriteLine("Error: Please enter valid integers separated by commas.");
            }
        }
    }
}
