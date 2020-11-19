using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningSwapArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6 };
            Console.Write("Array1 = ");
            Console.WriteLine(string.Join(",", array1));

            int x = 0;
            int z = array1.Length - 1;
            while (x < z)
            {
                int reverse = array1[x];
                array1[x] = array1[z];
                array1[z] = reverse;
                x++;
                z--;
            }
            Console.Write("Array2 = ");
            Console.WriteLine(string.Join(",", array1));
        }
    }
}
