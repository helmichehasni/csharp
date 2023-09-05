using System.Reflection.Metadata;

namespace FileTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = $"test-bakcup-{DateTime.Now}.txt";
            string vs2022 = @"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe";
            if (File.Exists(vs2022))
            {
                Console.WriteLine("VS 2022 Community is installed");
            }
            else
            {
                Console.WriteLine("VS 2022 Community is NOT installed");
            }

        }
    }
}