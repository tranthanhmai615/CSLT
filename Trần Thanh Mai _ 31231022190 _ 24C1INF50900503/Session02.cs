public class Session02
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
        // đổi độ C sang độ F
        Console.Write("Nhap vao do C: ");
        float c = float.Parse(Console.ReadLine());
        double k = c + 273;
        double f = c * 18 / 10 + 32;
        Console.WriteLine($"Chuyen thanh do K: {k}");
        Console.WriteLine($"Chuyen thanh do F: {f}");
    }
    public static void Question02()
    {
        // tính diện tích bề mặt và bán kính
        Console.Write("Nhap vao ban kinh: ");
        float r = float.Parse(Console.ReadLine());
        double pi = Math.PI;
        double s = 4 * pi * Math.Pow(r, 2);
        double v = 4 / 3 * pi * Math.Pow(r, 3);
        Console.WriteLine($"Dien tich la: {s}");
        Console.WriteLine($"The tich la: {v}");
    }
    public static void Question03()
    {
        // phép tính
        Console.Write("Nhap vao a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Nhap vao b: ");
        float b = float.Parse(Console.ReadLine());
        double cong = a + b;
        double tru = a - b;
        double nhan = a * b;
        double chia = a / b;
        double du = a % b;
        Console.WriteLine($"{a} + {b} = {cong}");
        Console.WriteLine($"{a} - {b} = {tru}");
        Console.WriteLine($"{a} * {b} = {nhan}");
        Console.WriteLine($"{a} / {b} = {chia}");
        Console.WriteLine($"{a} % {b} = {du}");
    }
}