using System;

namespace Adventcalendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 1: Part 1: " + Day1.Part1() + ". Floor; Part 2: " + Day1.Part2() + ". Position");
            Console.WriteLine("Day 2: Part 1: " + Day2.Part1() + " Square feet of paper; Part 2: " + Day2.Part2() + " Feet of ribbon");
            Console.WriteLine("Day 3: Part 1: " + Day3.Part1() + " Houses; Part 2: " + Day3.Part2() + " Houses");
            //Console.WriteLine("Day 4: Part 1: " + Day4.Part1() + " Number; Part 2: " + Day4.Part2() + " Number");                         // takes too long
            Console.WriteLine("Day 5: Part 1: " + Day5.Part1() + " Nice strings; Part 2: " + Day5.Part2() + " Nice strings");
            Console.Read();
        }     
    }
}
