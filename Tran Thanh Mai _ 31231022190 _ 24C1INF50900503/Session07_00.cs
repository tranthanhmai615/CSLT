namespace Tran_Thanh_Mai___31231022190___24C1INF50900503
{
internal class Session07_00
{
    static void NhapMangBangCom( int[,]a, int rows,int columns)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write($"a[{i}, {j}] = ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }
    static void Nhaprandom (int[,] a, int rows, int columns)
    {
            Random random = new Random();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write($"a[{i}, {j}] = ");
                a[i, j] = random.Next(0, 100);
            }
        }
    }
    static void XuatMang(int[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
static void SearchLinear(int [,] a, int value)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength (1); j++)
            {
                if ( a[i, j] == value)
                {
                    Console.WriteLine($"{value} xuat hien tai dong {i} cot {j}\n");
                    return;
                }
            }
        }
    }
private static void Main (string[] args)
    {
        int[,] a;
        Console.Write("Nhap so dong: "); int rows = int.Parse(Console.ReadLine());
        Console.Write("Nhap so cot: "); int cols = int.Parse(Console.ReadLine());
        //tao mang 2 chieu
        a = new int[rows, cols];
        //NhapMangBangCom(a, row, cols);
        NhapMangBangCom (a, rows, cols);
        XuatMang(a);

        Console.WriteLine();
        Console.Write("Nhap so can tim: "); int val = int.Parse(Console.ReadLine());
        SearchLinear(a, val);
    }
}
