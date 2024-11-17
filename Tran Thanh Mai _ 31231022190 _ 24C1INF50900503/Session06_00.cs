namespace Tran_Thanh_Mai___31231022190___24C1INF50900503
{
    internal class Session06_01
    {
        public static void Main()
        {
            //ss();
            change();

            Console.ReadKey();
        }
        public static void Main01()
        {
            //Enter item values for this array
            Console.Write("Nhap vao N: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao phan tu: ");
            int[] num = new int[n];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Enter a number: ");

            }
        }
        public static void ss()
        {
            int[] a = { 3, 5, 7 };
            foreach (int item in a)
            {
                Console.WriteLine($"{item}, ");
            }
        }
        public static void change()
        {
            int[] a = { 3, 5, 7 };
            for (int i = 0; i < a.Length; i++)
            {
                a[i]++;
                Console.WriteLine($"{a[i]}, ");
            }
        }
    }
}
