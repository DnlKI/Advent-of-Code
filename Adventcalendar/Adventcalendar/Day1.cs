using System.IO;

namespace Adventcalendar
{
    class Day1
    {
        public static string Part1()
        {
            string input = File.ReadAllText(@"..\..\Day1.txt");
            int floor = 0;

            foreach (char c in input)
            {
                if (c == '(')
                {
                    floor++;
                }
                else if (c == ')')
                {
                    floor--;
                }
            }
            return floor.ToString();
        }

        public static string Part2()
        {
            string input = File.ReadAllText(@"..\..\Day1.txt");
            int floor = 0;
            int position = 0;

            foreach (char c in input)
            {
                if (c == '(')
                {
                    floor++;
                }
                else if (c == ')')
                {
                    floor--;
                }

                position++;

                if (floor == -1)
                {
                    break;
                }
            }
            return position.ToString();
        }
    }
}
