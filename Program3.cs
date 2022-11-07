using GenericBoxOfInteger;
using System;

namespace GenericBoxOfInte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integers:");
            int n = int.Parse(Console.ReadLine());

            List<BoxOfInt<int>> boxes = new List<BoxOfInt<int>>() ;

            for(int i = 0; i < n; i++)
            {
                int integers = int.Parse(Console.ReadLine());
                boxes.Add(new BoxOfInt<int>(integers));
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(boxes[i].ToString());
            }
        }
    }
}