namespace Tran_Thanh_Mai___31231022190___24C1INF50900503
{
    internal class Session05_00
    {
        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void Main(string[] args)
        {
            int a = 6;
            int b = 7;
            Console.WriteLine($"Before call a ={a}, b = {b}");
            Console.WriteLine($"After call a ={a}, b = {b}");
            Console.ReadKey();
        }
    }
}
