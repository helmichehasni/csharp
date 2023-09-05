namespace DataScrubbing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phone = " 817-555-1212 ";
            string scrubbedPhone;
            scrubbedPhone = ScrubPhone(phone);
            // returns "817-555-1212"
            Console.WriteLine($"{scrubbedPhone}");

            phone = " 817-555-1212 ";
            scrubbedPhone = ScrubPhone(phone, '-');
            // returns "8175551212"
            Console.WriteLine($"{scrubbedPhone}");

            phone = " 817-555-1212 ";
            scrubbedPhone = ScrubPhone(phone, '-', '.');
            // returns "817.555.1212"
            Console.WriteLine($"{scrubbedPhone}");
        }

        public static string ScrubPhone(string phoneNumber)
        {
            phoneNumber = phoneNumber.Trim();
            return phoneNumber;
        }

        public static string ScrubPhone(string phoneNumber, char charToRemove)
        {
            phoneNumber = phoneNumber.Replace(charToRemove,'\0').Trim();
            return phoneNumber;
        }

        public static  string ScrubPhone(string phoneNumber,char charToRemove, char charToReplaceWith)
        {
            phoneNumber = phoneNumber.Replace(charToRemove, charToReplaceWith).Trim();
            return phoneNumber;

        }

    }
}