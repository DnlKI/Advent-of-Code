using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Adventcalendar
{
    class Day3
    {
        public static String Part1()
        {
            string input = File.ReadAllText(@"..\..\Day3.txt");
            List<Point> deliveredHouses = new List<Point>();
            Point position = new Point(0, 0);
            deliveredHouses.Add(position);

            foreach (Char c in input)
            {
                switch (c)
                {
                    case '^':
                        position.Y += 1;
                        break;
                    case 'v':
                        position.Y -= 1;
                        break;
                    case '>':
                        position.X += 1;
                        break;
                    case '<':
                        position.X -= 1;
                        break;
                    default:
                        continue;
                }

                if (!deliveredHouses.Contains(position))
                {
                    deliveredHouses.Add(position);
                }
            }

            return deliveredHouses.Count.ToString();
        }

        public static string Part2()
        {
            string input = File.ReadAllText(@"..\..\Day3.txt");
            List<Point> deliveredHouses = new List<Point>();
            Point position = new Point(0, 0);
            deliveredHouses.Add(position);

            /* Santa */
            for (int i = 0; i < input.Length; i += 2)
            {
                switch (input[i])
                {
                    case '^':
                        position.Y += 1;
                        break;
                    case 'v':
                        position.Y -= 1;
                        break;
                    case '>':
                        position.X += 1;
                        break;
                    case '<':
                        position.X -= 1;
                        break;
                    default:
                        continue;
                }

                if (!deliveredHouses.Contains(position))
                {
                    deliveredHouses.Add(position);
                }
            }

            position = new Point(0, 0);

            /* Robo-Santa */
            for (int i = 1; i < input.Length; i += 2)
            {
                switch (input[i])
                {
                    case '^':
                        position.Y += 1;
                        break;
                    case 'v':
                        position.Y -= 1;
                        break;
                    case '>':
                        position.X += 1;
                        break;
                    case '<':
                        position.X -= 1;
                        break;
                    default:
                        continue;
                }

                if (!deliveredHouses.Contains(position))
                {
                    deliveredHouses.Add(position);
                }
            }

            return deliveredHouses.Count.ToString();
        }
    }
}
