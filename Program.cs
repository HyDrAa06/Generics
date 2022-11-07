using System;

namespace SwapStringBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strings:");
            int n = int.Parse(Console.ReadLine());

            List<SwapString<string>> boxes = new List<SwapString<string>>();
            for (int i = 0; i < n; i++)
            {
                string strings = Console.ReadLine();
                boxes.Add(new SwapString<string>(strings));
            }
             
            Console.WriteLine("Swap indexes:");
            int[] swap = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SwapString<string> temp = boxes[swap[1]];
            boxes[swap[1]] = boxes[swap[0]];
            boxes[swap[0]] = temp;

            for (int i = 0; i < boxes.Count; i++)
            {       
                Console.WriteLine(boxes[i].ToString());
            }
        }
    }
}