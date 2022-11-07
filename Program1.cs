using System;
using System.Reflection;

namespace GenericBoxOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strings:");
            int n = int.Parse(Console.ReadLine());

            List<Box<string>> boxes = new List<Box<string>>();
            for (int i = 0; i < n; i++)
            {
                string strings = Console.ReadLine();
                boxes.Add(new Box<string>(strings));               
            }

            for(int i = 0; i < boxes.Count; i++)
            {
                Console.WriteLine(boxes[i].ToString());
            }
        }
    }
}