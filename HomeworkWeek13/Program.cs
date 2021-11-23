using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeworkWeek13
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> BoyNames = new Dictionary<string, int>();
            Dictionary<string, int> BoyRanks = new Dictionary<string, int>();
            using (StreamReader s = new StreamReader("boynames.txt"))
            {
                int rank = 1;
                string line = null;
                while ((line = s.ReadLine()) != null)
                {
                    string[] temp = line.Split(' ');
                    BoyNames.Add(temp[0], int.Parse(temp[1]));
                    BoyRanks.Add(temp[0], rank);
                    rank++;
                }
            }

            Dictionary<string, int> GirlNames = new Dictionary<string, int>();
            Dictionary<string, int> GirlRanks = new Dictionary<string, int>();
            using (StreamReader s = new StreamReader("girlnames.txt"))
            {
                string line = null;
                int rank = 1;
                while ((line = s.ReadLine()) != null)
                {
                    string[] temp = line.Split(' ');
                    GirlNames.Add(temp[0], int.Parse(temp[1]));
                    GirlRanks.Add(temp[0], rank);
                    rank++;
                }
            }

            Console.WriteLine("Enter a Name to see how popular of a boy's and/or girl's name it is!");
            string input = Console.ReadLine();

            if (BoyNames.ContainsKey(input))
                Console.WriteLine(input + " is ranked " + BoyRanks[input] + " out of the top 1000 Boy's Names with " + BoyNames[input] + " entered names.");
            else
                Console.WriteLine(input + " is not ranked on the top 1000 of Boy's Names.");

            if (GirlNames.ContainsKey(input))
                Console.WriteLine(input + " is ranked " + GirlRanks[input] + " out of the top 1000 Girl's Names with " + GirlNames[input] + " entered names.");
            else
                Console.WriteLine(input + " is not ranked on the top 1000 of Girl's Names.");

            Console.Read();
        }
    }
}
