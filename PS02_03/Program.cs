using System;

namespace PS02_03
{
    internal class Program
    {

        static void Main(string[] args) //rhea
        {

            Console.Write("Enter a letter: ");
            char chara = char.Parse(Console.ReadLine().ToLower());

            if (chara == 'a' || chara == 'e' || chara == 'i' || chara == 'o' || chara == 'u')
            {
                Console.Write($"letter {chara} is a vowel");
            }

            else
            {
                Console.Write($"letter {chara} is a consonant"); 
            }




        }
    }
}
