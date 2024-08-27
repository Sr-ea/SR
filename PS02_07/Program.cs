namespace PS02_07
{
    internal class Program
    {
        static void Main(string[] args) // SHEILA
        {
            int[] arr = new int[5]; 
            int sum = 0;

            Console.WriteLine("Enter 5 numbers: ");
            for (int i = 0; i < 5; i++)

            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }

            sum = 0;
            int j = 0;
            while (j < arr.Length)
            {
                sum += arr[j];
                j++;
            }

            Console.WriteLine("The sum of array elements is: " + sum);
        }
    }
}
