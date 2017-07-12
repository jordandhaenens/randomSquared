using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            
            Random rando = new Random();
            while (numbers.Count < 20)
            {
                numbers.Add(rando.Next(1, 50));
            }

            List<int> squared = new List<int>();
            foreach (int num in numbers) {
                squared.Add(num * num);
            }

            squared = squared.Where()
            foreach (int num in squared) {
                
            }
            foreach (int num in squared) {
                Console.WriteLine(num);
            }
        }
    }
}
