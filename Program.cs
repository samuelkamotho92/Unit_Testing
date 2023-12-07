using TestAssignments;

Console.WriteLine("Change the world");
CapitalizeWords capitalizeWords = new CapitalizeWords();
capitalizeWords.capitalizeWords("Best day of my life");

ChunkArray chunkArray = new ChunkArray();
int[] arrayVal = { 1, 2, 3, 3, 4, 5, 6, 7 };
int chunk = 3;
chunkArray.getSubArray(arrayVal,chunk);
