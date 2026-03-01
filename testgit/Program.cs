using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testgit
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            PrintArray("Array", arr);
            PrintArray("Even Numbers", arr.Where(x=>IsEven(x)));
            PrintArray("Odd Numbers", arr.Where(x=>IsOdd(x)));

        }
        static void PrintArray(string title, IEnumerable<int> arr)
        {
            
            Console.WriteLine($"{title}: [");
            Console.WriteLine();
            foreach (int i in arr)
            {
                Console.Write(i);
            }
            Console.WriteLine($"]");
            Console.WriteLine();
        }
        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }
    }
}