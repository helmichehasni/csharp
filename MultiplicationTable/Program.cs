namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mathTable = new int[10, 5];

            for (int i = 0; i < mathTable.GetLength(0); i++)
            {
                for (int j = 0; j < mathTable.GetLength(1); j++)
                {
                    mathTable[i, j] = i * j;
                    Console.Write($"{mathTable[i,j],6}");
                }
            }
        }
    }
}