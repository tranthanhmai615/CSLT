public class Session04_02
{
    public static void Main()
    {
        //Question01();
        //Question02();
        //Question03();
        Console.ReadKey();
    }
    public static void Question01()
    {
        //Kiem tra so a la chan hay le
        Console.Write("Nhap vao so a: ");
        int a = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine($"{a} la so chan");
        }
        else
        {
            Console.WriteLine($"{a} la so le");
        }
    }
    public static void Question02()
    {
        //Tim so lon nhat trong 3 so
        Console.Write("Nhap vao so a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap vao so b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Nhap vao so c: ");
        int c = int.Parse(Console.ReadLine());
        int Max = a;
        if (b > Max)
        {
            Max = b;
        }
        if (c > Max)
        {
            c = Max;
        }
        Console.WriteLine($"So lon nhat la: {Max}");
    }
    public static void Question03()
    {
        //Tim goc phan tu
        Console.Write("Nhap toa do mot diem: x =  ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Nhap toa do mot diem: y =  ");
        int y = int.Parse(Console.ReadLine());
        if (x > 0 && y > 0 )
        {
            Console.WriteLine("Toa do thuoc phan tu thu nhat la: ");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Toa do thuoc phan tu thu hai la: ");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Toa do thuoc phan tu thu ba la: ");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Toa do thuoc phan tu thu tu la: ");
        }
        else if (x == 0 && y == 0)
        {
            Console.WriteLine("Goc toa do la: ");
        }
    }
}
