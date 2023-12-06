using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignments
{
    public class ChunkArray
    {

        public List<string>  getSubArray( int[] arrays, int chunk)
        {
            int[] arrayVal = arrays;
            int chunkSize = chunk;

            //create a list to store result

            List<List<int>> results = new List<List<int>>();
            List<string> newArrayVal = new List<string>();
            for (int i = 0; i<arrayVal.Length; i+=chunkSize)
            {
                var chunkElement = arrayVal.Skip(i).Take(chunkSize).ToList();
                results.Add(chunkElement);
            }
            foreach (var subArray in results)
            {
                newArrayVal.Add($"[{string.Join(", ", subArray)}]");
            }
            return newArrayVal;
        }
    }
}
