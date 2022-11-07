using System;

namespace SwapIntBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integers:");
            int n = int.Parse(Console.ReadLine());

            List<SwapInt<int>> boxes = new List<SwapInt<int>>();
            for (int i = 0; i < n; i++)
            {
                int ints = int.Parse(Console.ReadLine());
                boxes.Add(new SwapInt<int>(ints));
            }

            Console.WriteLine("Swap indexes:");
            int[] swap = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SwapInt<int> temp = boxes[swap[1]];
            boxes[swap[1]] = boxes[swap[0]];
            boxes[swap[0]] = temp;

            for (int i = 0; i < boxes.Count; i++)
            {
                Console.WriteLine(boxes[i].ToString());
            }

        }
    }
}