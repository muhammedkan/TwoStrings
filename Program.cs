using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoStrings
{
    class Program
    {
        static string twoStrings(string s1, string s2)
        {
            s1 = new string(s1.ToCharArray().Distinct().ToArray());
            s2 = new string(s2.ToCharArray().Distinct().ToArray());

            int min = Math.Min(s1.Length, s2.Length);
            string temp1, temp2;
            if (min == s1.Length)
            {
                temp1 = s1;
                temp2 = s2;
            }
            else
            {
                temp1 = s2;
                temp2 = s1;
            }

            for (int i = 0; i < min; i++)
            {
                if (temp2.Contains(temp1[i]))
                    return "YES";
            }
            return "NO";

        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32("2");

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s1 = Console.ReadLine();

                string s2 = Console.ReadLine();

                string result = twoStrings(s1, s2);
                Console.WriteLine(result);
                //textWriter.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
