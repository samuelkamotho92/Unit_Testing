using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignments
{
    public class MostAppearing
    {
        public char countMostChar(string str)
        {
            //create a Dictionary having Tkey and TValue having key and value pair
            Dictionary<char, int> result = new Dictionary<char, int>();
            //Enter input values
          //  Console.WriteLine("Enter Input Value to check repeating string");
            string enteredString = str.ToLower();
            for (int i = 0; i < enteredString.Length; i++)
            {
                char sValue = enteredString[i];
                if (result.ContainsKey(sValue))
                {
                    result[sValue]++;
                }
                else
                {
                    result[sValue] = 1;
                }
            }
            foreach (var entry in result)
            {
                Console.WriteLine(entry);
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
            KeyValuePair<char, int> maxEntry = default;
            foreach (var entry in result)
            {
                if (maxEntry.Equals(default) || entry.Value  > maxEntry.Value)
                {
                    maxEntry = entry;
                }
            }
            Console.WriteLine(maxEntry.Key);
            return maxEntry.Key;
        }
    }
}
