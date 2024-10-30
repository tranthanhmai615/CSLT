public class Session04_03
{
    public static void Main()
    {
        //Question_01();
        //Question_02();
        //Question_03();
        //Question_04();
        //Question_06();
        //Question_07();
        //Question_08();
        Console.ReadKey();
    }
    public static void Question_01()
    {
        //ktra xem tam giac la deu, can hay co 3 canh ko bang nhau
        Console.Write("Nhap canh a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap canh b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Nhap canh c: ");
        int c = int.Parse(Console.ReadLine());
        if (a == b && b == c && c == a) { Console.Write("Tam giac la tam giac deu."); }
        else if (a == b || b == c || a == c) { Console.Write("Tam giac la tam giac can."); }
        else Console.Write("Tam giac co 3 canh ko bang nhau.");
    }
    public static void Question_02()
    {
        //nhap 10 so va tim sum, average
        Console.Write("Nhap so phan tu: ");
        int n = int.Parse(Console.ReadLine());
        int i;
        int[] arr = new int[n];
        for (i = 0; i < n; i++)
        {
            Console.Write($"Phan tu {i}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        int S = 0;
        for (i = 0; i < n; i++) S = S + arr[i];
        Console.WriteLine($"Tong cua cac phan tu la: {S}.");
        int tb = S / n;
        Console.Write($"Trung binh cac phan tu la: {tb}");
    }
    public static void Question_03()
    {
        //lap bang cuu chuong cua 1 so
        Console.Write("Nhap 1 so: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Bang cuu chuong cua {n}: ");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i} ");
        }
    }

    public static void Question_04()
    {
        Console.Write("Nhap so dong: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Hoa tiet tam giac vuong so lap lai: ");
        int i, j;
        for (i = 1; i <= n; i++)
        {
            for (j = 1; j <= i; j++) Console.Write(j + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Hoa tiet tam giac vuong so lien tuc: ");
        int num = 1;
        for (i = 1; i <= n; i++)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write(num + " ");
                num++;
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Hoa tiet tam giac can so lien tuc: ");
        int num2 = 1;
        for (i = 1; i <= n; i++)
        {
            for (int space = 1; space <= n - i; space++)
                Console.Write(" ");

            for (j = 1; j <= i; j++)
            {
                Console.Write(num2 + " ");
                num2++;
            }

            Console.WriteLine();
        }
    }

    public static void Question_06()
    {
        //nhap n so va tinh tong 1+1/2+1/3+...+1/n
        Console.Write("Nhap so phan tu: ");
        int n = int.Parse(Console.ReadLine());
        int i;
        double S = 1;
        for (i = 2; i <= n; i++) S = S + 1f / i;
        Console.WriteLine($"1+1/2+1/3+...+1/{n} = {S}.");
    }
    public static void Question_07()
    {
        //so hoan hao (so co cac uoc cong lai = chinh no)
        Console.Write("Nhap 1 so: ");
        int n = int.Parse(Console.ReadLine());
        int S = 0;
        for (int i = 1; i < n; i++) if (n % i == 0) S = S + i;
        Console.WriteLine($"Tong cac uoc cua {n} = {S}");
        if (S == n) Console.WriteLine($"{n} la so hoan hao.");
        else Console.WriteLine($"{n} khong la so hoan hao.");

    }
    public static void Question_08()
    {
        //so nguyen to
        Console.Write("Nhap 1 so: ");
        int n = int.Parse(Console.ReadLine());
        int S = 0;
        for (int i = 1; i <= n; i++) if (n % i == 0) S++;
        if (S == 2) Console.WriteLine($"{n} la so nguyen to.");
        else Console.WriteLine($"{n} khong la so nguyen to.");
    }
}