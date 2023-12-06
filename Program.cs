// See https://aka.ms/new-console-template for more information
using TestAssignments;

Console.WriteLine("Change the world");
CapitalizeWords capitalizeWords = new CapitalizeWords();
capitalizeWords.capitalizeWords("Best day of my life");

ChunkArray chunkArray = new ChunkArray();
int[] arrayVal = { 1, 2, 3, 3, 4, 5, 6, 7 };
int chunk = 3;
chunkArray.getSubArray(arrayVal,chunk);
string [] values = { "[[ 1, 2, 3 ], [ 3, 4, 5 ], [ 6, 7 ] ]", "[[ 1 ], [ 2 ], [ 3 ], [ 5 ], [ 6 ], [ 7 ] ]" };
foreach (var item in values)
{
/*    Console.WriteLine(item);*/
}
List<string> myStrOut = new List<string>(values);

/*Console.WriteLine(myStrOut[1]);*/