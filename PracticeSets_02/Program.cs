using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSets_02
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int num = 1; num <=20; num++)
            {
                if (num % 2 == 1)
                {
                    Console.WriteLine(+num + " odd numbers");
                }
                
            }
        }
    }
}
