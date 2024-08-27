namespace PS02_05
{
    internal class Program
    {
        static void Main(string[] args) // rhea
        {
            Console.Write("Enter a string: ");
            string word = Console.ReadLine();

            foreach (var word1 in word.GroupBy(c => c))
            {
                Console.Write($"Character '{word1.Key}' {word1.Count()} times"); 
            }
        }
    }
}
