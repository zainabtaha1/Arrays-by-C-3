using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    internal class Program
    {
        static void Main(string[] args)
        { // Jagged Array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 3, 4, 5 };
            jaggedArray[1] = new int[] { 90, 7 };
            jaggedArray[2] = new int[] { 13, 74, 58, 0 };
            int i, j;
            for (i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(" Numbers ({0}) are: ", i);
                for (j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray [i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
