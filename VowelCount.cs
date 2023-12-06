using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignments
{
    public class VowelCount
    {
        public int getVowelCount(string enteredVal)
        {
            //enter string value eg Samuel
            /*Console.WriteLine("Enter String");*/
            string valueInputed = enteredVal;
            int vowelCount = CountVowels(valueInputed);
            //count the value of  string in entered value
            Console.WriteLine($"Number of vowels in inputed string {vowelCount}");
            return vowelCount;
        }

        public int CountVowels(string valueInputed)
        {
            //check my count of the stated value 
            int count = 0;
            foreach (char c in valueInputed)
            {
                string vowelSounds = "aeiouAEIOU";
                bool statusVowel = vowelSounds.Contains(c);
                if (statusVowel)
                {
                    count++;
                }
            }
            return count;
        }


    }
}
