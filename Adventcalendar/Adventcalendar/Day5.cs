using System.IO;

namespace Adventcalendar
{
    class Day5
    {
        public static string Part1()
        {
            string input = File.ReadAllText(@"..\..\Day5.txt").Replace("\r", "");
            string[] strings = input.Split('\n');
            int niceStrings = 0;

            foreach (string s in strings)
            {
                int vovels = 0;
                char lastChar = ' ';
                int doubleLetters = 0;

                foreach (char c in s)
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        vovels++;
                    }

                    if (c == lastChar)
                    {
                        doubleLetters++;
                    }

                    lastChar = c;
                }

                if (vovels < 3 || doubleLetters < 1)
                {
                    continue;
                }

                if (s.Contains("ab") || s.Contains("cd") || s.Contains("pq") || s.Contains("xy"))
                {
                    continue;
                }

                niceStrings++;
            }

            return niceStrings.ToString();
        }

        public static string Part2()
        {
            string input = File.ReadAllText(@"..\..\Day5.txt").Replace("\r", "");
            string[] strings = input.Split('\n');
            int niceStrings = 0;

            foreach (string s in strings)
            {
                bool hasTwoPairs = false;
                bool hasRepeatedLetter = false;

                for (int i = 0; i < s.Length; i++)
                {
                    if (i > 0)
                    {
                        string pair = s[i - 1].ToString() + s[i].ToString();
                        string before = "";
                        string after = "";

                        for (int j = 0; j < s.Length; j++)
                        {
                            if (j < i - 1)
                            {
                                before += s[j];
                            } else if (j > i)
                            {
                                after += s[j];
                            }
                        }

                        if (before.Contains(pair) || after.Contains(pair))
                        {
                            hasTwoPairs = true;
                        }
                    }
                    
                    if (i < s.Length - 2 && s[i] == s[i + 2])
                    {
                        hasRepeatedLetter = true;
                    }
                }

                if (hasTwoPairs && hasRepeatedLetter)
                {
                    niceStrings++;
                }
            }

            return niceStrings.ToString();
        }
    }
}
