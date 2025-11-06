using System;


namespace uppgift_2._1
{
       class Program
    {
        static void Main(string[] args)
        {
               Console.WriteLine("vilken är din favoritbok?");
               int favoritbok = int.Parse(Console.ReadLine());
               Console.WriteLine("Din favoritbok är" + favoritbok);
        }
    }
}
