using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignments
{
    public class CapitalizeWords
    {
        public string capitalizeWords(string str)
        {
            List<string> words = str.Split(" ").ToList();
            string summedStr = "";
            foreach (var word in words)
            {
                string restVal = word.Substring(1, word.Length - 1);
                summedStr += $"{char.ToUpper(word[0])}{restVal} ";
                //Get the first Letter of each word
            }
            Console.WriteLine(summedStr);
            return summedStr.TrimEnd();
        }
    }
}
