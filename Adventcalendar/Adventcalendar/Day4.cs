using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Adventcalendar
{
    class Day4
    {
        public static string Part1()
        {
            string input = File.ReadAllText(@"..\..\Day4.txt");
            int i = 0;

            while (true)
            {
                string source = input + i;
                string hash;

                using (MD5 md5Hash = MD5.Create())
                {
                    hash = GetMd5Hash(md5Hash, source);
                }

                if (hash.StartsWith("00000"))
                {
                    break;
                }

                i++;
            }

            return i.ToString();
        }

        public static string Part2()
        {
            string input = File.ReadAllText(@"..\..\Day4.txt");
            int i = 0;

            while (true)
            {
                string source = input + i;
                string hash;

                using (MD5 md5Hash = MD5.Create())
                {
                    hash = GetMd5Hash(md5Hash, source);
                }

                if (hash.StartsWith("000000"))
                {
                    break;
                }

                i++;
            }

            return i.ToString();
        }

        private static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            /* format as a hexadecimal string */
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
