using System;
using ArrayMinMaxSolution.Service;

namespace ArrayMinMaxSolution.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution Sol = new Solution(new int[]{ 1, 7, 3, 4, 5 });
            Console.WriteLine("Min element not present in Array " + Sol.MinElementNonInArray);
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
