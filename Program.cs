using System;
using arr;

namespace genarr
{
    class Program
    {
        static void Main(string[] args)
        {
            Array<int> A = new Array<int>(7);
            A.Set(3, 11);
            A[4] = 7;
            Console.WriteLine($"A = {A}");
            Console.WriteLine($"{A[3]}");
            Array<int> B = new Array<int>(new int[] { 1, 2, 3, 4 }); // Överkurs!
            Console.WriteLine($"B = {B}");
        }
    }
}
