using System;

namespace Upgift_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många heltal vill du skriva in");
            int antal = int.Parse(Console.ReadLine());
            string[] heltal = new string[antal];
            
            for(int i = 0; i < antal; i++)
            {

                Console.WriteLine("skriv dina heltal");
                heltal[i] = Console.ReadLine();
            }
            Console.WriteLine("här är dina tal");
            for(int i = 0; i < antal; i++)
            {
                Console.Write($"Tal{i+1}: {heltal[i]}\n"); 
            }

        }
    }
}