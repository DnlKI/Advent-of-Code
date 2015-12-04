using System;
using System.IO;

namespace Adventcalendar
{
    class Day2
    {
        public static string Part1()
        {
            string input = File.ReadAllText(@"..\..\Day2.txt").Replace("\r", "");
            string[] boxes = input.Split('\n');
            int sqares = 0;

            foreach (string s in boxes)
            {
                string[] box = s.Split('x');
                int[] sides = Array.ConvertAll(s.Split('x'), int.Parse);
                Array.Sort(sides);
                sqares += 3 * sides[0] * sides[1] + 2 * sides[0] * sides[2] + 2 * sides[1] * sides[2];
            }

            return sqares.ToString();
        }

        public static string Part2()
        {
            string input = File.ReadAllText(@"..\..\Day2.txt").Replace("\r", "");
            string[] boxes = input.Split('\n');
            int ribbon = 0;

            foreach (string s in boxes)
            {
                string[] box = s.Split('x');
                int[] sides = Array.ConvertAll(s.Split('x'), int.Parse);
                Array.Sort(sides);
                ribbon += 2 * sides[0] + 2 * sides[1] + sides[0] * sides[1] * sides[2];
            }

            return ribbon.ToString();
        }
    }
}
