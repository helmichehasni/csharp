namespace FileProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file name");
            string fileName = Console.ReadLine();   
            if(fileName == null)
            {
                string path = "C:\\Users\\helmi.che.hasni\\Documents\\" + fileName;
                //how to read content of file
                //filestream, streamreader
                using (StreamReader reader = new StreamReader(path))
                {
                    string record;
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        try
                        {
                            TimeCard tc = TimeCard.CreateTimeCard(record);
                            double grossPay = tc.GetGrossPay();
                            Console.WriteLine($"{tc.Name}\t{grossPay}");
                        }
                        catch (FormatException ex)
                        {

                            Console.WriteLine("Record not formatted correctly. Process next record;"); ;
                        }

                    }
                }
            }
            else
            {
                Console.WriteLine("invalid file name");
            }
        }
    }
}