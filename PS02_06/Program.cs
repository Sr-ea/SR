namespace PS02_06
{
    internal class Program
    {
        static void Main(string[] args) // rhea
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            while (num > 0)
            {
                sum += num % 10; 
                num /= 10;
            }

            Console.Write("Sum of digits: " + sum);
        }
    }
}
