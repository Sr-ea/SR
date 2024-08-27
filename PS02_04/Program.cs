namespace PS02_04
{
    internal class Program
    {
        static void Main(string[] args) // SHEILA
        {
            Console.WriteLine("Enter string: ");
            string input = Console.ReadLine().ToLower();

            int left = 0;
            int right = input.Length - 1;
            
            bool isPalindrome = true; 
            while (left < right)
            {
                if (input[left] != input[right])
                {
                    isPalindrome = false;
                    break;
                }
                left++;
                right--;
                    if (isPalindrome)
                    {
                        Console.WriteLine(" The string is Palindrome");
                    }
                    else
                    {
                        Console.WriteLine(" The string is not a Palindrome");
                    }
            }
        }
    }
}
