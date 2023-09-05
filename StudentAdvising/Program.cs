namespace StudentAdvising
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static string GetData()
            {
                Console.WriteLine("What is the student's name?");
                string name = Console.ReadLine();

                Console.WriteLine("What is the student's major?");
                string major = Console.ReadLine();

                Console.WriteLine("What is the student's classification?");
                string clasify = Console.ReadLine();
            }
            
        }
    }
}