namespace DaysOfCodeCSharp
{
    class Day1 {
        static void Main(String[] args) {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int secInt = Int32.Parse(Console.ReadLine());
            double secDou = Double.Parse(Console.ReadLine());
            string secStr = Console.ReadLine();

            Console.WriteLine(i + secInt);
            double douSum = d + secDou;
            Console.WriteLine(douSum.ToString("0.0"));
            Console.WriteLine(s + secStr);
        }
    }
}